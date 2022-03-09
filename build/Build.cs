using System;
using System.Linq;
using System.IO;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common.Tools.MSBuild;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.MSBuild.MSBuildTasks;
using System.Diagnostics;
using Nuke.Common.CI.TeamCity;

[TeamCity(    
    VcsTriggeredTargets = new[] { nameof(Clean)},
    Version = "2021.2",
    NightlyTriggeredTargets = new[] { nameof(Clean)},
    AutoGenerate = true,
    ManuallyTriggeredTargets = new[] { nameof(Pack)})]
[CheckBuildProjectConfigurations]
 partial class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main()
    {
        return Execute<Build>(x => x.Clean);
    }

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Solution] readonly Solution Solution;
    [GitRepository] readonly GitRepository GitRepository;
    [GitVersion] readonly GitVersion GitVersion;

    AbsolutePath SourceDirectory => RootDirectory;
    AbsolutePath BinDirectory => RootDirectory / "bin";
    AbsolutePath TestsDirectory => RootDirectory / "tests";
    AbsolutePath OutputDirectory => RootDirectory / "Installer" / "output";
    AbsolutePath InstallerBuilder => RootDirectory / "Installer" / "bin" / Configuration.ToString()/"Installer.exe";

    string RuntimeDownloadPage => "https://github.com/DynamoDS/Dynamo/releases/download/v2.7.0/DynamoCoreRuntime_2.7.0.9206.zip";

    /// <summary>
    /// Clean bin files
    /// </summary>
    Target Clean => _ => _
        .Executes(() =>
        {
            //SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            //TestsDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            DeleteDirectory(BinDirectory);
            DeleteDirectory(DynamoCoreRuntime);
            EnsureCleanDirectory(OutputDirectory);
        })
        .Triggers(InitDynamoCoreRuntime)
        .Triggers(Restore);

    /// <summary>
    /// Restore
    /// </summary>
    Target Restore => _ => _
        .Executes(() =>
        {
            MSBuild(s => s
                .SetTargetPath(Solution)
                .SetTargets("Restore"));
        }).Triggers(Compile);

    Target Compile => _ => _
        .After(CopyRuntime)
        .Executes(() =>
        {
            MSBuild(s => s
                .SetTargetPath(Solution)
                .SetTargets("Rebuild")
                .SetConfiguration(Configuration)
                .SetAssemblyVersion(GitVersion.AssemblySemVer)
                .SetFileVersion(GitVersion.AssemblySemFileVer)
                .SetInformationalVersion(GitVersion.InformationalVersion)
                .SetMaxCpuCount(Environment.ProcessorCount)
                .SetNodeReuse(IsLocalBuild));
        })
        .Triggers(Pack);

    /// <summary>
    /// Product Installer
    /// </summary>
    Target Pack => _ => _
        .After(Compile)
        //.Produces(OutputDirectory/"*.msi")
        .Executes(() =>
        {
            var process = Process.Start(InstallerBuilder.ToString(), "/MSBUILD:Installer "+ Configuration.ToString());

            process.WaitForExit();
            if (process.ExitCode != 0) throw new Exception("The installer creation failed.");
        }); 
}

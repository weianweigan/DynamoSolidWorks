using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using WixSharp;
using WixSharp.CommonTasks;

const string installationDir = @"%ProgramFiles%\Dynamo\DynamoSolidWorks";
const string projectName = "DynamoSldWorks";
const string outputName = "DynamoSldWorks";
const string outputDir = "output";
var version = GetVersion();
var fileName = new StringBuilder().Append(outputName).Append("-").Append(version);
string IconDir = Path.Combine(GetGitDirectory(),"src");

var project = new ManagedProject
{
    Name = projectName,
    OutDir = outputDir,
    Platform = Platform.x64,
    UI = WUI.WixUI_InstallDir,
    Version = new Version(version),
    OutFileName = fileName.ToString(),
    InstallScope = InstallScope.perMachine,
    InstallPrivileges = InstallPrivileges.elevated,
    MajorUpgrade = MajorUpgrade.Default,
    GUID = new Guid("62E8D571-F797-428D-A8A5-BDEAE1EADDF9"),
    BackgroundImage = $@"{IconDir}\Installer\Resources\Icons\logo_about.png",
    BannerImage = $@"{IconDir}\Installer\Resources\Icons\logo_about.png",
    ControlPanelInfo =
    {
        Manufacturer = "WeiGan",
        HelpLink = "https://github.com/weianweigan/DynamoSolidWorks",
        ProductIcon = $@"{IconDir}\Installer\Resources\Icons\ShellIcon.ico"
    },
    Dirs = new Dir[]
    {
        new InstallDir(installationDir, GenerateWixEntities())
    },
    Actions = new WixSharp.Action[]
    {
        new WixSharp.InstalledFileAction(
            "uninstall_bat","",
            Return.ignore,
            When.Before,
            Step.RemoveFiles,
            Condition.Always)
    }
    //LicenceFile = 
};

project.AfterInstall += (e) =>
{
    try
    {
        if(e.Mode == SetupEventArgs.SetupMode.Installing)
            Process.Start(e.InstallDir.PathCombine("Install.bat"));
    }
    catch (global::System.Exception ex)
    {
        
    }
};

MajorUpgrade.Default.AllowSameVersionUpgrades = true;
var location = project.BuildMsi();
Console.WriteLine($"Finish:{location}");

WixEntity[] GenerateWixEntities()
{
    var directory = GetBinDirectory();

    var directoryInfo = new DirectoryInfo(directory);
    var files = new Files($@"{directory}\*.*",p => !p.EndsWith(".bat"));

    var entities = new List<WixEntity>
    {
        files,
        new WixSharp.File(new Id("install_bat"),Path.Combine(directory,"Install.bat")),
        new WixSharp.File(new Id("uninstall_bat"),Path.Combine(directory,"UnInstall.bat")),
    }.ToArray();
    return entities;
}

string GetBinDirectory()
{
    string dir = GetGitDirectory();

    var desDir = Path.Combine(dir, "bin", "Debug");

    return desDir;
}

string GetGitDirectory()
{
    var dirStr = Path.GetDirectoryName(typeof(Program).Assembly.Location);
    var dir = new DirectoryInfo(dirStr);

    //Find git location
    while (!dir.GetDirectories().Any(p => p.Name == ".git"))
    {
        dir = dir.Parent;
    }

    return dir.FullName;
}

string GetVersion()
{
    var directory = GetBinDirectory();

    var mainDll = Path.Combine(directory, "DynamoSldWorks.dll");

    var version = FileVersionInfo.GetVersionInfo(mainDll);

    return version.FileVersion;
}

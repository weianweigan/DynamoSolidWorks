using System;
using System.Linq;
using System.IO;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using static Nuke.Common.IO.FileSystemTasks;

partial class Build
{
    AbsolutePath DynamoCoreRuntime => RootDirectory / "DynamoRuntime";
    AbsolutePath DynamoModernTheme => DynamoCoreRuntime / "UI" / "Themes" / "Modern" / "DynamoModern.xaml";

    string AllRuntimeDir = @"D:\DynamoCoreRuntime";

    [Parameter(Name ="DynamoCoreRuntimeVersion")]
    string DynamoVersion = "2.7.0";

    Target InitDynamoCoreRuntime => _ => _
    .Executes(() =>
    {
        var dir = new DirectoryInfo(AllRuntimeDir);
        string dynamoDirName = $"DynamoCoreRuntime_{DynamoVersion}";
        var coreDir = dir
            .GetDirectories()
            .Where(dir => dir.FullName.StartsWith(dynamoDirName))
            .FirstOrDefault();
        if (coreDir != null && coreDir.Exists)
        {
            CopyDirectoryRecursively(coreDir.FullName, RootDirectory / "DynamoRuntime");
        }
        else
        {
            throw new DirectoryNotFoundException($"Cannot found {dynamoDirName}");
        }
    }).Triggers(ModifyIsReadonlyError);

    Target ModifyIsReadonlyError => _ => _
        .Executes(() =>
        {
            var filePath = DynamoModernTheme.ToString();
            Console.WriteLine(filePath, ConsoleColor.Red);
            if (!File.Exists(filePath))
                return;

            var data = File.ReadAllText(filePath);
            data = data.Replace("IsReadOnly=\"{TemplateBinding IsReadOnly}\"", "");
            File.WriteAllText(filePath, data);
        }).Triggers(CopyRuntime);

    Target CopyRuntime => _ => _
        .Executes(() =>
        {
            CopyDirectoryRecursively(DynamoCoreRuntime,  BinDirectory / Configuration.ToString());
        });
}


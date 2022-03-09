using System;
using System.IO;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using static Nuke.Common.IO.FileSystemTasks;

partial class Build
{
    AbsolutePath DynamoCoreRuntime => RootDirectory / "DynamoRuntime";
    AbsolutePath DynamoModernTheme => DynamoCoreRuntime / "UI" / "Themes" / "Modern" / "DynamoModern.xaml";

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


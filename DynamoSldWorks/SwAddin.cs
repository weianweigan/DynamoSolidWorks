/*
 * To use Dynamo Runtime,you need modify and compile it youself.
 * In https://github.com/DynamoDS/Dynamo/blob/master/src/DynamoCoreWpf/UI/Prompts/dynEditWindow.xaml Line46,you need change it to
 * <ResourceDictionary Source="pack://application:,,,/DynamoCoreWpf;component/UI/Themes/Modern/DynamoModern.xaml" />
 * Or it will cause a wpf exception.
 * See Issue https://github.com/DynamoDS/Dynamo/issues/12650
 * 
 */

using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using DynamoSldWorks.View;
using System.ComponentModel;
using Xarial.XCad.SolidWorks;
using Xarial.XCad.UI.Commands;
using Xarial.XCad.Base.Attributes;
using System.Runtime.InteropServices;
using SolidWorks.Interop.sldworks;
using Xarial.XCad;
using SldWorksService;
using System.Threading;
using Dynamo.Extensions;
using DynamoSldWorks.Model;
using System.Collections.Generic;
using SolidWorks.Interop.swconst;
using Xarial.XCad.Base.Enums;
using Xarial.XCad.SolidWorks.UI;

namespace DynamoSldWorks
{
    [ComVisible(true)]
    [Title("DynamoSolidWorks"),Description(" Graphical Programming for Design in SolidWorks")]
    [Guid("62E8D571-F797-428D-A8A5-BDEAE1EADDF9")]
    public class SwAddin:SwAddInEx
    {
        #region Field
        private static readonly string _assemblyLocation = Assembly.GetExecutingAssembly().Location;
        private static string _dynamopath;
        private DynamoSetup _dynamoSetup;
        private ISwTaskPane<DynamoTaskPane> _cmdTaskPane;
        #endregion

        #region Properties
        public static string DynamoCorePath
        {
            get
            {
                if (string.IsNullOrEmpty(_dynamopath))
                {
                    _dynamopath = Path.GetDirectoryName(typeof(SwAddin).Assembly.Location);
                }
                return _dynamopath;
            }
        }

        public ISldWorks App => Application.Sw;

        public DynamoSetup DynamoSetup { get => _dynamoSetup; set => _dynamoSetup = value; }

        #endregion

        #region Methods

        public override void OnConnect()
        {
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;

            _cmdTaskPane = CreateTaskPane<DynamoTaskPane>();
            _cmdTaskPane.Control.Init(this);

            CommandManager.AddCommandGroup<Commands>().CommandClick += SwAddin_CommandClick;
        }

        private void SwAddin_CommandClick(Commands spec)
        {
            switch (spec)
            {
                case Commands.Dynamo:
                    RunDynamo();
                    break;
                case Commands.SnoopPID:
                    SnoopPID();
                    break;
                default:
                    break;
            }
        }

        private void SnoopPID()
        {
            var doc = Application.Documents.Active?.Model;
            if (doc == null)
            {
                Application.ShowMessageBox("No active doc", MessageBoxIcon_e.Error);
                return;
            }

            var count = doc.ISelectionManager.GetSelectedObjectCount();

            List<SelectionPID> pids = new List<SelectionPID>();

            for (int i = 1; i < count + 1; i++)
            {
                var mark = doc.ISelectionManager.GetSelectedObjectMark(i);
                var obj = doc.ISelectionManager.GetSelectedObject6(i, mark);
                var type = (swSelectType_e)doc.ISelectionManager.GetSelectedObjectType3(i, mark);
                var pid = doc.Extension.GetPersistReference3(obj);

                pids.Add(SelectionPID.Create(type, obj, mark, pid));
            }

            var window = CreatePopupWindow<SelectionPIDWindow>();
            window.Control.VM = new SelectionPIDViewModel(pids, Application);
            window?.Show();
        }

        private void RunDynamo()
        {
            InitDynamoSetup();
            DynamoSetup.Start(this.Application.WindowHandle);
        }

        public void InitDynamoSetup()
        {
            if (DynamoSetup == null) DynamoSetup = DynamoSetup.Create(this.Application);
        }
        #endregion

        #region Path Resolver
        /// <summary>
        /// Handler to the ApplicationDomain's AssemblyResolve event.
        /// If an assembly's location cannot be resolved, an exception is
        /// thrown. Failure to resolve an assembly will leave Dynamo in 
        /// a bad state, so we should throw an exception here which gets caught 
        /// by our unhandled exception handler and presents the crash dialogue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            var assemblyPath = string.Empty;
            var assemblyName = new AssemblyName(args.Name).Name + ".dll";

            try
            {
                assemblyPath = CombinePath(DynamoCorePath, assemblyName);
                if (File.Exists(assemblyPath))
                {
                    return Assembly.LoadFrom(assemblyPath);
                }

                var assemblyLocation = Assembly.GetExecutingAssembly().Location;
                var assemblyDirectory = Path.GetDirectoryName(assemblyLocation);

                assemblyPath = CombinePath(assemblyDirectory, assemblyName);
                if (!File.Exists(assemblyPath))
                {
                    var parentDirectory = Directory.GetParent(assemblyDirectory);
                    assemblyPath = CombinePath(parentDirectory.FullName, assemblyName);
                }

                if (!File.Exists(assemblyPath))
                {
                    var name = Thread.CurrentThread?.CurrentCulture?.Name;
                    assemblyPath = Path.Combine(assemblyDirectory, name,assemblyName);
                }

                if (File.Exists(assemblyPath))
                {
                   return Assembly.LoadFrom(assemblyPath);
                }
                else
                {
                    Debug.Print(assemblyPath);
                    return null; 
                }

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("The location of the assembly, {0} could not be resolved for loading.", assemblyPath), ex);
            }
        }

        private static string CombinePath(string path,string name)
        {
            return path.EndsWith("\\") ? path + name : path + "\\" + name;
        }
        #endregion
    }
}

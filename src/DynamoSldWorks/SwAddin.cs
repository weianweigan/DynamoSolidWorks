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

namespace DynamoSldWorks
{
    [ComVisible(true)]
    [Title("DynamoSolidWorks"),Description(" Graphical Programming for Design in SolidWorks")]
    public class SwAddin:SwAddInEx,ISldWorksContext
    {
        #region Field
        private static readonly string _assemblyLocation = Assembly.GetExecutingAssembly().Location;
        private static string _dynamopath;
        private DynamoSetup _dynamoSetup;
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

        public IXServiceCollection Services => Application.CustomServices;
        #endregion

        #region Methods

        public override void OnConnect()
        {
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;

            CommandManager.AddCommandGroup<Commands>().CommandClick += SwAddin_CommandClick;
        }

        private void SwAddin_CommandClick(Commands spec)
        {
            _dynamoSetup = DynamoSetup.Create(this.Application);
            _dynamoSetup.RunApp(this.Application.WindowHandle);   
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

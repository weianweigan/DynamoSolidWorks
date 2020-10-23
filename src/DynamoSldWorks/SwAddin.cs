using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Xarial.XCad.Base.Attributes;
using Xarial.XCad.SolidWorks;
using Xarial.XCad.UI.Commands;

namespace DynamoSldWorks
{
    [ComVisible(true)]
    [Title("DynamoSolidWorks"),Description(" Graphical Programming for Design in SolidWorks")]
    public class SwAddin:SwAddInEx
    {
        #region Field

        private static readonly string assemblyName = Assembly.GetExecutingAssembly().Location;

        private static string dynamopath;

        public static string DynamoCorePath
        {
            get
            {
                if (string.IsNullOrEmpty(dynamopath))
                {
                    dynamopath = Path.GetDirectoryName(typeof(SwAddin).Assembly.Location);
                }
                return dynamopath;
            }
        }

        private View.DynamoSetup _dynamoSetup;

        #endregion

        #region Methods

        public override void OnConnect()
        {
            CommandManager.AddCommandGroup<Commands>().CommandClick += SwAddin_CommandClick;
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
        }

        private void SwAddin_CommandClick(Commands spec)
        {
            _dynamoSetup = View.DynamoSetup.Create();
            _dynamoSetup.RunApp(this.Application.WindowHandle);
           
        }

        #endregion

        #region Path Resolver

        /// <summary>
        /// Finds the Dynamo Core path by looking into registery or potentially a config file.
        /// </summary>
        /// <returns>The root folder path of Dynamo Core.</returns>
        private static string GetDynamoCorePath()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var dynamoSolidWorksRootDirectory = Path.GetDirectoryName(Path.GetDirectoryName(assemblyName));
            var dynamoRoot = GetDynamoRoot(dynamoSolidWorksRootDirectory);

            var assembly = Assembly.LoadFrom(Path.Combine(dynamoSolidWorksRootDirectory, "DynamoInstallDetective.dll"));
            var type = assembly.GetType("DynamoInstallDetective.DynamoProducts");

            var methodToInvoke = type.GetMethod("GetDynamoPath", BindingFlags.Public | BindingFlags.Static);
            if (methodToInvoke == null)
            {
                throw new MissingMethodException("Method 'DynamoInstallDetective.DynamoProducts.GetDynamoPath' not found");
            }

            var methodParams = new object[] { version, dynamoRoot };
            return methodToInvoke.Invoke(null, methodParams) as string;
        }

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
                assemblyPath = Path.Combine(DynamoCorePath, assemblyName);
                if (File.Exists(assemblyPath))
                {
                    return Assembly.LoadFrom(assemblyPath);
                }

                var assemblyLocation = Assembly.GetExecutingAssembly().Location;
                var assemblyDirectory = Path.GetDirectoryName(assemblyLocation);

                // Try "Dynamo 0.x\Revit_20xx" folder first...
                assemblyPath = Path.Combine(assemblyDirectory, assemblyName);
                if (!File.Exists(assemblyPath))
                {
                    // If assembly cannot be found, try in "Dynamo 0.x" folder.
                    var parentDirectory = Directory.GetParent(assemblyDirectory);
                    assemblyPath = Path.Combine(parentDirectory.FullName, assemblyName);
                }

                return (File.Exists(assemblyPath) ? Assembly.LoadFrom(assemblyPath) : null);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("The location of the assembly, {0} could not be resolved for loading.", assemblyPath), ex);
            }
        }

        /// <summary>
        /// Gets Dynamo Root folder from the given DynamoRevit root.
        /// </summary>
        /// <param name="dynamoRevitRoot">The root folder of DynamoRevit binaries</param>
        /// <returns>The root folder path of Dynamo Core</returns>
        private static string GetDynamoRoot(string dynamoRevitRoot)
        {
            //TODO: use config file to setup Dynamo Path for debug builds.

            //When there is no config file, just replace DynamoRevit by Dynamo 
            //from the 'dynamoRevitRoot' folder.
            var parent = new DirectoryInfo(dynamoRevitRoot);
            var path = string.Empty;
            while (null != parent && parent.Name != @"DynamoRevit")
            {
                path = Path.Combine(parent.Name, path);
                parent = Directory.GetParent(parent.FullName);
            }

            return parent != null ? Path.Combine(Path.GetDirectoryName(parent.FullName), @"Dynamo", path) : dynamoRevitRoot;
        }

        #endregion
    }
}

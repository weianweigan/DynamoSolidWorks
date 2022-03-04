using Dynamo.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace DynamoSldWorks.Model
{
    public class SwPathReSolver : IPathResolver
    {
        private readonly List<string> preloadLibraryPaths;
        private readonly List<string> additionalNodeDirectories;
        private readonly List<string> additionalResolutionPaths;
        private readonly string userDataRootFolder;
        private readonly string commonDataRootFolder;

        public SwPathReSolver()
        {
            var userDataFolder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Dynamo", "Dynamo SolidWorks");
            var commonDataFolder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Dynamo", "Dynamo SolidWorks");


            userDataRootFolder = userDataFolder;
            commonDataRootFolder = commonDataFolder;

            var nodesDirectory = Path.Combine(SwAddin.DynamoCorePath, "nodes");
            var sldWorksNodesDirectory = Path.Combine(SwAddin.DynamoCorePath,"SolidWorks");

            additionalNodeDirectories = new List<string> { nodesDirectory };
            additionalResolutionPaths = new List<string> {sldWorksNodesDirectory };

            var sldWorksNodesDll = Path.Combine(sldWorksNodesDirectory, "SldWorksNodes.dll");
            var sldWorksNodesUIDll = Path.Combine(sldWorksNodesDirectory, "SldWorksNodesUI.dll");

            preloadLibraryPaths = new List<string>
            {
                "VMDataBridge.dll",
                //"ProtoGeometry.dll",
                "DesignScriptBuiltin.dll",
                "DSCoreNodes.dll",
                "DSOffice.dll",
                //"DSIronPython.dll",//   > version 2.6 - it isn't needed to use this because DSIronPython is loaded by extension(without IronPython installed)
                "DSCPython.dll",   // > version 2.7
                "FunctionObject.ds",
                "BuiltIn.ds",
                "DynamoConversions.dll",
                "DynamoUnits.dll",
                "Tessellation.dll",
                "Analysis.dll",
                "GeometryColor.dll",
                 sldWorksNodesDll,
                 //sldWorksNodesUIDll
            };
        }

        public IEnumerable<string> AdditionalNodeDirectories
        {
            get { return additionalNodeDirectories; }
        }

        public IEnumerable<string> AdditionalResolutionPaths
        {
            get { return additionalResolutionPaths; }
        }

        public IEnumerable<string> PreloadedLibraryPaths
        {
            get { return preloadLibraryPaths; }
        }

        public string UserDataRootFolder
        {
            get { return userDataRootFolder; }
        }

        public string CommonDataRootFolder
        {
            get { return commonDataRootFolder; }
        }
    }
}

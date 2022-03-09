using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodes.Document
{
    public class AssemblyDocument : SwNodeModel<IModelDoc2>
    {
        internal AssemblyDocument(IModelDoc2 swObject)
        {
            SwObject= swObject;
            AssemblyDoc = swObject as IAssemblyDoc;
        }

        [IsVisibleInDynamoLibrary(false)]
        public IAssemblyDoc AssemblyDoc { get; }

        /// <summary>
        /// Get all Components in assembly
        /// </summary>
        /// <param name="toplevelOnly"></param>
        /// <returns></returns>
        public List<Assembly.Component> Components(bool toplevelOnly = false)
        {
            var comps = AssemblyDoc.GetComponents(toplevelOnly) as object[];

            if (comps == null)
                return null;

            return comps
                .Cast<IComponent2>()
                .Select(a => new Assembly.Component(a))
                .ToList();
        }
    }
}

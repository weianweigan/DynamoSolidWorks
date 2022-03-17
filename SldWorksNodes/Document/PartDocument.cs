using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodes.Document
{
    public class PartDocument:SwNodeModel<IModelDoc2>,ISwMaterialProperty
    {
        internal PartDocument(IModelDoc2 swObject)
        {
            SwObject = SwObject;
            PartDoc = swObject as IPartDoc;
        }

        [IsVisibleInDynamoLibrary(false)]
        public IPartDoc PartDoc { get; }

        #region Query
        /// <summary>
        /// Get all of bodies in the input document.The document must be a partdoc.
        /// </summary>
        /// <param name="visibleOnly">only get visible bodies</param>
        /// <returns></returns>
        /// <exception cref="SwException.ActiveDocIsNotPartDocException"></exception>
        public List<Geometry.Body> Bodies(bool visibleOnly = true)
        {
            if (SwObject == null)
                return null;

            var bodies = PartDoc.GetBodies2((int)swBodyType_e.swAllBodies, visibleOnly) as Object[];
            if (bodies == null)
                return null;

            return bodies
                .Cast<IBody2>()
                .Select(p => new Geometry.Body(p))
                .ToList();

        }

        public MaterialProperty MaterialProperty()
        {
            var materialValue = PartDoc.MaterialPropertyValues as double[];

            return SldWorksNodes.MaterialProperty.ByArrary(materialValue);
        }
        #endregion

        #region Action
        public void SetMaterialProperty(MaterialProperty materialProperty)
        {
            PartDoc.MaterialPropertyValues = materialProperty.ToArray();
            SwObject.GraphicsRedraw2();
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return SwObject?.GetTitle() ?? base.ToString();
        }
        #endregion
    }
}

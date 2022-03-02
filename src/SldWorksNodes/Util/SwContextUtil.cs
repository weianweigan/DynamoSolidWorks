using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SldWorksNodes.SwException;

namespace SldWorksNodes.Util
{
    [IsVisibleInDynamoLibrary(false)]
    public static class SwContextUtil
    {
        public static IFeature GetFeatureByName(string name, string featTypeName)
        {
            var existFeat = GetFeatureByName(name);

            if (existFeat.GetTypeName2() != featTypeName)
            {
                throw new FeatureTypeNameErrorException(existFeat.Name, existFeat.GetTypeName2());
            }

            return existFeat;
        }

        public static IFeature GetFeatureByName(string name)
        {
            var currentDoc = GetCurrentPartDocContext();
            var existFeat = currentDoc.FindFeat(name);
            if (existFeat == null)
            {
                throw new FeatureNotFoundException(name);
            }

            return existFeat;
        }

        public static void Rebuild()
        {
            SldContextManager.Sw.IActiveDoc2?.EditRebuild3();
        }

        public static IModelDoc2 GetCurrentPartDocContext()
        {
            var doc = SldContextManager.Sw.IActiveDoc2;
            if (doc == null) throw new ActiveDocNotFoundException();

            if (!doc.IsPartDocContext(out var currentDoc))
            {
                throw new ActiveDocIsNotPartDocException();
            }

            return currentDoc;
        }

        public static IFeature GetCurrentSelectedFeature()
        {
            var currentDoc = GetCurrentPartDocContext();
            var selectedObj = currentDoc.ISelectionManager.GetSelectedObject2(1);

            if (selectedObj == null)
                throw new SelectionNotFoundException();

            var seleType = currentDoc.ISelectionManager.GetSelectedObjectType3(1, -1);

            if (seleType != (int)swSelectType_e.swSelBODYFEATURES)
                throw new SelectionTypeErrorException(swSelectType_e.swSelBODYFEATURES);

            var feat = selectedObj as IFeature;
            if (feat == null)
                throw new FeatureNotFoundException("Selection");

            return feat;
        }

        public static object GetCurrentSelectedObject()
        {
            var currentDoc = GetCurrentPartDocContext();
            var selectedObj = currentDoc.ISelectionManager.GetSelectedObject6(1,-1);

            if (selectedObj == null)
                throw new SelectionNotFoundException();

            var seleType = currentDoc.ISelectionManager.GetSelectedObjectType3(1, -1);

            if (selectedObj == null)
                throw new SelectionNotFoundException();

            return selectedObj;
        }
    }
}

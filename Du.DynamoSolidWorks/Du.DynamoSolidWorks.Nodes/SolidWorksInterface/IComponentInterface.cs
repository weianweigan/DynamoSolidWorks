using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IComponentObject
    {
        public IComponent IComponentInstance { get; set; }
        public IComponentObject(IComponent IComponentinstance)
        {
            IComponentInstance = IComponentinstance;
        }
    }
    public static class IComponentInterface
    {
        public static Object GetChildren(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetChildren();
        }
        public static IntPtr IGetChildren(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetChildren();
        }
        public static Int32 IGetChildrenCount(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetChildrenCount();
        }
        public static Object GetXform(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetXform();
        }
        public static Double IGetXform(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetXform();
        }
        public static Object GetBody(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetBody();
        }
        public static IBodyObject IGetBody(IComponentObject IComponentinstance)
        {
            return new IBodyObject(IComponentinstance.IComponentInstance.IGetBody());
        }
        public static Int32 AddPropertyExtension(IComponentObject IComponentinstance, Object PropertyExtension)
        {
            return IComponentinstance.IComponentInstance.AddPropertyExtension(PropertyExtension);
        }
        public static Object GetPropertyExtension(IComponentObject IComponentinstance, Int32 ID)
        {
            return IComponentinstance.IComponentInstance.GetPropertyExtension(ID);
        }
        public static void ResetPropertyExtension(IComponentObject IComponentinstance)
        {
            IComponentinstance.IComponentInstance.ResetPropertyExtension();
        }
        public static String GetMaterialIdName(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetMaterialIdName();
        }
        public static Boolean SetMaterialIdName(IComponentObject IComponentinstance, String Name)
        {
            return IComponentinstance.IComponentInstance.SetMaterialIdName(Name);
        }
        public static String GetMaterialUserName(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetMaterialUserName();
        }
        public static Boolean SetMaterialUserName(IComponentObject IComponentinstance, String Name)
        {
            return IComponentinstance.IComponentInstance.SetMaterialUserName(Name);
        }
        public static Object GetSectionedBodies(IComponentObject IComponentinstance, Object ViewIn)
        {
            return IComponentinstance.IComponentInstance.GetSectionedBodies(ViewIn);
        }
        public static Object GetBox(IComponentObject IComponentinstance, Boolean IncludeRefPlanes, Boolean IncludeSketches)
        {
            return IComponentinstance.IComponentInstance.GetBox(IncludeRefPlanes, IncludeSketches);
        }
        public static Double IGetBox(IComponentObject IComponentinstance, Boolean IncludeRefPlanes, Boolean IncludeSketches)
        {
            return IComponentinstance.IComponentInstance.IGetBox(IncludeRefPlanes, IncludeSketches);
        }
        public static Boolean SetXform(IComponentObject IComponentinstance, Object XformIn)
        {
            return IComponentinstance.IComponentInstance.SetXform(XformIn);
        }
        //public static Boolean ISetXform(IComponentObject IComponentinstance, Double& XformIn)
        //{
        //    return IComponentinstance.IComponentInstance.ISetXform(XformIn);
        //}
        public static Object GetModelDoc(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetModelDoc();
        }
        public static IModelDocObject IGetModelDoc(IComponentObject IComponentinstance)
        {
            return new IModelDocObject(IComponentinstance.IComponentInstance.IGetModelDoc());
        }
        public static Boolean IsFixed(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IsFixed();
        }
        //public static IEnumBodiesObject EnumRelatedBodies(IComponentObject IComponentinstance)
        //{
        //    return new IEnumBodiesObject(IComponentinstance.IComponentInstance.EnumRelatedBodies());
        //}
        public static Boolean IsSuppressed(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IsSuppressed();
        }
        //public static IEnumBodiesObject EnumSectionedBodies(IComponentObject IComponentinstance, IModelViewObject ViewIn)
        //{
        //    return new IEnumBodiesObject(IComponentinstance.IComponentInstance.EnumSectionedBodies(ViewIn.IModelViewInstance as ModelView));
        //}
        public static Boolean IsHidden(IComponentObject IComponentinstance, Boolean ConsiderSuppressed)
        {
            return IComponentinstance.IComponentInstance.IsHidden(ConsiderSuppressed);
        }
        public static Int32 GetSuppression(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetSuppression();
        }
        public static Int32 SetSuppression(IComponentObject IComponentinstance, Int32 State)
        {
            return IComponentinstance.IComponentInstance.SetSuppression(State);
        }
        public static String GetPathName(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetPathName();
        }
        public static Boolean SetXformAndSolve(IComponentObject IComponentinstance, Object XformIn)
        {
            return IComponentinstance.IComponentInstance.SetXformAndSolve(XformIn);
        }
        //public static Boolean ISetXformAndSolve(IComponentObject IComponentinstance, Double& XformIn)
        //{
        //    return IComponentinstance.IComponentInstance.ISetXformAndSolve(XformIn);
        //}
        public static Object GetTessTriangles(IComponentObject IComponentinstance, Boolean NoConversion)
        {
            return IComponentinstance.IComponentInstance.GetTessTriangles(NoConversion);
        }
        public static Single IGetTessTriangles(IComponentObject IComponentinstance, Boolean NoConversion)
        {
            return IComponentinstance.IComponentInstance.IGetTessTriangles(NoConversion);
        }
        public static Int32 IGetTessTriangleCount(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetTessTriangleCount();
        }
        public static Object GetTessNorms(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetTessNorms();
        }
        public static Single IGetTessNorms(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetTessNorms();
        }
        public static Object GetTessTriStrips(IComponentObject IComponentinstance, Boolean NoConversion)
        {
            return IComponentinstance.IComponentInstance.GetTessTriStrips(NoConversion);
        }
        public static Single IGetTessTriStrips(IComponentObject IComponentinstance, Boolean NoConversion)
        {
            return IComponentinstance.IComponentInstance.IGetTessTriStrips(NoConversion);
        }
        public static Int32 IGetTessTriStripSize(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetTessTriStripSize();
        }
        public static Object GetTessTriStripNorms(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetTessTriStripNorms();
        }
        public static Single IGetTessTriStripNorms(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetTessTriStripNorms();
        }
        public static Object GetTessTriStripEdges(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetTessTriStripEdges();
        }
        public static Int32 IGetTessTriStripEdges(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetTessTriStripEdges();
        }
        public static Int32 IGetTessTriStripEdgeSize(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetTessTriStripEdgeSize();
        }
        public static Int32 IsDisplayDataOutOfDate(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IsDisplayDataOutOfDate();
        }
        public static Int32 GetConstrainedStatus(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.GetConstrainedStatus();
        }
        public static Boolean RemoveMaterialProperty(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.RemoveMaterialProperty();
        }
        public static Int32 IGetTemporaryBodyID(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.IGetTemporaryBodyID();
        }
        public static Object FindAttribute(IComponentObject IComponentinstance, Object AttributeDef, Int32 WhichOne)
        {
            return IComponentinstance.IComponentInstance.FindAttribute(AttributeDef, WhichOne);
        }
        public static IAttributeObject IFindAttribute(IComponentObject IComponentinstance, IAttributeDefObject AttributeDef, Int32 WhichOne)
        {
            return new IAttributeObject(IComponentinstance.IComponentInstance.IFindAttribute(AttributeDef.IAttributeDefInstance as AttributeDef, WhichOne));
        }
        public static Boolean Select(IComponentObject IComponentinstance, Boolean AppendFlag)
        {
            return IComponentinstance.IComponentInstance.Select(AppendFlag);
        }
        public static Boolean SelectByMark(IComponentObject IComponentinstance, Boolean AppendFlag, Int32 Mark)
        {
            return IComponentinstance.IComponentInstance.SelectByMark(AppendFlag, Mark);
        }
        public static Boolean DeSelect(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.DeSelect();
        }
        public static Object MaterialPropertyValues(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.MaterialPropertyValues;
        }
        public static object IMaterialPropertyValues(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.MaterialPropertyValues;
        }
        public static String Name(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.Name;
        }
        public static String ReferencedConfiguration(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.ReferencedConfiguration;
        }
        public static Int32 Visible(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.Visible;
        }
        public static String Name2(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.Name2;
        }
        public static Int32 Solving(IComponentObject IComponentinstance)
        {
            return IComponentinstance.IComponentInstance.Solving;
        }
    }
}
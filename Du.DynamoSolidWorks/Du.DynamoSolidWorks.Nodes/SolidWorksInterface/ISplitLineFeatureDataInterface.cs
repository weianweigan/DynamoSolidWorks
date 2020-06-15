using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISplitLineFeatureDataObject
    {
        public ISplitLineFeatureData ISplitLineFeatureDataInstance { get; set; }
        public ISplitLineFeatureDataObject(ISplitLineFeatureData ISplitLineFeatureDatainstance)
        {
            ISplitLineFeatureDataInstance = ISplitLineFeatureDatainstance;
        }
    }
    public static class ISplitLineFeatureDataInterface
    {
        public static Boolean AccessSelections(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetType(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.GetType();
        }
        public static Int32 GetFacesCount(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.GetFacesCount();
        }
        public static IFace2Object IGetFaces(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, Int32 Count)
        {
            return new IFace2Object(ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.IGetFaces(Count));
        }
        //public static void ISetFaces(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, Int32 Count, Face2&Object EntIn)
        //{
        //    return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.ISetFaces(Count, EntIn);
        //}
        public static Int32 GetContoursCount(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.GetContoursCount();
        }
        public static Object IGetContours(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, Int32 Count)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.IGetContours(Count);
        }
        //public static void ISetContours(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, Int32 Count, Object& Contours)
        //{
        //    return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.ISetContours(Count, Contours);
        //}
        public static Int32 GetSplitToolsCount(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.GetSplitToolsCount();
        }
        public static Object IGetSplitTools(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, Int32 Count)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.IGetSplitTools(Count);
        }
        //public static void ISetSplitTools(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, Int32 Count, Object& DispArr)
        //{
        //    return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.ISetSplitTools(Count, DispArr);
        //}
        public static Int32 GetSplitTargetsCount(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.GetSplitTargetsCount();
        }
        public static Object IGetSplitTargets(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, Int32 Count)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.IGetSplitTargets(Count);
        }
        //public static void ISetSplitTargets(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance, Int32 Count, Object& DispArr)
        //{
        //    return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.ISetSplitTargets(Count, DispArr);
        //}
        public static Object PullDirectionBase(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.PullDirectionBase;
        }
        public static Int32 PullDirectionType(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.PullDirectionType;
        }
        public static Boolean ReverseDirection(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.ReverseDirection;
        }
        public static Boolean SingleDirection(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.SingleDirection;
        }
        public static Object Faces(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.Faces;
        }
        public static ISketchObject Sketch(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return new ISketchObject(ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.Sketch);
        }
        public static Object Contours(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.Contours;
        }
        public static Double Angle(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.Angle;
        }
        public static Object SplitTools(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.SplitTools;
        }
        public static Boolean SplitAll(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.SplitAll;
        }
        public static Int32 SplitType(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.SplitType;
        }
        public static Object SplitTargets(ISplitLineFeatureDataObject ISplitLineFeatureDatainstance)
        {
            return ISplitLineFeatureDatainstance.ISplitLineFeatureDataInstance.SplitTargets;
        }
    }
}
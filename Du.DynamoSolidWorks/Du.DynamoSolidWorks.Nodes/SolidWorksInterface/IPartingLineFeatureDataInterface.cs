using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPartingLineFeatureDataObject
    {
        public IPartingLineFeatureData IPartingLineFeatureDataInstance { get; set; }
        public IPartingLineFeatureDataObject(IPartingLineFeatureData IPartingLineFeatureDatainstance)
        {
            IPartingLineFeatureDataInstance = IPartingLineFeatureDatainstance;
        }
    }
    public static class IPartingLineFeatureDataInterface
    {
        public static Boolean AccessSelections(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance.CastObj<ModelDoc2>(), Component.IComponent2Instance.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetPartingLinesCount(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.GetPartingLinesCount();
        }
        public static IEdgeObject IGetPartingLines(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Int32 Count)
        {
            return new IEdgeObject(IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.IGetPartingLines(Count));
        }
        //public static void ISetPartingLines(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Int32 Count, Edge&Object EntIn)
        //{
        //    return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.ISetPartingLines(Count, EntIn);
        //}
        public static Boolean DraftAnalysis(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Double Angle)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.DraftAnalysis(Angle);
        }
        public static Int32 GetFacesByTypeCount(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Int32 Type)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.GetFacesByTypeCount(Type);
        }
        public static Object GetFacesByType(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Int32 Type)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.GetFacesByType(Type);
        }
        public static IFace2Object IGetFacesByType(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Int32 Type, Int32 Count)
        {
            return new IFace2Object(IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.IGetFacesByType(Type, Count));
        }
        public static Int32 Status(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.Status();
        }
        //public static Object GetEntitiesToSplit(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Object& TypeArr)
        //{
        //    return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.GetEntitiesToSplit(TypeArr);
        //}
        public static void SetEntitiesToSplit(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Object PVar)
        {
            IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.SetEntitiesToSplit(PVar);
        }
        public static Int32 GetEntitiesToSplitCount(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.GetEntitiesToSplitCount();
        }
        //public static Object IGetEntitiesToSplit(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Int32 Count, Int32& TypeArr)
        //{
        //    return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.IGetEntitiesToSplit(Count, TypeArr);
        //}
        //public static void ISetEntitiesToSplit(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance, Int32 Count, Object& EntIn)
        //{
        //    return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.ISetEntitiesToSplit(Count, EntIn);
        //}
        public static Object PullDirectionBase(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.PullDirectionBase;
        }
        public static Int32 PullDirectionType(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.PullDirectionType;
        }
        public static Boolean PullDirection(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.PullDirection;
        }
        public static Object PartingLines(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.PartingLines;
        }
        public static Double Angle(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.Angle;
        }
        public static Boolean SplitFaces(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.SplitFaces;
        }
        public static Boolean CoreCavitySplit(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.CoreCavitySplit;
        }
        public static Int32 SplitFacesOption(IPartingLineFeatureDataObject IPartingLineFeatureDatainstance)
        {
            return IPartingLineFeatureDatainstance.IPartingLineFeatureDataInstance.SplitFacesOption;
        }
    }
}
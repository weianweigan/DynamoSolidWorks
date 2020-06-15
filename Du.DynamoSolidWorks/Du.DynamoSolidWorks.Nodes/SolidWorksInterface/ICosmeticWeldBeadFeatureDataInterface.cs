using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICosmeticWeldBeadFeatureDataObject
    {
        public ICosmeticWeldBeadFeatureData ICosmeticWeldBeadFeatureDataInstance { get; set; }
        public ICosmeticWeldBeadFeatureDataObject(ICosmeticWeldBeadFeatureData ICosmeticWeldBeadFeatureDatainstance)
        {
            ICosmeticWeldBeadFeatureDataInstance = ICosmeticWeldBeadFeatureDatainstance;
        }
    }
    public static class ICosmeticWeldBeadFeatureDataInterface
    {
        public static Boolean AccessSelections(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object GetWeldBeadFolder(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.GetWeldBeadFolder();
        }
        //public static Object GetEntities(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance, Int32& EntType)
        //{
        //    return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.GetEntities(EntType);
        //}
        public static void SetEntities(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance, Object Entities)
        {
            ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.SetEntities(Entities);
        }
        //public static Object GetEntitiesWeldFrom(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance, Int32& EntType)
        //{
        //    return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.GetEntitiesWeldFrom(EntType);
        //}
        public static void SetEntitiesWeldFrom(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance, Object Entities)
        {
            ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.SetEntitiesWeldFrom(Entities);
        }
        //public static Object GetEntitiesWeldTo(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance, Int32& EntType)
        //{
        //    return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.GetEntitiesWeldTo(EntType);
        //}
        public static void SetEntitiesWeldTo(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance, Object Entities)
        {
            ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.SetEntitiesWeldTo(Entities);
        }
        public static Object GetEntitiesWeldPath(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.GetEntitiesWeldPath();
        }
        public static void SetEntitiesWeldPath(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance, Object Entities)
        {
            ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.SetEntitiesWeldPath(Entities);
        }
        public static Object GetReferenceEdges(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.GetReferenceEdges();
        }
        public static Double BeadSize(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.BeadSize;
        }
        public static Boolean TangentPropagation(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.TangentPropagation;
        }
        public static Int32 Side(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.Side;
        }
        public static Object WeldSymbol(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.WeldSymbol;
        }
        public static Boolean FromToLength(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.FromToLength;
        }
        public static Double FromToStartPoint(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.FromToStartPoint;
        }
        public static Boolean FromToReverse(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.FromToReverse;
        }
        public static Double FromToWeldLength(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.FromToWeldLength;
        }
        public static Boolean IntermittentWeld(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.IntermittentWeld;
        }
        public static Boolean GapOrPitch(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.GapOrPitch;
        }
        public static Double IntermittentWeldLength(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.IntermittentWeldLength;
        }
        public static Double Gap(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.Gap;
        }
        public static Double Pitch(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.Pitch;
        }
        public static Boolean Staggered(ICosmeticWeldBeadFeatureDataObject ICosmeticWeldBeadFeatureDatainstance)
        {
            return ICosmeticWeldBeadFeatureDatainstance.ICosmeticWeldBeadFeatureDataInstance.Staggered;
        }
    }
}
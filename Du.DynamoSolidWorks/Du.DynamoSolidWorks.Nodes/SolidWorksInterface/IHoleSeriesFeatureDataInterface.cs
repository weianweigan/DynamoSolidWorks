using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IHoleSeriesFeatureDataObject
    {
        public IHoleSeriesFeatureData IHoleSeriesFeatureDataInstance { get; set; }
        public IHoleSeriesFeatureDataObject(IHoleSeriesFeatureData IHoleSeriesFeatureDatainstance)
        {
            IHoleSeriesFeatureDataInstance = IHoleSeriesFeatureDatainstance;
        }
    }
    public static class IHoleSeriesFeatureDataInterface
    {
        public static Boolean AccessSelections(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object GetHoleTopMateEntity(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, Int32 HoleInstance, Int16 HoleType)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.GetHoleTopMateEntity(HoleInstance, HoleType);
        }
        public static Object GetHoleBottomMateEntity(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, Int32 HoleInstance, Int16 HoleType)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.GetHoleBottomMateEntity(HoleInstance, HoleType);
        }
        public static IEntityObject IGetHoleTopMateEntity(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, Int32 HoleInstance, Int16 HoleType)
        {
            return new IEntityObject(IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.IGetHoleTopMateEntity(HoleInstance, HoleType));
        }
        public static IEntityObject IGetHoleBottomMateEntity(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, Int32 HoleInstance, Int16 HoleType)
        {
            return new IEntityObject(IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.IGetHoleBottomMateEntity(HoleInstance, HoleType));
        }
        public static Int32 GetSketchPointsCount(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.GetSketchPointsCount();
        }
        public static Object GetSketchPoints(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.GetSketchPoints();
        }
        public static ISketchPointObject IGetSketchPoints(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, Int32 NCount)
        {
            return new ISketchPointObject(IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.IGetSketchPoints(NCount));
        }
        public static Int32 GetComponentsCount(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.GetComponentsCount();
        }
        public static Object GetComponents(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.GetComponents();
        }
        public static IComponent2Object IGetComponents(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, Int32 NCount)
        {
            return new IComponent2Object(IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.IGetComponents(NCount));
        }
        public static String FastenerDefaultUnits(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.FastenerDefaultUnits;
        }
        public static Int16 FastenerTopHoleType(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.FastenerTopHoleType;
        }
        public static Int16 FastenerBottomHoleType(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.FastenerBottomHoleType;
        }
        public static Int32 FastenerHoleCount(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.FastenerHoleCount;
        }
        public static Int32 Standard(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.Standard;
        }
        public static Int32 Type(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, int HoleSeriesWhichPart)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.Type[HoleSeriesWhichPart];
        }
        public static String Size(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance, int HoleSeriesWhichPart)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.Size[HoleSeriesWhichPart];
        }
        public static String Material(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.Material;
        }
        public static Double BoltHeadDiameter(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.BoltHeadDiameter;
        }
        public static Double BoltDiameter(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.BoltDiameter;
        }
        public static String Preload(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.Preload;
        }
        public static Double NutDiameter(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.NutDiameter;
        }
        public static Object StartFace(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.StartFace;
        }
        public static Object EndFace(IHoleSeriesFeatureDataObject IHoleSeriesFeatureDatainstance)
        {
            return IHoleSeriesFeatureDatainstance.IHoleSeriesFeatureDataInstance.EndFace;
        }
    }
}
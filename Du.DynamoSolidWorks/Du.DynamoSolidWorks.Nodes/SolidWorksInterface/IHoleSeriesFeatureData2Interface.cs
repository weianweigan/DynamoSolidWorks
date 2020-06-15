using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IHoleSeriesFeatureData2Object
    {
        public IHoleSeriesFeatureData2 IHoleSeriesFeatureData2Instance { get; set; }
        public IHoleSeriesFeatureData2Object(IHoleSeriesFeatureData2 IHoleSeriesFeatureData2instance)
        {
            IHoleSeriesFeatureData2Instance = IHoleSeriesFeatureData2instance;
        }
    }
    public static class IHoleSeriesFeatureData2Interface
    {
        public static Boolean AccessSelections(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance, Object TopDoc, Object Component)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Object GetHoleTopMateEntity(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance, Int32 HoleInstance, Int16 HoleType)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.GetHoleTopMateEntity(HoleInstance, HoleType);
        }
        public static Object GetHoleBottomMateEntity(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance, Int32 HoleInstance, Int16 HoleType)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.GetHoleBottomMateEntity(HoleInstance, HoleType);
        }
        public static IEntityObject IGetHoleTopMateEntity(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance, Int32 HoleInstance, Int16 HoleType)
        {
            return new IEntityObject(IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.IGetHoleTopMateEntity(HoleInstance, HoleType));
        }
        public static IEntityObject IGetHoleBottomMateEntity(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance, Int32 HoleInstance, Int16 HoleType)
        {
            return new IEntityObject(IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.IGetHoleBottomMateEntity(HoleInstance, HoleType));
        }
        public static Int32 GetSketchPointsCount(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.GetSketchPointsCount();
        }
        public static Object GetSketchPoints(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.GetSketchPoints();
        }
        public static ISketchPointObject IGetSketchPoints(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance, Int32 NCount)
        {
            return new ISketchPointObject(IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.IGetSketchPoints(NCount));
        }
        public static Int32 GetComponentsCount(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.GetComponentsCount();
        }
        public static Object GetComponents(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.GetComponents();
        }
        public static IComponent2Object IGetComponents(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance, Int32 NCount)
        {
            return new IComponent2Object(IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.IGetComponents(NCount));
        }
        public static String FastenerDefaultUnits(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.FastenerDefaultUnits;
        }
        public static Int16 FastenerTopHoleType(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.FastenerTopHoleType;
        }
        public static Int16 FastenerBottomHoleType(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.FastenerBottomHoleType;
        }
        public static Int32 FastenerHoleCount(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.FastenerHoleCount;
        }
        public static Int32 Standard(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.Standard;
        }
        //public static Int32 Type(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        //    {
        //          return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.Type;
        //    }
        //public static String Size(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        //    {
        //          return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.Size;
        //    }
        public static String Material(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.Material;
        }
        public static Double BoltHeadDiameter(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.BoltHeadDiameter;
        }
        public static Double BoltDiameter(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.BoltDiameter;
        }
        public static String Preload(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.Preload;
        }
        public static Double NutDiameter(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.NutDiameter;
        }
        public static Object StartFace(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.StartFace;
        }
        public static Object EndFace(IHoleSeriesFeatureData2Object IHoleSeriesFeatureData2instance)
        {
            return IHoleSeriesFeatureData2instance.IHoleSeriesFeatureData2Instance.EndFace;
        }
    }
}
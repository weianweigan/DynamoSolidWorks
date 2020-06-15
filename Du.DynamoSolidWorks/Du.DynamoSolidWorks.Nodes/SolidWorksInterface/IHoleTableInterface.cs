using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IHoleTableObject
    {
        public IHoleTable IHoleTableInstance { get; set; }
        public IHoleTableObject(IHoleTable IHoleTableinstance)
        {
            IHoleTableInstance = IHoleTableinstance;
        }
    }
    public static class IHoleTableInterface
    {
        public static IFeatureObject GetFeature(IHoleTableObject IHoleTableinstance)
        {
            return new IFeatureObject(IHoleTableinstance.IHoleTableInstance.GetFeature());
        }
        public static Int32 GetTableAnnotationCount(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.GetTableAnnotations();
        }
        public static IHoleTableAnnotationObject IGetTableAnnotations(IHoleTableObject IHoleTableinstance, Int32 Count)
        {
            return new IHoleTableAnnotationObject(IHoleTableinstance.IHoleTableInstance.IGetTableAnnotations(Count));
        }
        public static Int32 AddHole(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.AddHole();
        }
        public static Boolean GetHoleLocationUseDocPrecision(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.GetHoleLocationUseDocPrecision();
        }
        public static Int32 GetHoleLocationPrecision(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.GetHoleLocationPrecision();
        }
        public static Boolean SetHoleLocationPrecision(IHoleTableObject IHoleTableinstance, Boolean UseDoc, Int32 Precision)
        {
            return IHoleTableinstance.IHoleTableInstance.SetHoleLocationPrecision(UseDoc, Precision);
        }
        public static IDatumOriginObject DatumOrigin(IHoleTableObject IHoleTableinstance)
        {
            return new IDatumOriginObject(IHoleTableinstance.IHoleTableInstance.DatumOrigin);
        }
        public static Boolean HoleCentersVisible(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.HoleCentersVisible;
        }
        public static Boolean CombineTags(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.CombineTags;
        }
        public static Boolean CombineSameSize(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.CombineSameSize;
        }
        public static Int32 TagStyle(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.TagStyle;
        }
        public static Boolean HoleTagsVisible(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.HoleTagsVisible;
        }
        public static String HoleTag(IHoleTableObject IHoleTableinstance, int Row)
        {
            return IHoleTableinstance.IHoleTableInstance.HoleTag[Row];
        }
        public static Boolean EnableUpdate(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.EnableUpdate;
        }
        public static String StartingValue(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.StartingValue;
        }
        public static Boolean ShowANSIInchLetterNumberDrillSizes(IHoleTableObject IHoleTableinstance)
        {
            return IHoleTableinstance.IHoleTableInstance.ShowANSIInchLetterNumberDrillSizes;
        }
    }
}
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAdvancedHoleElementDataObject
    {
        public IAdvancedHoleElementData IAdvancedHoleElementDataInstance { get; set; }
        public IAdvancedHoleElementDataObject(IAdvancedHoleElementData IAdvancedHoleElementDatainstance)
        {
            IAdvancedHoleElementDataInstance = IAdvancedHoleElementDatainstance;
        }
    }
    public static class IAdvancedHoleElementDataInterface
    {
        public static Int32 Orientation(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.Orientation;
        }
        public static Int32 Standard(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.Standard;
        }
        public static Int32 FastenerType(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.FastenerType;
        }
        public static String Size(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.Size;
        }
        public static Double Diameter(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.Diameter;
        }
        public static Boolean DiameterOverride(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.DiameterOverride;
        }
        public static Int32 EndCondition(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.EndCondition;
        }
        public static Double BlindDepth(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.BlindDepth;
        }
        public static Double OffsetDistance(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.OffsetDistance;
        }
        public static Boolean OffsetReverseDirection(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.OffsetReverseDirection;
        }
        public static Object SelectionEntity(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.SelectionEntity;
        }
        public static Int32 ElementType(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.ElementType;
        }
        public static String CalloutString(IAdvancedHoleElementDataObject IAdvancedHoleElementDatainstance)
        {
            return IAdvancedHoleElementDatainstance.IAdvancedHoleElementDataInstance.CalloutString;
        }
    }
}
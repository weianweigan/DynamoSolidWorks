using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IConnectionPointFeatureDataObject
    {
        public IConnectionPointFeatureData IConnectionPointFeatureDataInstance { get; set; }
        public IConnectionPointFeatureDataObject(IConnectionPointFeatureData IConnectionPointFeatureDatainstance)
        {
            IConnectionPointFeatureDataInstance = IConnectionPointFeatureDatainstance;
        }
    }
    public static class IConnectionPointFeatureDataInterface
    {
        public static Boolean AccessSelections(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Double RouteDiameter(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.RouteDiameter;
        }
        public static Double StubLength(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.StubLength;
        }
        public static Object Location(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.Location;
        }
        public static Int32 RouteType(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.RouteType;
        }
        public static Int32 RouteSubType(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.RouteSubType;
        }
        public static String ElectricalPinID(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.ElectricalPinID;
        }
        public static String Name2(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.Name2;
        }
        public static String PortID(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.PortID;
        }
        public static Object Direction(IConnectionPointFeatureDataObject IConnectionPointFeatureDatainstance)
        {
            return IConnectionPointFeatureDatainstance.IConnectionPointFeatureDataInstance.Direction;
        }
    }
}
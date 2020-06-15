using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IEdgePointObject
    {
        public IEdgePoint IEdgePointInstance { get; set; }
        public IEdgePointObject(IEdgePoint IEdgePointinstance)
        {
            IEdgePointInstance = IEdgePointinstance;
        }
    }
    public static class IEdgePointInterface
    {
        public static Boolean Select(IEdgePointObject IEdgePointinstance, Boolean BAppend, Int32 SelMark)
        {
            return IEdgePointinstance.IEdgePointInstance.Select(BAppend, SelMark);
        }
        public static void GetPointCoordinates(IEdgePointObject IEdgePointinstance, out double X, out double Y, out double Z)
        {
            IEdgePointinstance.IEdgePointInstance.GetPointCoordinates(out X, out Y, out Z);
        }
        public static Double Position(IEdgePointObject IEdgePointinstance)
        {
            return IEdgePointinstance.IEdgePointInstance.Position;
        }
        public static Object Entity(IEdgePointObject IEdgePointinstance)
        {
            return IEdgePointinstance.IEdgePointInstance.Entity;
        }
    }
}
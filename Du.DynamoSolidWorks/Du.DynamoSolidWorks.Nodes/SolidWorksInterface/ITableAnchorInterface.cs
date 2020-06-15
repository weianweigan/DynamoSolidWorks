using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITableAnchorObject
    {
        public ITableAnchor ITableAnchorInstance { get; set; }
        public ITableAnchorObject(ITableAnchor ITableAnchorinstance)
        {
            ITableAnchorInstance = ITableAnchorinstance;
        }
    }
    public static class ITableAnchorInterface
    {
        public static IFeatureObject GetFeature(ITableAnchorObject ITableAnchorinstance)
        {
            return new IFeatureObject(ITableAnchorinstance.ITableAnchorInstance.GetFeature());
        }
        public static Double IGetPosition(ITableAnchorObject ITableAnchorinstance)
        {
            return ITableAnchorinstance.ITableAnchorInstance.IGetPosition();
        }
        //public static void ISetPosition(ITableAnchorObject ITableAnchorinstance, Double& Position)
        //{
        //    return ITableAnchorinstance.ITableAnchorInstance.ISetPosition(Position);
        //}
        public static Int32 Type(ITableAnchorObject ITableAnchorinstance)
        {
            return ITableAnchorinstance.ITableAnchorInstance.Type;
        }
        public static Object Position(ITableAnchorObject ITableAnchorinstance)
        {
            return ITableAnchorinstance.ITableAnchorInstance.Position;
        }
    }
}
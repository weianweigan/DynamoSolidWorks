using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDatumOriginObject
    {
        public IDatumOrigin IDatumOriginInstance { get; set; }
        public IDatumOriginObject(IDatumOrigin IDatumOrigininstance)
        {
            IDatumOriginInstance = IDatumOrigininstance;
        }
    }
    public static class IDatumOriginInterface
    {
        public static IDatumOriginObject GetNext(IDatumOriginObject IDatumOrigininstance)
        {
            return new IDatumOriginObject(IDatumOrigininstance.IDatumOriginInstance.GetNext());
        }
        public static IAnnotationObject GetAnnotation(IDatumOriginObject IDatumOrigininstance)
        {
            return new IAnnotationObject(IDatumOrigininstance.IDatumOriginInstance.GetAnnotation());
        }
        public static Boolean Reattach(IDatumOriginObject IDatumOrigininstance)
        {
            return IDatumOrigininstance.IDatumOriginInstance.Reattach();
        }
        public static Object GetAxisPoints(IDatumOriginObject IDatumOrigininstance)
        {
            return IDatumOrigininstance.IDatumOriginInstance.GetAxisPoints();
        }
        public static Double IGetAxisPoints(IDatumOriginObject IDatumOrigininstance)
        {
            return IDatumOrigininstance.IDatumOriginInstance.IGetAxisPoints();
        }
        public static Boolean SetAxisPoints(IDatumOriginObject IDatumOrigininstance, Object PointData)
        {
            return IDatumOrigininstance.IDatumOriginInstance.SetAxisPoints(PointData);
        }
        //public static Boolean ISetAxisPoints(IDatumOriginObject IDatumOrigininstance, Double& PointData)
        //{
        //    return IDatumOrigininstance.IDatumOriginInstance.ISetAxisPoints(PointData);
        //}
        public static Object GetAxisPoints2(IDatumOriginObject IDatumOrigininstance)
        {
            return IDatumOrigininstance.IDatumOriginInstance.GetAxisPoints2();
        }
        public static Double IGetAxisPoints2(IDatumOriginObject IDatumOrigininstance)
        {
            return IDatumOrigininstance.IDatumOriginInstance.IGetAxisPoints2();
        }
        public static String XLabel(IDatumOriginObject IDatumOrigininstance)
        {
            return IDatumOrigininstance.IDatumOriginInstance.XLabel;
        }
        public static String YLabel(IDatumOriginObject IDatumOrigininstance)
        {
            return IDatumOrigininstance.IDatumOriginInstance.YLabel;
        }
        public static IHoleTableObject Table(IDatumOriginObject IDatumOrigininstance)
        {
            return new IHoleTableObject(IDatumOrigininstance.IDatumOriginInstance.Table);
        }
    }
}
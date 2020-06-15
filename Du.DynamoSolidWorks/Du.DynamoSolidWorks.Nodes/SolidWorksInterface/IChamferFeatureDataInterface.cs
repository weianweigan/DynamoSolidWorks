using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IChamferFeatureDataObject
    {
        public IChamferFeatureData IChamferFeatureDataInstance { get; set; }
        public IChamferFeatureDataObject(IChamferFeatureData IChamferFeatureDatainstance)
        {
            IChamferFeatureDataInstance = IChamferFeatureDatainstance;
        }
    }
    public static class IChamferFeatureDataInterface
    {
        public static Double GetEdgeChamferDistance(IChamferFeatureDataObject IChamferFeatureDatainstance, Int32 Side)
        {
            return IChamferFeatureDatainstance.IChamferFeatureDataInstance.GetEdgeChamferDistance(Side);
        }
        public static void SetEdgeChamferDistance(IChamferFeatureDataObject IChamferFeatureDatainstance, Int32 Side, Double Distance)
        {
            IChamferFeatureDatainstance.IChamferFeatureDataInstance.SetEdgeChamferDistance(Side, Distance);
        }
        public static Double GetVertexChamferDistance(IChamferFeatureDataObject IChamferFeatureDatainstance, Int32 Side)
        {
            return IChamferFeatureDatainstance.IChamferFeatureDataInstance.GetVertexChamferDistance(Side);
        }
        public static void SetVertexChamferDistance(IChamferFeatureDataObject IChamferFeatureDatainstance, Int32 Side, Double Distance)
        {
            IChamferFeatureDatainstance.IChamferFeatureDataInstance.SetVertexChamferDistance(Side, Distance);
        }
        public static Int32 Type(IChamferFeatureDataObject IChamferFeatureDatainstance)
        {
            return IChamferFeatureDatainstance.IChamferFeatureDataInstance.Type;
        }
        public static Double EdgeChamferAngle(IChamferFeatureDataObject IChamferFeatureDatainstance)
        {
            return IChamferFeatureDatainstance.IChamferFeatureDataInstance.EdgeChamferAngle;
        }
    }
}
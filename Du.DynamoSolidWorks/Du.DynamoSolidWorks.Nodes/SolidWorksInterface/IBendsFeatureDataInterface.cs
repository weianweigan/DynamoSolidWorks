using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBendsFeatureDataObject
    {
        public IBendsFeatureData IBendsFeatureDataInstance { get; set; }
        public IBendsFeatureDataObject(IBendsFeatureData IBendsFeatureDatainstance)
        {
            IBendsFeatureDataInstance = IBendsFeatureDatainstance;
        }
    }
    public static class IBendsFeatureDataInterface
    {
        public static Boolean AccessSelections(IBendsFeatureDataObject IBendsFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IBendsFeatureDataObject IBendsFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            IBendsFeatureDatainstance.IBendsFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean IAccessSelections2(IBendsFeatureDataObject IBendsFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static ICustomBendAllowanceObject GetCustomBendAllowance(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return new ICustomBendAllowanceObject(IBendsFeatureDatainstance.IBendsFeatureDataInstance.GetCustomBendAllowance());
        }
        public static void SetCustomBendAllowance(IBendsFeatureDataObject IBendsFeatureDatainstance, ICustomBendAllowanceObject PBendData)
        {
            IBendsFeatureDatainstance.IBendsFeatureDataInstance.SetCustomBendAllowance(PBendData?.ICustomBendAllowanceInstance?.CastObj<CustomBendAllowance>());
        }
        public static Object GetFixedFace(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.GetFixedFace();
        }
        public static Double BendRadius(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.BendRadius;
        }
        public static Int32 BendAllowanceType(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.BendAllowanceType;
        }
        public static String BendTableFile(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.BendTableFile;
        }
        public static Double KFactor(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.KFactor;
        }
        public static Double BendAllowance(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.BendAllowance;
        }
        public static Boolean UseDefaultBendRadius(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.UseDefaultBendRadius;
        }
        public static Boolean UseDefaultBendAllowance(IBendsFeatureDataObject IBendsFeatureDatainstance)
        {
            return IBendsFeatureDatainstance.IBendsFeatureDataInstance.UseDefaultBendAllowance;
        }
    }
}
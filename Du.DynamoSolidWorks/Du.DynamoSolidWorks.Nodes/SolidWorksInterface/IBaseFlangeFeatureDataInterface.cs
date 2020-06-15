using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBaseFlangeFeatureDataObject
    {
        public IBaseFlangeFeatureData IBaseFlangeFeatureDataInstance { get; set; }
        public IBaseFlangeFeatureDataObject(IBaseFlangeFeatureData IBaseFlangeFeatureDatainstance)
        {
            IBaseFlangeFeatureDataInstance = IBaseFlangeFeatureDatainstance;
        }
    }
    public static class IBaseFlangeFeatureDataInterface
    {
        public static Boolean AccessSelections(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetD1OffsetReferenceType(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.GetD1OffsetReferenceType();
        }
        public static Int32 GetD2OffsetReferenceType(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.GetD2OffsetReferenceType();
        }
        public static Boolean IAccessSelections2(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static Int32 GetTableThicknessesCount(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.GetTableThicknessesCount();
        }
        public static Object GetTableThicknesses(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.GetTableThicknesses();
        }
        public static String IGetTableThicknesses(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance, Int32 NCount)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.IGetTableThicknesses(NCount);
        }
        public static Int32 GetTableRadiiCount(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance, String ThicknessTableName)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.GetTableRadiiCount(ThicknessTableName);
        }
        public static Object GetTableRadii(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance, String ThicknessTableName)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.GetTableRadii(ThicknessTableName);
        }
        public static Double IGetTableRadii(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance, String ThicknessTableName, Int32 NCount)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.IGetTableRadii(ThicknessTableName, NCount);
        }
        public static Int32 OffsetDirections(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.OffsetDirections;
        }
        public static Int32 D1OffsetType(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.D1OffsetType;
        }
        public static Int32 D2OffsetType(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.D2OffsetType;
        }
        public static Object D1OffsetReference(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.D1OffsetReference;
        }
        public static Object D2OffsetReference(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.D2OffsetReference;
        }
        public static Double D1OffsetDistance(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.D1OffsetDistance;
        }
        public static Double D2OffsetDistance(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.D2OffsetDistance;
        }
        public static Double Thickness(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.Thickness;
        }
        public static Boolean ReverseThickness(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.ReverseThickness;
        }
        public static Double BendRadius(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.BendRadius;
        }
        public static Boolean ReverseDirection(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.ReverseDirection;
        }
        public static Boolean D1ReverseOffset(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.D1ReverseOffset;
        }
        public static Boolean D2ReverseOffset(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.D2ReverseOffset;
        }
        public static Boolean UseGaugeTable(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.UseGaugeTable;
        }
        public static String GaugeTablePath(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.GaugeTablePath;
        }
        public static String ThicknessTableName(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.ThicknessTableName;
        }
        public static Double TableThickness(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.TableThickness;
        }
        public static Boolean OverrideThickness(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.OverrideThickness;
        }
        public static Double TableRadius(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.TableRadius;
        }
        public static Boolean OverrideRadius(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.OverrideRadius;
        }
        public static Double KFactor(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.KFactor;
        }
        public static Boolean OverrideKFactor(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.OverrideKFactor;
        }
        public static Double TableKFactor(IBaseFlangeFeatureDataObject IBaseFlangeFeatureDatainstance)
        {
            return IBaseFlangeFeatureDatainstance.IBaseFlangeFeatureDataInstance.TableKFactor;
        }
    }
}
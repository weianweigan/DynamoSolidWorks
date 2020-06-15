using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRevolveFeatureData2Object
    {
        public IRevolveFeatureData2 IRevolveFeatureData2Instance { get; set; }
        public IRevolveFeatureData2Object(IRevolveFeatureData2 IRevolveFeatureData2instance)
        {
            IRevolveFeatureData2Instance = IRevolveFeatureData2instance;
        }
    }
    public static class IRevolveFeatureData2Interface
    {
        public static Double GetRevolutionAngle(IRevolveFeatureData2Object IRevolveFeatureData2instance, Boolean Forward)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.GetRevolutionAngle(Forward);
        }
        public static void SetRevolutionAngle(IRevolveFeatureData2Object IRevolveFeatureData2instance, Boolean Forward, Double Angle)
        {
            IRevolveFeatureData2instance.IRevolveFeatureData2Instance.SetRevolutionAngle(Forward, Angle);
        }
        public static Double GetWallThickness(IRevolveFeatureData2Object IRevolveFeatureData2instance, Boolean Forward)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.GetWallThickness(Forward);
        }
        public static void SetWallThickness(IRevolveFeatureData2Object IRevolveFeatureData2instance, Boolean Forward, Double WallThickness)
        {
            IRevolveFeatureData2instance.IRevolveFeatureData2Instance.SetWallThickness(Forward, WallThickness);
        }
        public static Boolean IsBossFeature(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.IsBossFeature();
        }
        public static Boolean IsThinFeature(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.IsThinFeature();
        }
        public static Int32 GetFeatureScopeBodiesCount(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.GetFeatureScopeBodiesCount();
        }
        public static IBody2Object IGetFeatureScopeBodies(IRevolveFeatureData2Object IRevolveFeatureData2instance, Int32 Count)
        {
            return new IBody2Object(IRevolveFeatureData2instance.IRevolveFeatureData2Instance.IGetFeatureScopeBodies(Count));
        }
        //public static void ISetFeatureScopeBodies(IRevolveFeatureData2Object IRevolveFeatureData2instance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.ISetFeatureScopeBodies(Count, BodyArr);
        //}
        public static Boolean AccessSelections(IRevolveFeatureData2Object IRevolveFeatureData2instance, Object TopDoc, Object Component)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IRevolveFeatureData2Object IRevolveFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            IRevolveFeatureData2instance.IRevolveFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Int32 GetContoursCount(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.GetContoursCount();
        }
        public static Object IGetContours(IRevolveFeatureData2Object IRevolveFeatureData2instance, Int32 Count)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.IGetContours(Count);
        }
        //public static void ISetContours(IRevolveFeatureData2Object IRevolveFeatureData2instance, Int32 Count, Object& Contours)
        //{
        //    return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.ISetContours(Count, Contours);
        //}
        public static Int32 GetAxisType(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.GetAxisType();
        }
        public static Int32 Type(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.Type;
        }
        public static Boolean ReverseDirection(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.ReverseDirection;
        }
        public static Int32 ThinWallType(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.ThinWallType;
        }
        public static Boolean Merge(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.Merge;
        }
        public static Boolean FeatureScope(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.FeatureScope;
        }
        public static Boolean AutoSelect(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.AutoSelect;
        }
        public static Object FeatureScopeBodies(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.FeatureScopeBodies;
        }
        public static Object Contours(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.Contours;
        }
        public static Object Axis(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.Axis;
        }
        public static Boolean AssemblyFeatureScope(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.AssemblyFeatureScope;
        }
        public static Boolean AutoSelectComponents(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.AutoSelectComponents;
        }
        public static Boolean PropagateFeatureToParts(IRevolveFeatureData2Object IRevolveFeatureData2instance)
        {
            return IRevolveFeatureData2instance.IRevolveFeatureData2Instance.PropagateFeatureToParts;
        }
    }
}
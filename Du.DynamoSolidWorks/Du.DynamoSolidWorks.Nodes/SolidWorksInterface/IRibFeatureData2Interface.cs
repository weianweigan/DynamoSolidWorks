using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRibFeatureData2Object
    {
        public IRibFeatureData2 IRibFeatureData2Instance { get; set; }
        public IRibFeatureData2Object(IRibFeatureData2 IRibFeatureData2instance)
        {
            IRibFeatureData2Instance = IRibFeatureData2instance;
        }
    }
    public static class IRibFeatureData2Interface
    {
        public static Int32 NextReference(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.NextReference();
        }
        public static Boolean AccessSelections(IRibFeatureData2Object IRibFeatureData2instance, Object TopDoc, Object Component)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IRibFeatureData2Object IRibFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IRibFeatureData2Object IRibFeatureData2instance)
        {
            IRibFeatureData2instance.IRibFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Boolean IsTwoSided(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.IsTwoSided;
        }
        public static Boolean ReverseThicknessDir(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.ReverseThicknessDir;
        }
        public static Double Thickness(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.Thickness;
        }
        public static Int32 RefSketchIndex(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.RefSketchIndex;
        }
        public static Boolean FlipSide(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.FlipSide;
        }
        public static Boolean EnableDraft(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.EnableDraft;
        }
        public static Boolean DraftOutward(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.DraftOutward;
        }
        public static Double DraftAngle(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.DraftAngle;
        }
        public static Int32 ExtrusionDirection(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.ExtrusionDirection;
        }
        public static Int32 Type(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.Type;
        }
        public static IBody2Object Body(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return new IBody2Object(IRibFeatureData2instance.IRibFeatureData2Instance.Body);
        }
        public static Boolean DraftFromWall(IRibFeatureData2Object IRibFeatureData2instance)
        {
            return IRibFeatureData2instance.IRibFeatureData2Instance.DraftFromWall;
        }
    }
}
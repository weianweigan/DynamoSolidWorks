using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISimpleHoleFeatureData2Object
    {
        public ISimpleHoleFeatureData2 ISimpleHoleFeatureData2Instance { get; set; }
        public ISimpleHoleFeatureData2Object(ISimpleHoleFeatureData2 ISimpleHoleFeatureData2instance)
        {
            ISimpleHoleFeatureData2Instance = ISimpleHoleFeatureData2instance;
        }
    }
    public static class ISimpleHoleFeatureData2Interface
    {
        public static Boolean AccessSelections(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance, Object TopDoc, Object Component)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.ReleaseSelectionAccess();
        }
        //public static Object GetEndConditionReference(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance, Int32& ReferenceType)
        //{
        //    return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.GetEndConditionReference(ReferenceType);
        //}
        public static void SetEndConditionReference(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance, Object PDisp)
        {
            ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.SetEndConditionReference(PDisp);
        }
        public static Int32 GetFeatureScopeBodiesCount(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.GetFeatureScopeBodiesCount();
        }
        public static IBody2Object IGetFeatureScopeBodies(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance, Int32 Count)
        {
            return new IBody2Object(ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.IGetFeatureScopeBodies(Count));
        }
        //public static void ISetFeatureScopeBodies(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.ISetFeatureScopeBodies(Count, BodyArr);
        //}
        //public static Int32 GetDirectionReference(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance, Object& Ref1, Int32& Type1, Object& Ref2, Int32& Type2)
        //{
        //    return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.GetDirectionReference(Ref1, Type1, Ref2, Type2);
        //}
        public static Boolean SetDirectionReference(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance, Object Ref1, Object Ref2)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.SetDirectionReference(Ref1, Ref2);
        }
        public static Boolean ReverseDirection(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.ReverseDirection;
        }
        public static Boolean DraftWhileExtruding(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.DraftWhileExtruding;
        }
        public static Boolean DraftOutward(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.DraftOutward;
        }
        public static Boolean ReverseOffset(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.ReverseOffset;
        }
        public static Int32 Type(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.Type;
        }
        public static Double Diameter(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.Diameter;
        }
        public static Double Depth(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.Depth;
        }
        public static Double DraftAngle(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.DraftAngle;
        }
        public static Double SurfaceOffset(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.SurfaceOffset;
        }
        public static Object Face(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.Face;
        }
        public static IFace2Object IFace(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return new IFace2Object(ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.IFace);
        }
        public static Object Vertex(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.Vertex;
        }
        public static IVertexObject IVertex(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return new IVertexObject(ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.IVertex);
        }
        public static Boolean FeatureScope(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.FeatureScope;
        }
        public static Boolean AutoSelect(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.AutoSelect;
        }
        public static Object FeatureScopeBodies(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.FeatureScopeBodies;
        }
        public static Boolean TranslateSurface(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.TranslateSurface;
        }
        public static Boolean AssemblyFeatureScope(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.AssemblyFeatureScope;
        }
        public static Boolean AutoSelectComponents(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.AutoSelectComponents;
        }
        public static Boolean PropagateFeatureToParts(ISimpleHoleFeatureData2Object ISimpleHoleFeatureData2instance)
        {
            return ISimpleHoleFeatureData2instance.ISimpleHoleFeatureData2Instance.PropagateFeatureToParts;
        }
    }
}
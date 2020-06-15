using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchBlockInstanceObject
    {
        public ISketchBlockInstance ISketchBlockInstanceInstance { get; set; }
        public ISketchBlockInstanceObject(ISketchBlockInstance ISketchBlockInstanceinstance)
        {
            ISketchBlockInstanceInstance = ISketchBlockInstanceinstance;
        }
    }
    public static class ISketchBlockInstanceInterface
    {
        public static Boolean Select(ISketchBlockInstanceObject ISketchBlockInstanceinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.Select(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
        public static ISketchObject GetSketch(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return new ISketchObject(ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.GetSketch());
        }
        public static Int32 GetLeaderStyle(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.GetLeaderStyle();
        }
        public static Int32 GetArrowHeadStyle(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.GetArrowHeadStyle();
        }
        public static Boolean SetLeader(ISketchBlockInstanceObject ISketchBlockInstanceinstance, Int32 LeaderStyle, Int32 ArrowHeadStyle)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.SetLeader(LeaderStyle, ArrowHeadStyle);
        }
        public static Int32 GetAttributeCount(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.GetAttributeCount();
        }
        public static Object GetAttributes(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.GetAttributes();
        }
        public static INoteObject IGetAttributes(ISketchBlockInstanceObject ISketchBlockInstanceinstance, Int32 Count)
        {
            return new INoteObject(ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.IGetAttributes(Count));
        }
        public static String GetAttributeValue(ISketchBlockInstanceObject ISketchBlockInstanceinstance, String TagName)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.GetAttributeValue(TagName);
        }
        public static Boolean SetAttributeValue(ISketchBlockInstanceObject ISketchBlockInstanceinstance, String TagName, String Value)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.SetAttributeValue(TagName, Value);
        }
        public static Object GetLeaderPoints(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.GetLeaderPoints();
        }
        public static Double IGetLeaderPoints(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.IGetLeaderPoints();
        }
        //public static Boolean GetAttachedEntities(ISketchBlockInstanceObject ISketchBlockInstanceinstance, Object& Entities, Object& EntityTypes)
        //{
        //    return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.GetAttachedEntities(Entities, EntityTypes);
        //}
        public static ISketchBlockDefinitionObject Definition(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return new ISketchBlockDefinitionObject(ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.Definition);
        }
        public static IMathPointObject InstancePosition(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return new IMathPointObject(ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.InstancePosition);
        }
        public static String Name(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.Name;
        }
        public static Double Angle(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.Angle;
        }
        public static Double Scale(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.Scale;
        }
        public static IMathTransformObject BlockToSketchTransform(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return new IMathTransformObject(ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.BlockToSketchTransform);
        }
        public static Int32 TextDisplay(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.TextDisplay;
        }
        public static Boolean DimensionDisplay(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.DimensionDisplay;
        }
        public static String Layer(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.Layer;
        }
        public static Boolean LockAngle(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.LockAngle;
        }
        public static Double Scale2(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.Scale2;
        }
        public static Int32 Visible(ISketchBlockInstanceObject ISketchBlockInstanceinstance)
        {
            return ISketchBlockInstanceinstance.ISketchBlockInstanceInstance.Visible;
        }
    }
}
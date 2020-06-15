using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IEntityObject
    {
        public IEntity IEntityInstance { get; set; }
        public IEntityObject(IEntity IEntityinstance)
        {
            IEntityInstance = IEntityinstance;
        }
    }
    public static class IEntityInterface
    {
        public static Int32 CreateStringAttributeDefinition(IEntityObject IEntityinstance, String IdentifierString)
        {
            return IEntityinstance.IEntityInstance.CreateStringAttributeDefinition(IdentifierString);
        }
        public static Boolean CreateStringAttribute(IEntityObject IEntityinstance, Int32 DefinitionTag, String StringValue)
        {
            return IEntityinstance.IEntityInstance.CreateStringAttribute(DefinitionTag, StringValue);
        }
        public static String FindStringAttribute(IEntityObject IEntityinstance, Int32 DefinitionTag)
        {
            return IEntityinstance.IEntityInstance.FindStringAttribute(DefinitionTag);
        }
        public static Boolean RemoveStringAttribute(IEntityObject IEntityinstance, Int32 DefinitionTag)
        {
            return IEntityinstance.IEntityInstance.RemoveStringAttribute(DefinitionTag);
        }
        public static Object FindAttribute(IEntityObject IEntityinstance, Object AttributeDef, Int32 WhichOne)
        {
            return IEntityinstance.IEntityInstance.FindAttribute(AttributeDef, WhichOne);
        }
        public static IAttributeObject IFindAttribute(IEntityObject IEntityinstance, IAttributeDefObject AttributeDef, Int32 WhichOne)
        {
            return new IAttributeObject(IEntityinstance.IEntityInstance.IFindAttribute(AttributeDef.IAttributeDefInstance as AttributeDef, WhichOne));
        }
        public static Boolean Select(IEntityObject IEntityinstance, Boolean AppendFlag)
        {
            return IEntityinstance.IEntityInstance.Select(AppendFlag);
        }
        public static Int32 GetType(IEntityObject IEntityinstance)
        {
            return IEntityinstance.IEntityInstance.GetType();
        }
        public static Object GetComponent(IEntityObject IEntityinstance)
        {
            return IEntityinstance.IEntityInstance.GetComponent();
        }
        public static IComponentObject IGetComponent(IEntityObject IEntityinstance)
        {
            return new IComponentObject(IEntityinstance.IEntityInstance.IGetComponent());
        }
        public static Boolean SelectByMark(IEntityObject IEntityinstance, Boolean AppendFlag, Int32 Mark)
        {
            return IEntityinstance.IEntityInstance.SelectByMark(AppendFlag, Mark);
        }
        public static void DeleteModelName(IEntityObject IEntityinstance)
        {
            IEntityinstance.IEntityInstance.DeleteModelName();
        }
        public static Boolean DeSelect(IEntityObject IEntityinstance)
        {
            return IEntityinstance.IEntityInstance.DeSelect();
        }
        public static IComponent2Object IGetComponent2(IEntityObject IEntityinstance)
        {
            return new IComponent2Object(IEntityinstance.IEntityInstance.IGetComponent2());
        }
        public static Boolean Select2(IEntityObject IEntityinstance, Boolean Append, Int32 Mark)
        {
            return IEntityinstance.IEntityInstance.Select2(Append, Mark);
        }
        public static Boolean Select3(IEntityObject IEntityinstance, Boolean Append, Int32 Mark, ICalloutObject Callout)
        {
            return IEntityinstance.IEntityInstance.Select3(Append, Mark, Callout.ICalloutInstance as Callout);
        }
        public static IEntityObject GetSafeEntity(IEntityObject IEntityinstance)
        {
            return new IEntityObject(IEntityinstance.IEntityInstance.GetSafeEntity());
        }
        public static Boolean Select4(IEntityObject IEntityinstance, Boolean Append, ISelectDataObject Data)
        {
            return IEntityinstance.IEntityInstance.Select4(Append, Data.ISelectDataInstance as SelectData);
        }
        public static IDrawingComponentObject GetDrawingComponent(IEntityObject IEntityinstance, IViewObject View)
        {
            return new IDrawingComponentObject(IEntityinstance.IEntityInstance.GetDrawingComponent(View.IViewInstance as View));
        }
        //public static Int32 GetDistance(IEntityObject IEntityinstance, Object BaseEntity, Boolean MinDistance, Object Parameter, Object& Position1, Object& Position2, Double& Distance)
        //{
        //    return IEntityinstance.IEntityInstance.GetDistance(BaseEntity, MinDistance, Parameter, Position1, Position2, Distance);
        //}
        //public static Int32 IGetDistance(IEntityObject IEntityinstance, EntityObject BaseEntity, Boolean MinDistance, Double& Parameter, Double& Position1, Double& Position2, Double& Distance)
        //{
        //    return IEntityinstance.IEntityInstance.IGetDistance(BaseEntity, MinDistance, Parameter, Position1, Position2, Distance);
        //}
        public static String ModelName(IEntityObject IEntityinstance)
        {
            return IEntityinstance.IEntityInstance.ModelName;
        }
        public static Boolean IsSafe(IEntityObject IEntityinstance)
        {
            return IEntityinstance.IEntityInstance.IsSafe;
        }
    }
}
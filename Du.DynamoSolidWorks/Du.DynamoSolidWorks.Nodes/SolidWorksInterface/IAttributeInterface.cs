using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAttributeObject
    {
        public IAttribute IAttributeInstance { get; set; }
        public IAttributeObject(IAttribute IAttributeinstance)
        {
            IAttributeInstance = IAttributeinstance;
        }
    }
    public static class IAttributeInterface
    {
        public static Object GetParameter(IAttributeObject IAttributeinstance, String NameIn)
        {
            return IAttributeinstance.IAttributeInstance.GetParameter(NameIn);
        }
        public static IParameterObject IGetParameter(IAttributeObject IAttributeinstance, String NameIn)
        {
            return new IParameterObject(IAttributeinstance.IAttributeInstance.IGetParameter(NameIn));
        }
        public static Object GetEntity(IAttributeObject IAttributeinstance)
        {
            return IAttributeinstance.IAttributeInstance.GetEntity();
        }
        public static IEntityObject IGetEntity(IAttributeObject IAttributeinstance)
        {
            return new IEntityObject(IAttributeinstance.IAttributeInstance.IGetEntity());
        }
        public static Object GetDefinition(IAttributeObject IAttributeinstance)
        {
            return IAttributeinstance.IAttributeInstance.GetDefinition();
        }
        public static IAttributeDefObject IGetDefinition(IAttributeObject IAttributeinstance)
        {
            return new IAttributeDefObject(IAttributeinstance.IAttributeInstance.IGetDefinition());
        }
        public static String GetName(IAttributeObject IAttributeinstance)
        {
            return IAttributeinstance.IAttributeInstance.GetName();
        }
        public static Boolean GetEntityState(IAttributeObject IAttributeinstance, Int32 WhichState)
        {
            return IAttributeinstance.IAttributeInstance.GetEntityState(WhichState);
        }
        public static Object GetComponent(IAttributeObject IAttributeinstance)
        {
            return IAttributeinstance.IAttributeInstance.GetComponent();
        }
        public static IComponentObject IGetComponent(IAttributeObject IAttributeinstance)
        {
            return new IComponentObject(IAttributeinstance.IAttributeInstance.IGetComponent());
        }
        public static IComponent2Object IGetComponent2(IAttributeObject IAttributeinstance)
        {
            return new IComponent2Object(IAttributeinstance.IAttributeInstance.IGetComponent2());
        }
        public static Object GetEntity2(IAttributeObject IAttributeinstance)
        {
            return IAttributeinstance.IAttributeInstance.GetEntity2();
        }
        public static IEntityObject IGetEntity2(IAttributeObject IAttributeinstance)
        {
            return new IEntityObject(IAttributeinstance.IAttributeInstance.IGetEntity2());
        }
        public static IBody2Object GetBody(IAttributeObject IAttributeinstance)
        {
            return new IBody2Object(IAttributeinstance.IAttributeInstance.GetBody());
        }
        public static Boolean Delete(IAttributeObject IAttributeinstance, Boolean BuildTree)
        {
            return IAttributeinstance.IAttributeInstance.Delete(BuildTree);
        }
        public static Boolean IncludeInLibraryFeature(IAttributeObject IAttributeinstance)
        {
            return IAttributeinstance.IAttributeInstance.IncludeInLibraryFeature;
        }
    }
}
using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAttributeDefObject
    {
        public IAttributeDef IAttributeDefInstance { get; set; }
        public IAttributeDefObject(IAttributeDef IAttributeDefinstance)
        {
            IAttributeDefInstance = IAttributeDefinstance;
        }
    }
    public static class IAttributeDefInterface
    {
        public static Object CreateInstance(IAttributeDefObject IAttributeDefinstance, Object OwnerDoc, Object OwnerEntity, String NameIn)
        {
            return IAttributeDefinstance.IAttributeDefInstance.CreateInstance(OwnerDoc, OwnerEntity, NameIn);
        }
        public static IAttributeObject ICreateInstance(IAttributeDefObject IAttributeDefinstance, IModelDocObject OwnerDoc, IEntityObject OwnerEntity, String NameIn)
        {
            return new IAttributeObject(IAttributeDefinstance.IAttributeDefInstance.ICreateInstance(OwnerDoc.IModelDocInstance as ModelDoc, OwnerEntity.IEntityInstance as Entity, NameIn));
        }
        public static Boolean AddParameter(IAttributeDefObject IAttributeDefinstance, String NameIn, Int32 Type, Double DefaultValue, Int32 Options)
        {
            return IAttributeDefinstance.IAttributeDefInstance.AddParameter(NameIn, Type, DefaultValue, Options);
        }
        public static Boolean SetOption(IAttributeDefObject IAttributeDefinstance, Int32 WhichOption, Int32 OptionValue)
        {
            return IAttributeDefinstance.IAttributeDefInstance.SetOption(WhichOption, OptionValue);
        }
        public static Int32 GetOption(IAttributeDefObject IAttributeDefinstance, Int32 WhichOption)
        {
            return IAttributeDefinstance.IAttributeDefInstance.GetOption(WhichOption);
        }
        public static Boolean AddCallback(IAttributeDefObject IAttributeDefinstance, Int32 WhichCallback, String CallbackFcnAndModule, Int32 WhichOption)
        {
            return IAttributeDefinstance.IAttributeDefInstance.AddCallback(WhichCallback, CallbackFcnAndModule, WhichOption);
        }
        public static Boolean Register(IAttributeDefObject IAttributeDefinstance)
        {
            return IAttributeDefinstance.IAttributeDefInstance.Register();
        }
        public static Object CreateInstance2(IAttributeDefObject IAttributeDefinstance, Object OwnerDoc, Object OwnerEntity, String NameIn, Int32 Options)
        {
            return IAttributeDefinstance.IAttributeDefInstance.CreateInstance2(OwnerDoc, OwnerEntity, NameIn, Options);
        }
        public static IAttributeObject ICreateInstance2(IAttributeDefObject IAttributeDefinstance, IModelDocObject OwnerDoc, IEntityObject OwnerEntity, String NameIn, Int32 Options)
        {
            return new IAttributeObject(IAttributeDefinstance.IAttributeDefInstance.ICreateInstance2(OwnerDoc.IModelDocInstance as ModelDoc, OwnerEntity.IEntityInstance as Entity, NameIn, Options));
        }
        public static Object CreateInstance3(IAttributeDefObject IAttributeDefinstance, Object OwnerDoc, Object OwnerComp, Object OwnerEntity, String NameIn, Int32 Options, Int32 ConfigurationOption)
        {
            return IAttributeDefinstance.IAttributeDefInstance.CreateInstance3(OwnerDoc, OwnerComp, OwnerEntity, NameIn, Options, ConfigurationOption);
        }
        public static IAttributeObject ICreateInstance3(IAttributeDefObject IAttributeDefinstance, IModelDocObject OwnerDoc, IComponentObject OwnerComp, IEntityObject OwnerEntity, String NameIn, Int32 Options, Int32 ConfigurationOption)
        {
            return new IAttributeObject(IAttributeDefinstance.IAttributeDefInstance.ICreateInstance3(OwnerDoc.IModelDocInstance.CastObj<ModelDoc>(), OwnerComp.IComponentInstance.CastObj<Component>(), OwnerEntity.CastObj<Entity>(), NameIn, Options, ConfigurationOption));
        }
        public static IAttributeObject ICreateInstance4(IAttributeDefObject IAttributeDefinstance, IModelDoc2Object OwnerDoc, IComponent2Object OwnerComp, IEntityObject OwnerEntity, String NameIn, Int32 Options, Int32 ConfigurationOption)
        {
            return new IAttributeObject(IAttributeDefinstance.IAttributeDefInstance.ICreateInstance4(OwnerDoc.IModelDoc2Instance as ModelDoc2, OwnerComp.IComponent2Instance as Component2, OwnerEntity.IEntityInstance as Entity, NameIn, Options, ConfigurationOption));
        }
        public static IAttributeObject CreateInstance4(IAttributeDefObject IAttributeDefinstance, IModelDoc2Object OwnerDoc, Object OwnerObj, String NameIn, Int32 Options, Int32 ConfigurationOption)
        {
            return new IAttributeObject(IAttributeDefinstance.IAttributeDefInstance.CreateInstance4(OwnerDoc.IModelDoc2Instance as ModelDoc2, OwnerObj, NameIn, Options, ConfigurationOption));
        }
        public static IAttributeObject CreateInstance5(IAttributeDefObject IAttributeDefinstance, IModelDoc2Object OwnerDoc, Object OwnerObj, String NameIn, Int32 Options, Int32 ConfigurationOption)
        {
            return new IAttributeObject(IAttributeDefinstance.IAttributeDefInstance.CreateInstance5(OwnerDoc.IModelDoc2Instance.CastObj<ModelDoc2>(), OwnerObj, NameIn, Options, ConfigurationOption));
        }
    }
}
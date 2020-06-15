using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchRelationObject
    {
        public ISketchRelation ISketchRelationInstance { get; set; }
        public ISketchRelationObject(ISketchRelation ISketchRelationinstance)
        {
            ISketchRelationInstance = ISketchRelationinstance;
        }
    }
    public static class ISketchRelationInterface
    {
        public static Object GetEntities(ISketchRelationObject ISketchRelationinstance)
        {
            return ISketchRelationinstance.ISketchRelationInstance.GetEntities();
        }
        public static Int32 GetEntitiesCount(ISketchRelationObject ISketchRelationinstance)
        {
            return ISketchRelationinstance.ISketchRelationInstance.GetEntitiesCount();
        }
        public static Object IGetEntities(ISketchRelationObject ISketchRelationinstance, Int32 NumEntities)
        {
            return ISketchRelationinstance.ISketchRelationInstance.IGetEntities(NumEntities);
        }
        public static Int32 GetRelationType(ISketchRelationObject ISketchRelationinstance)
        {
            return ISketchRelationinstance.ISketchRelationInstance.GetRelationType();
        }
        public static Object GetEntitiesType(ISketchRelationObject ISketchRelationinstance)
        {
            return ISketchRelationinstance.ISketchRelationInstance.GetEntitiesType();
        }
        public static Int32 IGetEntitiesType(ISketchRelationObject ISketchRelationinstance, Int32 NumEntities)
        {
            return ISketchRelationinstance.ISketchRelationInstance.IGetEntitiesType(NumEntities);
        }
        public static Object GetDefinitionEntities(ISketchRelationObject ISketchRelationinstance)
        {
            return ISketchRelationinstance.ISketchRelationInstance.GetDefinitionEntities();
        }
        public static Object IGetDefinitionEntities(ISketchRelationObject ISketchRelationinstance, Int32 NumEntities)
        {
            return ISketchRelationinstance.ISketchRelationInstance.IGetDefinitionEntities(NumEntities);
        }
        public static Boolean ReplaceEntity(ISketchRelationObject ISketchRelationinstance, Object OldEntity, Object NewEntity)
        {
            return ISketchRelationinstance.ISketchRelationInstance.ReplaceEntity(OldEntity, NewEntity);
        }
        public static Object GetDefinitionEntities2(ISketchRelationObject ISketchRelationinstance)
        {
            return ISketchRelationinstance.ISketchRelationInstance.GetDefinitionEntities2();
        }
        public static Object IGetDefinitionEntities2(ISketchRelationObject ISketchRelationinstance, Int32 NumEntities)
        {
            return ISketchRelationinstance.ISketchRelationInstance.IGetDefinitionEntities2(NumEntities);
        }
        public static Object GetDisplayDimension(ISketchRelationObject ISketchRelationinstance)
        {
            return ISketchRelationinstance.ISketchRelationInstance.GetDisplayDimension();
        }
        public static Boolean Suppressed(ISketchRelationObject ISketchRelationinstance)
        {
            return ISketchRelationinstance.ISketchRelationInstance.Suppressed;
        }
    }
}
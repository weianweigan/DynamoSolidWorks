using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchRelationManagerObject
    {
        public ISketchRelationManager ISketchRelationManagerInstance { get; set; }
        public ISketchRelationManagerObject(ISketchRelationManager ISketchRelationManagerinstance)
        {
            ISketchRelationManagerInstance = ISketchRelationManagerinstance;
        }
    }
    public static class ISketchRelationManagerInterface
    {
        public static Object GetRelations(ISketchRelationManagerObject ISketchRelationManagerinstance, Int32 Filter)
        {
            return ISketchRelationManagerinstance.ISketchRelationManagerInstance.GetRelations(Filter);
        }
        public static Int32 GetRelationsCount(ISketchRelationManagerObject ISketchRelationManagerinstance, Int32 Filter)
        {
            return ISketchRelationManagerinstance.ISketchRelationManagerInstance.GetRelationsCount(Filter);
        }
        public static ISketchRelationObject IGetRelations(ISketchRelationManagerObject ISketchRelationManagerinstance, Int32 Filter, Int32 Count)
        {
            return new ISketchRelationObject(ISketchRelationManagerinstance.ISketchRelationManagerInstance.IGetRelations(Filter, Count));
        }
        public static ISketchRelationObject AddRelation(ISketchRelationManagerObject ISketchRelationManagerinstance, Object Entities, Int32 RelationType)
        {
            return new ISketchRelationObject(ISketchRelationManagerinstance.ISketchRelationManagerInstance.AddRelation(Entities, RelationType));
        }
        //public static ISketchRelationObject IAddRelation(ISketchRelationManagerObject ISketchRelationManagerinstance, Int32 NumEntities, Object& EntityArray, Int32 RelationType)
        //{
        //    return new ISketchRelationObject(ISketchRelationManagerinstance.ISketchRelationManagerInstance.IAddRelation(NumEntities, EntityArray, RelationType));
        //}
        public static Boolean DeleteAllRelations(ISketchRelationManagerObject ISketchRelationManagerinstance)
        {
            return ISketchRelationManagerinstance.ISketchRelationManagerInstance.DeleteAllRelations();
        }
        public static Boolean DeleteRelation(ISketchRelationManagerObject ISketchRelationManagerinstance, ISketchRelationObject ThisRelation)
        {
            return ISketchRelationManagerinstance.ISketchRelationManagerInstance.DeleteRelation(ThisRelation?.ISketchRelationInstance.CastObj<SketchRelation>());
        }
        public static Object GetAllowedRelations(ISketchRelationManagerObject ISketchRelationManagerinstance, Object Entities)
        {
            return ISketchRelationManagerinstance.ISketchRelationManagerInstance.GetAllowedRelations(Entities);
        }
        //public static Int32 IGetAllowedRelationsCount(ISketchRelationManagerObject ISketchRelationManagerinstance, Int32 NumEntities, Object& EntityArray)
        //{
        //    return ISketchRelationManagerinstance.ISketchRelationManagerInstance.IGetAllowedRelationsCount(NumEntities, EntityArray);
        //}
        //public static Int32 IGetAllowedRelations(ISketchRelationManagerObject ISketchRelationManagerinstance, Int32 NumEntities, Object& EntityArray, Int32 NumAllowedRelations)
        //{
        //    return ISketchRelationManagerinstance.ISketchRelationManagerInstance.IGetAllowedRelations(NumEntities, EntityArray, NumAllowedRelations);
        //}
    }
}
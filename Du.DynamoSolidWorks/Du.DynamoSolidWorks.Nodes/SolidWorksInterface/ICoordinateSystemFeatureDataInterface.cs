using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICoordinateSystemFeatureDataObject
    {
        public ICoordinateSystemFeatureData ICoordinateSystemFeatureDataInstance { get; set; }
        public ICoordinateSystemFeatureDataObject(ICoordinateSystemFeatureData ICoordinateSystemFeatureDatainstance)
        {
            ICoordinateSystemFeatureDataInstance = ICoordinateSystemFeatureDatainstance;
        }
    }
    public static class ICoordinateSystemFeatureDataInterface
    {
        public static Boolean IAccessSelections(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static Boolean AccessSelections(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetXAxisEntitiesCount(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.GetXAxisEntitiesCount();
        }
        public static Int32 GetYAxisEntitiesCount(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.GetYAxisEntitiesCount();
        }
        public static Int32 GetZAxisEntitiesCount(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.GetZAxisEntitiesCount();
        }
        public static Object IGetOriginEntity(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IGetOriginEntity();
        }
        public static Object IGetXAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, Int32 Count)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IGetXAxisEntities(Count);
        }
        public static Object IGetYAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, Int32 Count)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IGetYAxisEntities(Count);
        }
        public static Object IGetZAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, Int32 Count)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IGetZAxisEntities(Count);
        }
        public static void ISetOriginEntity(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, Object Ent)
        {
            ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.ISetOriginEntity(Ent);
        }
        //public static void ISetXAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, Int32 Count, Object& EntArray)
        //{
        //    return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.ISetXAxisEntities(Count, EntArray);
        //}
        //public static void ISetYAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, Int32 Count, Object& EntArray)
        //{
        //    return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.ISetYAxisEntities(Count, EntArray);
        //}
        //public static void ISetZAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance, Int32 Count, Object& EntArray)
        //{
        //    return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.ISetZAxisEntities(Count, EntArray);
        //}
        public static Int32 GetOriginEntityType(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.GetOriginEntityType();
        }
        public static Object GetXAxisEntitiesTypes(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.GetXAxisEntitiesTypes();
        }
        public static Object GetYAxisEntitiesTypes(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.GetYAxisEntitiesTypes();
        }
        public static Object GetZAxisEntitiesTypes(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.GetZAxisEntitiesTypes();
        }
        public static Int32 IGetOriginEntityType(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IGetOriginEntityType();
        }
        public static Int32 IGetXAxisEntitiesTypes(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IGetXAxisEntitiesTypes();
        }
        public static Int32 IGetYAxisEntitiesTypes(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IGetYAxisEntitiesTypes();
        }
        public static Int32 IGetZAxisEntitiesTypes(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.IGetZAxisEntitiesTypes();
        }
        public static Boolean XFlipped(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.XFlipped;
        }
        public static Boolean YFlipped(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.YFlipped;
        }
        public static Boolean ZFlipped(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.ZFlipped;
        }
        public static Object OriginEntity(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.OriginEntity;
        }
        public static Object XAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.XAxisEntities;
        }
        public static Object YAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.YAxisEntities;
        }
        public static Object ZAxisEntities(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.ZAxisEntities;
        }
        public static IMathTransformObject Transform(ICoordinateSystemFeatureDataObject ICoordinateSystemFeatureDatainstance)
        {
            return new IMathTransformObject(ICoordinateSystemFeatureDatainstance.ICoordinateSystemFeatureDataInstance.Transform);
        }
    }
}
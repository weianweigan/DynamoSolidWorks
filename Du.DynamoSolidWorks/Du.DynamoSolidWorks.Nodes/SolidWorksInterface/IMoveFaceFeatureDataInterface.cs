using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMoveFaceFeatureDataObject
    {
        public IMoveFaceFeatureData IMoveFaceFeatureDataInstance { get; set; }
        public IMoveFaceFeatureDataObject(IMoveFaceFeatureData IMoveFaceFeatureDatainstance)
        {
            IMoveFaceFeatureDataInstance = IMoveFaceFeatureDatainstance;
        }
    }
    public static class IMoveFaceFeatureDataInterface
    {
        public static Boolean AccessSelections(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component.IComponent2Instance.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetFacesCount(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.GetFacesCount();
        }
        public static IFace2Object IGetFaces(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Int32 Count)
        {
            return new IFace2Object(IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.IGetFaces(Count));
        }
        //public static void ISetFaces(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Int32 Count, Face2&Object EntIn)
        //{
        //    return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.ISetFaces(Count, EntIn);
        //}
        //public static Object GetDirectionReference(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Int32& DirRefType)
        //{
        //    return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.GetDirectionReference(DirRefType);
        //}
        public static Boolean SetDirectionReference(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Object LpDispatch)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.SetDirectionReference(LpDispatch);
        }
        public static Double IGetTriadRotationParameters(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.IGetTriadRotationParameters();
        }
        //public static void ISetTriadRotationParameters(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Double& RotationParameters)
        //{
        //    return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.ISetTriadRotationParameters(RotationParameters);
        //}
        public static Double IGetTriadTranslationParameters(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.IGetTriadTranslationParameters();
        }
        //public static void ISetTriadTranslationParameters(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Double& TranslationParameters)
        //{
        //    return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.ISetTriadTranslationParameters(TranslationParameters);
        //}
        //public static void GetFromEntity(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Object& FromEntity, Int32& Type)
        //{
        //    return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.GetFromEntity(FromEntity, Type);
        //}
        public static void SetFromEntity(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Object FromEntity)
        {
            IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.SetFromEntity(FromEntity);
        }
        public static Object GetEndConditionEntity(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.GetEndConditionEntity();
        }
        public static void SetEndConditionEntity(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance, Object EndEntity)
        {
            IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.SetEndConditionEntity(EndEntity);
        }
        public static Int32 MoveType(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.MoveType;
        }
        public static Boolean ReverseDirection(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.ReverseDirection;
        }
        public static Double Angle(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.Angle;
        }
        public static Double Distance(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.Distance;
        }
        public static Object Faces(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.Faces;
        }
        public static Object TriadRotationParameters(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.TriadRotationParameters;
        }
        public static Object TriadTranslationParameters(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.TriadTranslationParameters;
        }
        public static Int32 EndCondition(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.EndCondition;
        }
        public static Double OffsetDistance(IMoveFaceFeatureDataObject IMoveFaceFeatureDatainstance)
        {
            return IMoveFaceFeatureDatainstance.IMoveFaceFeatureDataInstance.OffsetDistance;
        }
    }
}
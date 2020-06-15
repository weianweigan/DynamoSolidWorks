using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMoveCopyBodyFeatureDataObject
    {
        public IMoveCopyBodyFeatureData IMoveCopyBodyFeatureDataInstance { get; set; }
        public IMoveCopyBodyFeatureDataObject(IMoveCopyBodyFeatureData IMoveCopyBodyFeatureDatainstance)
        {
            IMoveCopyBodyFeatureDataInstance = IMoveCopyBodyFeatureDatainstance;
        }
    }
    public static class IMoveCopyBodyFeatureDataInterface
    {
        public static Boolean AccessSelections(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance, IModelDoc2Object PTopDoc, IComponent2Object PComponent)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.AccessSelections(PTopDoc.IModelDoc2Instance.CastObj<ModelDoc2>(), PComponent.IComponent2Instance.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetBodiesCount(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.GetBodiesCount();
        }
        public static IBody2Object IGetBodies(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance, Int32 NCount)
        {
            return new IBody2Object(IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.IGetBodies(NCount));
        }
        //public static void ISetBodies(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance, Int32 NCount, Body2&Object PBodies)
        //{
        //    return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.ISetBodies(NCount, PBodies);
        //}
        //public static IMate2Object AddMate(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance, Object MateEntVar, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Double Distance, Double Angle, Int32& ErrorStatus)
        //{
        //    return new IMate2Object(IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.AddMate(MateEntVar, MateTypeFromEnum, AlignFromEnum, Distance, Angle, ErrorStatus));
        //}
        //public static IMate2Object IAddMate(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance, Int32 Nsize, Object& MateEntArr, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Double Distance, Double Angle, Int32& ErrorStatus)
        //{
        //    return new IMate2Object(IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.IAddMate(Nsize, MateEntArr, MateTypeFromEnum, AlignFromEnum, Distance, Angle, ErrorStatus));
        //}
        public static Object Bodies(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.Bodies;
        }
        public static Int32 TransformType(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.TransformType;
        }
        public static Boolean Copy(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.Copy;
        }
        public static Int32 NumberOfCopies(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.NumberOfCopies;
        }
        public static Object TransformReferenceEntity(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.TransformReferenceEntity;
        }
        public static Object TranslateToVertex(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.TranslateToVertex;
        }
        public static Double TransformValue(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.TransformValue;
        }
        public static Double RotationOriginX(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.RotationOriginX;
        }
        public static Double RotationOriginY(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.RotationOriginY;
        }
        public static Double RotationOriginZ(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.RotationOriginZ;
        }
        public static Double TransformX(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.TransformX;
        }
        public static Double TransformY(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.TransformY;
        }
        public static Double TransformZ(IMoveCopyBodyFeatureDataObject IMoveCopyBodyFeatureDatainstance)
        {
            return IMoveCopyBodyFeatureDatainstance.IMoveCopyBodyFeatureDataInstance.TransformZ;
        }
    }
}
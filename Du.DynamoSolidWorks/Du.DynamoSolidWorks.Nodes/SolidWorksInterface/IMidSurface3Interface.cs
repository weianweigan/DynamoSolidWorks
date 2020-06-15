using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMidSurface3Object
    {
        public IMidSurface3 IMidSurface3Instance { get; set; }
        public IMidSurface3Object(IMidSurface3 IMidSurface3instance)
        {
            IMidSurface3Instance = IMidSurface3instance;
        }
    }
    public static class IMidSurface3Interface
    {
        public static Int32 GetFacePairCount(IMidSurface3Object IMidSurface3instance)
        {
            return IMidSurface3instance.IMidSurface3Instance.GetFacePairCount();
        }
        //public static Object GetFirstFacePair(IMidSurface3Object IMidSurface3instance, Double& Thickness, Object& PartnerFaceDisp)
        //{
        //    return IMidSurface3instance.IMidSurface3Instance.GetFirstFacePair(Thickness, PartnerFaceDisp);
        //}
        //public static IFace2Object IGetFirstFacePair(IMidSurface3Object IMidSurface3instance, Double& Thickness, Face2&Object PartnerFaceDisp)
        //{
        //    return new IFace2Object(IMidSurface3instance.IMidSurface3Instance.IGetFirstFacePair(Thickness, PartnerFaceDisp));
        //}
        //public static Object GetNextFacePair(IMidSurface3Object IMidSurface3instance, Double& Thickness, Object& PartnerFaceDisp)
        //{
        //    return IMidSurface3instance.IMidSurface3Instance.GetNextFacePair(Thickness, PartnerFaceDisp);
        //}
        //public static IFace2Object IGetNextFacePair(IMidSurface3Object IMidSurface3instance, Double& Thickness, Face2&Object PartnerFaceDisp)
        //{
        //    return new IFace2Object(IMidSurface3instance.IMidSurface3Instance.IGetNextFacePair(Thickness, PartnerFaceDisp));
        //}
        public static Object GetFirstNeutralSheet(IMidSurface3Object IMidSurface3instance)
        {
            return IMidSurface3instance.IMidSurface3Instance.GetFirstNeutralSheet();
        }
        public static IBody2Object IGetFirstNeutralSheet(IMidSurface3Object IMidSurface3instance)
        {
            return new IBody2Object(IMidSurface3instance.IMidSurface3Instance.IGetFirstNeutralSheet());
        }
        public static Object GetNextNeutralSheet(IMidSurface3Object IMidSurface3instance)
        {
            return IMidSurface3instance.IMidSurface3Instance.GetNextNeutralSheet();
        }
        public static IBody2Object IGetNextNeutralSheet(IMidSurface3Object IMidSurface3instance)
        {
            return new IBody2Object(IMidSurface3instance.IMidSurface3Instance.IGetNextNeutralSheet());
        }
        public static Int32 GetNeutralSheetCount(IMidSurface3Object IMidSurface3instance)
        {
            return IMidSurface3instance.IMidSurface3Instance.GetNeutralSheetCount();
        }
        public static Int32 GetFaceCount(IMidSurface3Object IMidSurface3instance)
        {
            return IMidSurface3instance.IMidSurface3Instance.GetFaceCount();
        }
        //public static Object GetFirstFace(IMidSurface3Object IMidSurface3instance, Object& FromFace1Disp, Object& FromFace2Disp, Double& Thickness)
        //{
        //    return IMidSurface3instance.IMidSurface3Instance.GetFirstFace(FromFace1Disp, FromFace2Disp, Thickness);
        //}
        //public static IFace2Object IGetFirstFace(IMidSurface3Object IMidSurface3instance, Face2&Object FromFace1Disp, Face2&Object FromFace2Disp, Double& Thickness)
        //{
        //    return new IFace2Object(IMidSurface3instance.IMidSurface3Instance.IGetFirstFace(FromFace1Disp, FromFace2Disp, Thickness));
        //}
        //public static Object GetNextFace(IMidSurface3Object IMidSurface3instance, Object& FromFace1Disp, Object& FromFace2Disp, Double& Thickness)
        //{
        //    return IMidSurface3instance.IMidSurface3Instance.GetNextFace(FromFace1Disp, FromFace2Disp, Thickness);
        //}
        //public static IFace2Object IGetNextFace(IMidSurface3Object IMidSurface3instance, Face2&Object FromFace1Disp, Face2&Object FromFace2Disp, Double& Thickness)
        //{
        //    return new IFace2Object(IMidSurface3instance.IMidSurface3Instance.IGetNextFace(FromFace1Disp, FromFace2Disp, Thickness));
        //}
        public static Object EdgeGetFace(IMidSurface3Object IMidSurface3instance, Object EdgeInDisp)
        {
            return IMidSurface3instance.IMidSurface3Instance.EdgeGetFace(EdgeInDisp);
        }
        public static IFace2Object IEdgeGetFace(IMidSurface3Object IMidSurface3instance, IEdgeObject EdgeInDisp)
        {
            return new IFace2Object(IMidSurface3instance.IMidSurface3Instance.IEdgeGetFace(EdgeInDisp.IEdgeInstance as Edge));
        }
        //public static IFace2Object IGetFirstFaceArray(IMidSurface3Object IMidSurface3instance, Face2&Object FromFrontFaceListDisp, Int32& SizeOfFrontFaceList, Face2&Object FromFaceBackListDisp, Int32& SizeOfBackFaceList, Double& Thickness)
        //{
        //    return new IFace2Object(IMidSurface3instance.IMidSurface3Instance.IGetFirstFaceArray(FromFrontFaceListDisp, SizeOfFrontFaceList, FromFaceBackListDisp, SizeOfBackFaceList, Thickness));
        //}
        //public static IFace2Object IGetNextFaceArray(IMidSurface3Object IMidSurface3instance, Face2&Object FromFrontFaceListDisp, Int32& SizeOfFrontFaceList, Face2&Object FromFaceBackListDisp, Int32& SizeOfBackFaceList, Double& Thickness)
        //{
        //    return new IFace2Object(IMidSurface3instance.IMidSurface3Instance.IGetNextFaceArray(FromFrontFaceListDisp, SizeOfFrontFaceList, FromFaceBackListDisp, SizeOfBackFaceList, Thickness));
        //}
        //public static Object GetFirstFaceArray(IMidSurface3Object IMidSurface3instance, Double& Thickness)
        //{
        //    return IMidSurface3instance.IMidSurface3Instance.GetFirstFaceArray(Thickness);
        //}
        //public static Object GetNextFaceArray(IMidSurface3Object IMidSurface3instance, Double& Thickness)
        //{
        //    return IMidSurface3instance.IMidSurface3Instance.GetNextFaceArray(Thickness);
        //}
        public static Object GetFaces(IMidSurface3Object IMidSurface3instance)
        {
            return IMidSurface3instance.IMidSurface3Instance.GetFaces();
        }
        public static IFace2Object IGetFaces(IMidSurface3Object IMidSurface3instance, Int32 NumFaces)
        {
            return new IFace2Object(IMidSurface3instance.IMidSurface3Instance.IGetFaces(NumFaces));
        }
    }
}
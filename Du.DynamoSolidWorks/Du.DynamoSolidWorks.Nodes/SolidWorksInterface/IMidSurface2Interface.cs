using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMidSurface2Object
    {
        public IMidSurface2 IMidSurface2Instance { get; set; }
        public IMidSurface2Object(IMidSurface2 IMidSurface2instance)
        {
            IMidSurface2Instance = IMidSurface2instance;
        }
    }
    public static class IMidSurface2Interface
    {
        public static Int32 GetFacePairCount(IMidSurface2Object IMidSurface2instance)
        {
            return IMidSurface2instance.IMidSurface2Instance.GetFacePairCount();
        }
        //public static Object GetFirstFacePair(IMidSurface2Object IMidSurface2instance, Double& Thickness, Object& PartnerFaceDisp)
        //{
        //    return IMidSurface2instance.IMidSurface2Instance.GetFirstFacePair(Thickness, PartnerFaceDisp);
        //}
        //public static IFace2Object IGetFirstFacePair(IMidSurface2Object IMidSurface2instance, Double& Thickness, Face2&Object PartnerFaceDisp)
        //{
        //    return new IFace2Object(IMidSurface2instance.IMidSurface2Instance.IGetFirstFacePair(Thickness, PartnerFaceDisp));
        //}
        //public static Object GetNextFacePair(IMidSurface2Object IMidSurface2instance, Double& Thickness, Object& PartnerFaceDisp)
        //{
        //    return IMidSurface2instance.IMidSurface2Instance.GetNextFacePair(Thickness, PartnerFaceDisp);
        //}
        //public static IFace2Object IGetNextFacePair(IMidSurface2Object IMidSurface2instance, Double& Thickness, Face2&Object PartnerFaceDisp)
        //{
        //    return new IFace2Object(IMidSurface2instance.IMidSurface2Instance.IGetNextFacePair(Thickness, PartnerFaceDisp));
        //}
        public static Object GetFirstNeutralSheet(IMidSurface2Object IMidSurface2instance)
        {
            return IMidSurface2instance.IMidSurface2Instance.GetFirstNeutralSheet();
        }
        public static IBody2Object IGetFirstNeutralSheet(IMidSurface2Object IMidSurface2instance)
        {
            return new IBody2Object(IMidSurface2instance.IMidSurface2Instance.IGetFirstNeutralSheet());
        }
        public static Object GetNextNeutralSheet(IMidSurface2Object IMidSurface2instance)
        {
            return IMidSurface2instance.IMidSurface2Instance.GetNextNeutralSheet();
        }
        public static IBody2Object IGetNextNeutralSheet(IMidSurface2Object IMidSurface2instance)
        {
            return new IBody2Object(IMidSurface2instance.IMidSurface2Instance.IGetNextNeutralSheet());
        }
        public static Int32 GetNeutralSheetCount(IMidSurface2Object IMidSurface2instance)
        {
            return IMidSurface2instance.IMidSurface2Instance.GetNeutralSheetCount();
        }
        public static Int32 GetFaceCount(IMidSurface2Object IMidSurface2instance)
        {
            return IMidSurface2instance.IMidSurface2Instance.GetFaceCount();
        }
        //public static Object GetFirstFace(IMidSurface2Object IMidSurface2instance, Object& FromFace1Disp, Object& FromFace2Disp, Double& Thickness)
        //{
        //    return IMidSurface2instance.IMidSurface2Instance.GetFirstFace(FromFace1Disp, FromFace2Disp, Thickness);
        //}
        //public static IFace2Object IGetFirstFace(IMidSurface2Object IMidSurface2instance, Face2&Object FromFace1Disp, Face2&Object FromFace2Disp, Double& Thickness)
        //{
        //    return new IFace2Object(IMidSurface2instance.IMidSurface2Instance.IGetFirstFace(FromFace1Disp, FromFace2Disp, Thickness));
        //}
        //public static Object GetNextFace(IMidSurface2Object IMidSurface2instance, Object& FromFace1Disp, Object& FromFace2Disp, Double& Thickness)
        //{
        //    return IMidSurface2instance.IMidSurface2Instance.GetNextFace(FromFace1Disp, FromFace2Disp, Thickness);
        //}
        //public static IFace2Object IGetNextFace(IMidSurface2Object IMidSurface2instance, Face2&Object FromFace1Disp, Face2&Object FromFace2Disp, Double& Thickness)
        //{
        //    return new IFace2Object(IMidSurface2instance.IMidSurface2Instance.IGetNextFace(FromFace1Disp, FromFace2Disp, Thickness));
        //}
        public static Object EdgeGetFace(IMidSurface2Object IMidSurface2instance, Object EdgeInDisp)
        {
            return IMidSurface2instance.IMidSurface2Instance.EdgeGetFace(EdgeInDisp);
        }
        public static IFace2Object IEdgeGetFace(IMidSurface2Object IMidSurface2instance, IEdgeObject EdgeInDisp)
        {
            return new IFace2Object(IMidSurface2instance.IMidSurface2Instance.IEdgeGetFace(EdgeInDisp.IEdgeInstance as Edge));
        }
        //public static IFace2Object IGetFirstFaceArray(IMidSurface2Object IMidSurface2instance, Face2&Object FromFrontFaceListDisp, Int32& SizeOfFrontFaceList, Face2&Object FromFaceBackListDisp, Int32& SizeOfBackFaceList, Double& Thickness)
        //{
        //    return new IFace2Object(IMidSurface2instance.IMidSurface2Instance.IGetFirstFaceArray(FromFrontFaceListDisp, SizeOfFrontFaceList, FromFaceBackListDisp, SizeOfBackFaceList, Thickness));
        //}
        //public static IFace2Object IGetNextFaceArray(IMidSurface2Object IMidSurface2instance, Face2&Object FromFrontFaceListDisp, Int32& SizeOfFrontFaceList, Face2&Object FromFaceBackListDisp, Int32& SizeOfBackFaceList, Double& Thickness)
        //{
        //    return new IFace2Object(IMidSurface2instance.IMidSurface2Instance.IGetNextFaceArray(FromFrontFaceListDisp, SizeOfFrontFaceList, FromFaceBackListDisp, SizeOfBackFaceList, Thickness));
        //}
        //public static Object GetFirstFaceArray(IMidSurface2Object IMidSurface2instance, Double& Thickness)
        //{
        //    return IMidSurface2instance.IMidSurface2Instance.GetFirstFaceArray(Thickness);
        //}
        //public static Object GetNextFaceArray(IMidSurface2Object IMidSurface2instance, Double& Thickness)
        //{
        //    return IMidSurface2instance.IMidSurface2Instance.GetNextFaceArray(Thickness);
        //}
    }
}
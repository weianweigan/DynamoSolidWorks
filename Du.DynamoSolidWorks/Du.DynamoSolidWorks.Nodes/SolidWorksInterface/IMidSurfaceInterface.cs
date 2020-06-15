using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMidSurfaceObject
    {
        public IMidSurface IMidSurfaceInstance { get; set; }
        public IMidSurfaceObject(IMidSurface IMidSurfaceinstance)
        {
            IMidSurfaceInstance = IMidSurfaceinstance;
        }
    }
    public static class IMidSurfaceInterface
    {
        public static Int32 GetFacePairCount(IMidSurfaceObject IMidSurfaceinstance)
        {
            return IMidSurfaceinstance.IMidSurfaceInstance.GetFacePairCount();
        }
        //public static Object GetFirstFacePair(IMidSurfaceObject IMidSurfaceinstance, Double& Thickness, Object& PartnerFaceDisp)
        //{
        //    return IMidSurfaceinstance.IMidSurfaceInstance.GetFirstFacePair(Thickness, PartnerFaceDisp);
        //}
        //public static IFaceObject IGetFirstFacePair(IMidSurfaceObject IMidSurfaceinstance, Double& Thickness, Face&Object PartnerFaceDisp)
        //{
        //    return new IFaceObject(IMidSurfaceinstance.IMidSurfaceInstance.IGetFirstFacePair(Thickness, PartnerFaceDisp));
        //}
        //public static Object GetNextFacePair(IMidSurfaceObject IMidSurfaceinstance, Double& Thickness, Object& PartnerFaceDisp)
        //{
        //    return IMidSurfaceinstance.IMidSurfaceInstance.GetNextFacePair(Thickness, PartnerFaceDisp);
        //}
        //public static IFaceObject IGetNextFacePair(IMidSurfaceObject IMidSurfaceinstance, Double& Thickness, Face&Object PartnerFaceDisp)
        //{
        //    return new IFaceObject(IMidSurfaceinstance.IMidSurfaceInstance.IGetNextFacePair(Thickness, PartnerFaceDisp));
        //}
        public static Object GetFirstNeutralSheet(IMidSurfaceObject IMidSurfaceinstance)
        {
            return IMidSurfaceinstance.IMidSurfaceInstance.GetFirstNeutralSheet();
        }
        public static IBodyObject IGetFirstNeutralSheet(IMidSurfaceObject IMidSurfaceinstance)
        {
            return new IBodyObject(IMidSurfaceinstance.IMidSurfaceInstance.IGetFirstNeutralSheet());
        }
        public static Object GetNextNeutralSheet(IMidSurfaceObject IMidSurfaceinstance)
        {
            return IMidSurfaceinstance.IMidSurfaceInstance.GetNextNeutralSheet();
        }
        public static IBodyObject IGetNextNeutralSheet(IMidSurfaceObject IMidSurfaceinstance)
        {
            return new IBodyObject(IMidSurfaceinstance.IMidSurfaceInstance.IGetNextNeutralSheet());
        }
        public static Int32 GetNeutralSheetCount(IMidSurfaceObject IMidSurfaceinstance)
        {
            return IMidSurfaceinstance.IMidSurfaceInstance.GetNeutralSheetCount();
        }
        public static Int32 GetFaceCount(IMidSurfaceObject IMidSurfaceinstance)
        {
            return IMidSurfaceinstance.IMidSurfaceInstance.GetFaceCount();
        }
        //public static Object GetFirstFace(IMidSurfaceObject IMidSurfaceinstance, Object& FromFace1Disp, Object& FromFace2Disp, Double& Thickness)
        //{
        //    return IMidSurfaceinstance.IMidSurfaceInstance.GetFirstFace(FromFace1Disp, FromFace2Disp, Thickness);
        //}
        //public static IFaceObject IGetFirstFace(IMidSurfaceObject IMidSurfaceinstance, Face&Object FromFace1Disp, Face&Object FromFace2Disp, Double& Thickness)
        //{
        //    return new IFaceObject(IMidSurfaceinstance.IMidSurfaceInstance.IGetFirstFace(FromFace1Disp, FromFace2Disp, Thickness));
        //}
        //public static Object GetNextFace(IMidSurfaceObject IMidSurfaceinstance, Object& FromFace1Disp, Object& FromFace2Disp, Double& Thickness)
        //{
        //    return IMidSurfaceinstance.IMidSurfaceInstance.GetNextFace(FromFace1Disp, FromFace2Disp, Thickness);
        //}
        //public static IFaceObject IGetNextFace(IMidSurfaceObject IMidSurfaceinstance, Face&Object FromFace1Disp, Face&Object FromFace2Disp, Double& Thickness)
        //{
        //    return new IFaceObject(IMidSurfaceinstance.IMidSurfaceInstance.IGetNextFace(FromFace1Disp, FromFace2Disp, Thickness));
        //}
        public static Object EdgeGetFace(IMidSurfaceObject IMidSurfaceinstance, Object EdgeInDisp)
        {
            return IMidSurfaceinstance.IMidSurfaceInstance.EdgeGetFace(EdgeInDisp);
        }
        //public static IFaceObject IEdgeGetFace(IMidSurfaceObject IMidSurfaceinstance, EdgeObject EdgeInDisp)
        //{
        //    return new IFaceObject(IMidSurfaceinstance.IMidSurfaceInstance.IEdgeGetFace(EdgeInDisp));
        //}
        //public static IFaceObject IGetFirstFaceArray(IMidSurfaceObject IMidSurfaceinstance, IntPtr FromFrontFaceListDisp, Int32& SizeOfFrontFaceList, IntPtr FromFaceBackListDisp, Int32& SizeOfBackFaceList, Double& Thickness)
        //{
        //    return new IFaceObject(IMidSurfaceinstance.IMidSurfaceInstance.IGetFirstFaceArray(FromFrontFaceListDisp, SizeOfFrontFaceList, FromFaceBackListDisp, SizeOfBackFaceList, Thickness));
        //}
        //public static IFaceObject IGetNextFaceArray(IMidSurfaceObject IMidSurfaceinstance, IntPtr FromFrontFaceListDisp, Int32& SizeOfFrontFaceList, IntPtr FromFaceBackListDisp, Int32& SizeOfBackFaceList, Double& Thickness)
        //{
        //    return new IFaceObject(IMidSurfaceinstance.IMidSurfaceInstance.IGetNextFaceArray(FromFrontFaceListDisp, SizeOfFrontFaceList, FromFaceBackListDisp, SizeOfBackFaceList, Thickness));
        //}
        //public static Object GetFirstFaceArray(IMidSurfaceObject IMidSurfaceinstance, Double& Thickness)
        //{
        //    return IMidSurfaceinstance.IMidSurfaceInstance.GetFirstFaceArray(Thickness);
        //}
        //public static Object GetNextFaceArray(IMidSurfaceObject IMidSurfaceinstance, Double& Thickness)
        //{
        //    return IMidSurfaceinstance.IMidSurfaceInstance.GetNextFaceArray(Thickness);
        //}
    }
}
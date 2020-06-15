using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchPictureObject
    {
        public ISketchPicture ISketchPictureInstance { get; set; }
        public ISketchPictureObject(ISketchPicture ISketchPictureinstance)
        {
            ISketchPictureInstance = ISketchPictureinstance;
        }
    }
    public static class ISketchPictureInterface
    {
        public static IFeatureObject GetFeature(ISketchPictureObject ISketchPictureinstance)
        {
            return new IFeatureObject(ISketchPictureinstance.ISketchPictureInstance.GetFeature());
        }
        //public static void GetOrigin(ISketchPictureObject ISketchPictureinstance, Double& X, Double& Y)
        //{
        //    return ISketchPictureinstance.ISketchPictureInstance.GetOrigin(X, Y);
        //}
        public static Boolean SetOrigin(ISketchPictureObject ISketchPictureinstance, Double X, Double Y)
        {
            return ISketchPictureinstance.ISketchPictureInstance.SetOrigin(X, Y);
        }
        //public static void GetSize(ISketchPictureObject ISketchPictureinstance, Double& Width, Double& Height)
        //{
        //    return ISketchPictureinstance.ISketchPictureInstance.GetSize(Width, Height);
        //}
        public static Boolean SetSize(ISketchPictureObject ISketchPictureinstance, Double Width, Double Height, Boolean AspectRatioLocked)
        {
            return ISketchPictureinstance.ISketchPictureInstance.SetSize(Width, Height, AspectRatioLocked);
        }
        public static Boolean Flip(ISketchPictureObject ISketchPictureinstance, Boolean SideToSide)
        {
            return ISketchPictureinstance.ISketchPictureInstance.Flip(SideToSide);
        }
        //public static void GetTransparency(ISketchPictureObject ISketchPictureinstance, Int32& Style, Double& Transparency, Int32& MatchingColor, Double& MatchingTolerance)
        //{
        //    return ISketchPictureinstance.ISketchPictureInstance.GetTransparency(Style, Transparency, MatchingColor, MatchingTolerance);
        //}
        public static Boolean SetTransparency(ISketchPictureObject ISketchPictureinstance, Int32 Style, Double Transparency, Int32 MatchingColor, Double MatchingTolerance)
        {
            return ISketchPictureinstance.ISketchPictureInstance.SetTransparency(Style, Transparency, MatchingColor, MatchingTolerance);
        }
        //public static Int32 GetPixelmapSize(ISketchPictureObject ISketchPictureinstance, Int32& Width, Int32& Height)
        //{
        //    return ISketchPictureinstance.ISketchPictureInstance.GetPixelmapSize(Width, Height);
        //}
        public static Object GetPixelmap(ISketchPictureObject ISketchPictureinstance)
        {
            return ISketchPictureinstance.ISketchPictureInstance.GetPixelmap();
        }
        public static Int16 IGetPixelmap(ISketchPictureObject ISketchPictureinstance, Int32 Count)
        {
            return ISketchPictureinstance.ISketchPictureInstance.IGetPixelmap(Count);
        }
        public static IMathPointObject GetPointOnSketchFromPixel(ISketchPictureObject ISketchPictureinstance, Int32 Row, Int32 Column)
        {
            return new IMathPointObject(ISketchPictureinstance.ISketchPictureInstance.GetPointOnSketchFromPixel(Row, Column));
        }
        public static Double Angle(ISketchPictureObject ISketchPictureinstance)
        {
            return ISketchPictureinstance.ISketchPictureInstance.Angle;
        }
        public static Boolean Flipped(ISketchPictureObject ISketchPictureinstance)
        {
            return ISketchPictureinstance.ISketchPictureInstance.Flipped;
        }
    }
}
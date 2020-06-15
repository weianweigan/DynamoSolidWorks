using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISwSceneObject
    {
        public ISwScene ISwSceneInstance { get; set; }
        public ISwSceneObject(ISwScene ISwSceneinstance)
        {
            ISwSceneInstance = ISwSceneinstance;
        }
    }
    public static class ISwSceneInterface
    {
        //public static void GetP2SFileName(ISwSceneObject ISwSceneinstance, String& Val)
        //{
        //    return ISwSceneinstance.ISwSceneInstance.GetP2SFileName(Val);
        //}
        public static Boolean Modify(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.Modify();
        }
        //public static void GetFloorNormal(ISwSceneObject ISwSceneinstance, MathPoint&Object Point, MathVector&Object Normal)
        //{
        //    return ISwSceneinstance.ISwSceneInstance.GetFloorNormal(Point, Normal);
        //}
        public static Boolean OffsetToGeometry(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.OffsetToGeometry();
        }
        public static Boolean DeleteFloorAppearance(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.DeleteFloorAppearance();
        }
        public static Object FloorSelection(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorSelection;
        }
        public static Boolean FloorDirection(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorDirection;
        }
        public static Double FloorOffset(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorOffset;
        }
        public static Boolean FloorOffsetDirection(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorOffsetDirection;
        }
        public static Double FloorRotation(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorRotation;
        }
        public static Double EnvironmentRotation(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.EnvironmentRotation;
        }
        public static Int32 BackgroundType(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.BackgroundType;
        }
        public static Int32 BackgroundTopGradientColor(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.BackgroundTopGradientColor;
        }
        public static Int32 BackgroundBottomGradientColor(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.BackgroundBottomGradientColor;
        }
        public static String BackgroundImage(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.BackgroundImage;
        }
        public static String BackgroundEnvImage(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.BackgroundEnvImage;
        }
        public static Boolean FloorReflections(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorReflections;
        }
        public static Boolean FloorShadows(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorShadows;
        }
        public static Boolean FlattenFloor(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FlattenFloor;
        }
        public static Boolean FitToSWWindow(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FitToSWWindow;
        }
        public static Boolean FixedAspectRatio(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FixedAspectRatio;
        }
        public static Boolean FloorAutoSize(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorAutoSize;
        }
        public static Boolean KeepBackground(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.KeepBackground;
        }
        public static Int32 FloorAlignment(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorAlignment;
        }
        public static Double EnvironmentSize(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.EnvironmentSize;
        }
        public static Double HorizonHeight(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.HorizonHeight;
        }
        public static Boolean AccurateEnvLighting(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.AccurateEnvLighting;
        }
        public static Double BackgroundBrightness(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.BackgroundBrightness;
        }
        public static Double RenderingBrightness(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.RenderingBrightness;
        }
        public static Double SceneReflectivity(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.SceneReflectivity;
        }
        public static Double FloorWidth(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorWidth;
        }
        public static Double FloorDepth(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.FloorDepth;
        }
        public static Double AspectRatio(ISwSceneObject ISwSceneinstance)
        {
            return ISwSceneinstance.ISwSceneInstance.AspectRatio;
        }
    }
}
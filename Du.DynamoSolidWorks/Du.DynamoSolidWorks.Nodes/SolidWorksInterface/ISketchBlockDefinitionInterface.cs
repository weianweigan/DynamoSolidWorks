using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchBlockDefinitionObject
    {
        public ISketchBlockDefinition ISketchBlockDefinitionInstance { get; set; }
        public ISketchBlockDefinitionObject(ISketchBlockDefinition ISketchBlockDefinitioninstance)
        {
            ISketchBlockDefinitionInstance = ISketchBlockDefinitioninstance;
        }
    }
    public static class ISketchBlockDefinitionInterface
    {
        public static IFeatureObject GetFeature(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return new IFeatureObject(ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetFeature());
        }
        public static ISketchObject GetSketch(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return new ISketchObject(ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetSketch());
        }
        public static Int32 GetInstanceCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetInstanceCount();
        }
        public static Object GetInstances(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetInstances();
        }
        public static ISketchBlockInstanceObject IGetInstances(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 Count)
        {
            return new ISketchBlockInstanceObject(ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetInstances(Count));
        }
        public static Int32 GetLineCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetLineCount();
        }
        public static Object GetLines(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetLines();
        }
        public static Double IGetLines(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetLines(ArraySize);
        }
        public static Int32 GetArcCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetArcCount();
        }
        public static Object GetArcs(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetArcs();
        }
        public static Double IGetArcs(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetArcs(ArraySize);
        }
        public static Int32 GetEllipseCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetEllipseCount();
        }
        public static Object GetEllipses(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetEllipses();
        }
        public static Double IGetEllipses(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetEllipses(ArraySize);
        }
        public static Int32 GetParabolaCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetParabolaCount();
        }
        public static Object GetParabolas(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetParabolas();
        }
        public static Double IGetParabolas(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetParabolas(ArraySize);
        }
        //public static Int32 GetSplineCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32& PointCount)
        //{
        //    return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetSplineCount(PointCount);
        //}
        public static Object GetSplines(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetSplines();
        }
        public static Double IGetSplines(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetSplines(ArraySize);
        }
        public static Int32 GetUserPointsCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetUserPointsCount();
        }
        public static Object GetUserPoints(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetUserPoints();
        }
        public static Double IGetUserPoints(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetUserPoints(ArraySize);
        }
        public static Int32 GetNoteCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetNoteCount();
        }
        public static Object GetNotes(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetNotes();
        }
        public static INoteObject IGetNotes(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 Count)
        {
            return new INoteObject(ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetNotes(Count));
        }
        public static Int32 GetDisplayDimensionCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetDisplayDimensionCount();
        }
        public static Object GetDisplayDimensions(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetDisplayDimensions();
        }
        public static IDisplayDimensionObject IGetDisplayDimensions(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 Count)
        {
            return new IDisplayDimensionObject(ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetDisplayDimensions(Count));
        }
        public static Boolean Save(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, String FileName)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.Save(FileName);
        }
        public static Object GetSplines2(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetSplines2();
        }
        public static Double IGetSplines2(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetSplines2(ArraySize);
        }
        //public static Int32 GetSplineParamsCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32& ArraySize)
        //{
        //    return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetSplineParamsCount(ArraySize);
        //}
        public static Object GetSplineParams(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetSplineParams();
        }
        public static Double IGetSplineParams(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetSplineParams(ArraySize);
        }
        //public static Int32 GetSplineInterpolateCount(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32& ArraySize)
        //{
        //    return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetSplineInterpolateCount(ArraySize);
        //}
        public static Object GetSplinesInterpolate(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.GetSplinesInterpolate();
        }
        public static Double IGetSplinesInterpolate(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance, Int32 ArraySize)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.IGetSplinesInterpolate(ArraySize);
        }
        public static IMathPointObject InsertionPoint(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return new IMathPointObject(ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.InsertionPoint);
        }
        public static Boolean LinkToFile(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.LinkToFile;
        }
        public static String FileName(ISketchBlockDefinitionObject ISketchBlockDefinitioninstance)
        {
            return ISketchBlockDefinitioninstance.ISketchBlockDefinitionInstance.FileName;
        }
    }
}
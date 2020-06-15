using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITitleBlockObject
    {
        public ITitleBlock ITitleBlockInstance { get; set; }
        public ITitleBlockObject(ITitleBlock ITitleBlockinstance)
        {
            ITitleBlockInstance = ITitleBlockinstance;
        }
    }
    public static class ITitleBlockInterface
    {
        public static IFeatureObject GetFeature(ITitleBlockObject ITitleBlockinstance)
        {
            return new IFeatureObject(ITitleBlockinstance.ITitleBlockInstance.GetFeature());
        }
        public static Int32 GetNoteCount(ITitleBlockObject ITitleBlockinstance)
        {
            return ITitleBlockinstance.ITitleBlockInstance.GetNoteCount();
        }
        public static Object GetNotes(ITitleBlockObject ITitleBlockinstance)
        {
            return ITitleBlockinstance.ITitleBlockInstance.GetNotes();
        }
        public static INoteObject IGetNotes(ITitleBlockObject ITitleBlockinstance, Int32 Count)
        {
            return new INoteObject(ITitleBlockinstance.ITitleBlockInstance.IGetNotes(Count));
        }
        //public static void GetExtents(ITitleBlockObject ITitleBlockinstance, Double& XUpperLeft, Double& YUpperLeft, Double& XLowerRight, Double& YLowerRight)
        //{
        //    return ITitleBlockinstance.ITitleBlockInstance.GetExtents(XUpperLeft, YUpperLeft, XLowerRight, YLowerRight);
        //}
        public static void SetExtents(ITitleBlockObject ITitleBlockinstance, Double XUpperLeft, Double YUpperLeft, Double XLowerRight, Double YLowerRight)
        {
            ITitleBlockinstance.ITitleBlockInstance.SetExtents(XUpperLeft, YUpperLeft, XLowerRight, YLowerRight);
        }
    }
}
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISelectDataObject
    {
        public ISelectData ISelectDataInstance { get; set; }
        public ISelectDataObject(ISelectData ISelectDatainstance)
        {
            ISelectDataInstance = ISelectDatainstance;
        }
    }
    public static class ISelectDataInterface
    {
        //public static void GetCellRange(ISelectDataObject ISelectDatainstance, Int32& FirstRow, Int32& LastRow, Int32& FirstColumn, Int32& LastColumn)
        //{
        //    return ISelectDatainstance.ISelectDataInstance.GetCellRange(FirstRow, LastRow, FirstColumn, LastColumn);
        //}
        public static void SetCellRange(ISelectDataObject ISelectDatainstance, Int32 FirstRow, Int32 LastRow, Int32 FirstColumn, Int32 LastColumn)
        {
            ISelectDatainstance.ISelectDataInstance.SetCellRange(FirstRow, LastRow, FirstColumn, LastColumn);
        }
        public static Double X(ISelectDataObject ISelectDatainstance)
        {
            return ISelectDatainstance.ISelectDataInstance.X;
        }
        public static Double Y(ISelectDataObject ISelectDatainstance)
        {
            return ISelectDatainstance.ISelectDataInstance.Y;
        }
        public static Double Z(ISelectDataObject ISelectDatainstance)
        {
            return ISelectDatainstance.ISelectDataInstance.Z;
        }
        public static Int32 Mark(ISelectDataObject ISelectDatainstance)
        {
            return ISelectDatainstance.ISelectDataInstance.Mark;
        }
        public static IViewObject View(ISelectDataObject ISelectDatainstance)
        {
            return new IViewObject(ISelectDatainstance.ISelectDataInstance.View);
        }
        public static ICalloutObject Callout(ISelectDataObject ISelectDatainstance)
        {
            return new ICalloutObject(ISelectDatainstance.ISelectDataInstance.Callout);
        }
    }
}
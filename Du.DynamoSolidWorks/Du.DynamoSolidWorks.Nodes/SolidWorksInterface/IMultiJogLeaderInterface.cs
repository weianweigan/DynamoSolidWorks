using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMultiJogLeaderObject
    {
        public IMultiJogLeader IMultiJogLeaderInstance { get; set; }
        public IMultiJogLeaderObject(IMultiJogLeader IMultiJogLeaderinstance)
        {
            IMultiJogLeaderInstance = IMultiJogLeaderinstance;
        }
    }
    public static class IMultiJogLeaderInterface
    {
        public static Object GetNext(IMultiJogLeaderObject IMultiJogLeaderinstance)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.GetNext();
        }
        public static IMultiJogLeaderObject IGetNext(IMultiJogLeaderObject IMultiJogLeaderinstance)
        {
            return new IMultiJogLeaderObject(IMultiJogLeaderinstance.IMultiJogLeaderInstance.IGetNext());
        }
        public static Int32 GetLineCount(IMultiJogLeaderObject IMultiJogLeaderinstance)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(IMultiJogLeaderObject IMultiJogLeaderinstance, Int32 Index)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(IMultiJogLeaderObject IMultiJogLeaderinstance, Int32 Index)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(IMultiJogLeaderObject IMultiJogLeaderinstance)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(IMultiJogLeaderObject IMultiJogLeaderinstance, Int32 Index)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(IMultiJogLeaderObject IMultiJogLeaderinstance, Int32 Index)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Object GetAnnotation(IMultiJogLeaderObject IMultiJogLeaderinstance)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(IMultiJogLeaderObject IMultiJogLeaderinstance)
        {
            return new IAnnotationObject(IMultiJogLeaderinstance.IMultiJogLeaderInstance.IGetAnnotation());
        }
        public static Object GetDisplayData(IMultiJogLeaderObject IMultiJogLeaderinstance)
        {
            return IMultiJogLeaderinstance.IMultiJogLeaderInstance.GetDisplayData();
        }
        public static IDisplayDataObject IGetDisplayData(IMultiJogLeaderObject IMultiJogLeaderinstance)
        {
            return new IDisplayDataObject(IMultiJogLeaderinstance.IMultiJogLeaderInstance.IGetDisplayData());
        }
    }
}
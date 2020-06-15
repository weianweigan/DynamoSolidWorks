using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDiagnoseResultObject
    {
        public IDiagnoseResult IDiagnoseResultInstance { get; set; }
        public IDiagnoseResultObject(IDiagnoseResult IDiagnoseResultinstance)
        {
            IDiagnoseResultInstance = IDiagnoseResultinstance;
        }
    }
    public static class IDiagnoseResultInterface
    {
        public static Int32 GetGapsCount(IDiagnoseResultObject IDiagnoseResultinstance)
        {
            return IDiagnoseResultinstance.IDiagnoseResultInstance.GetGapsCount();
        }
        public static Int32 GetCoEdgesCountAtGap(IDiagnoseResultObject IDiagnoseResultinstance, Int32 Index)
        {
            return IDiagnoseResultinstance.IDiagnoseResultInstance.GetCoEdgesCountAtGap(Index);
        }
        public static ICoEdgeObject IGetCoEdgesAtGap(IDiagnoseResultObject IDiagnoseResultinstance, Int32 Index, Int32 CoEdgeCount)
        {
            return new ICoEdgeObject(IDiagnoseResultinstance.IDiagnoseResultInstance.IGetCoEdgesAtGap(Index, CoEdgeCount));
        }
        public static Object GetCoEdgesAtGap(IDiagnoseResultObject IDiagnoseResultinstance, Int32 Index)
        {
            return IDiagnoseResultinstance.IDiagnoseResultInstance.GetCoEdgesAtGap(Index);
        }
    }
}
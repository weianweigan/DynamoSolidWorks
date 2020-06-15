using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using SolidWorks.Interop.swconst;
using DynamoSolidWorks;
using Du.SolidWorks.Extension;
using Autodesk.DesignScript.Runtime;
using Du.DynamoSolidWorks.Nodes;

namespace DynamoSolidWorks
{
    public class IEnumCurvesObject
    {
        public IEnumCurves IEnumCurvesInstance { get; set; }
        public IEnumCurvesObject(IEnumCurves IEnumCurvesinstance)
        {
            IEnumCurvesInstance = IEnumCurvesinstance;
        }
    }
    public static class IEnumCurvesInterface
    {
        //public static void Next(IEnumCurvesObject IEnumCurvesinstance, Int32 Celt, Curve&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumCurvesinstance.IEnumCurvesInstance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumCurvesObject IEnumCurvesinstance, Int32 Celt)
        {
            IEnumCurvesinstance.IEnumCurvesInstance.Skip(Celt);
        }
        public static void Reset(IEnumCurvesObject IEnumCurvesinstance)
        {
            IEnumCurvesinstance.IEnumCurvesInstance.Reset();
        }
        //public static void Clone(IEnumCurvesObject IEnumCurvesinstance, EnumCurves&Object Ppenum)
        //{
        //    return IEnumCurvesinstance.IEnumCurvesInstance.Clone(Ppenum);
        //}
    }
}
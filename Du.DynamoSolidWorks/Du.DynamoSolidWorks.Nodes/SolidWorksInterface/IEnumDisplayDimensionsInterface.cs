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
    public class IEnumDisplayDimensionsObject
    {
        public IEnumDisplayDimensions IEnumDisplayDimensionsInstance { get; set; }
        public IEnumDisplayDimensionsObject(IEnumDisplayDimensions IEnumDisplayDimensionsinstance)
        {
            IEnumDisplayDimensionsInstance = IEnumDisplayDimensionsinstance;
        }
    }
    public static class IEnumDisplayDimensionsInterface
    {
        //public static void Next(IEnumDisplayDimensionsObject IEnumDisplayDimensionsinstance, Int32 Celt, DisplayDimension&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumDisplayDimensionsinstance.IEnumDisplayDimensionsInstance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumDisplayDimensionsObject IEnumDisplayDimensionsinstance, Int32 Celt)
        {
            IEnumDisplayDimensionsinstance.IEnumDisplayDimensionsInstance.Skip(Celt);
        }
        public static void Reset(IEnumDisplayDimensionsObject IEnumDisplayDimensionsinstance)
        {
            IEnumDisplayDimensionsinstance.IEnumDisplayDimensionsInstance.Reset();
        }
        //public static void Clone(IEnumDisplayDimensionsObject IEnumDisplayDimensionsinstance, EnumDisplayDimensions&Object Ppenum)
        //{
        //    return IEnumDisplayDimensionsinstance.IEnumDisplayDimensionsInstance.Clone(Ppenum);
        //}
    }
}
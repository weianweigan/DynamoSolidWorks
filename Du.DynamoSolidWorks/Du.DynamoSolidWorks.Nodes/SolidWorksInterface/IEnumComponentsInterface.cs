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
    public class IEnumComponentsObject
    {
        public IEnumComponents IEnumComponentsInstance { get; set; }
        public IEnumComponentsObject(IEnumComponents IEnumComponentsinstance)
        {
            IEnumComponentsInstance = IEnumComponentsinstance;
        }
    }
    public static class IEnumComponentsInterface
    {
        //public static void Next(IEnumComponentsObject IEnumComponentsinstance, Int32 Celt, Component&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumComponentsinstance.IEnumComponentsInstance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumComponentsObject IEnumComponentsinstance, Int32 Celt)
        {
            IEnumComponentsinstance.IEnumComponentsInstance.Skip(Celt);
        }
        public static void Reset(IEnumComponentsObject IEnumComponentsinstance)
        {
            IEnumComponentsinstance.IEnumComponentsInstance.Reset();
        }
        //public static void Clone(IEnumComponentsObject IEnumComponentsinstance, EnumComponents&Object Ppenum)
        //{
        //    return IEnumComponentsinstance.IEnumComponentsInstance.Clone(Ppenum);
        //}
    }
}
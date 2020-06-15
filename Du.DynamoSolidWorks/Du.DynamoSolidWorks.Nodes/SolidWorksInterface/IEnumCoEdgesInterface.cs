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
    public class IEnumCoEdgesObject
    {
        public IEnumCoEdges IEnumCoEdgesInstance { get; set; }
        public IEnumCoEdgesObject(IEnumCoEdges IEnumCoEdgesinstance)
        {
            IEnumCoEdgesInstance = IEnumCoEdgesinstance;
        }
    }
    public static class IEnumCoEdgesInterface
    {
        //public static void Next(IEnumCoEdgesObject IEnumCoEdgesinstance, Int32 Celt, CoEdge&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumCoEdgesinstance.IEnumCoEdgesInstance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumCoEdgesObject IEnumCoEdgesinstance, Int32 Celt)
        {
            IEnumCoEdgesinstance.IEnumCoEdgesInstance.Skip(Celt);
        }
        public static void Reset(IEnumCoEdgesObject IEnumCoEdgesinstance)
        {
            IEnumCoEdgesinstance.IEnumCoEdgesInstance.Reset();
        }
        //public static void Clone(IEnumCoEdgesObject IEnumCoEdgesinstance, EnumCoEdges&Object Ppenum)
        //{
        //    return IEnumCoEdgesinstance.IEnumCoEdgesInstance.Clone(Ppenum);
        //}
    }
}
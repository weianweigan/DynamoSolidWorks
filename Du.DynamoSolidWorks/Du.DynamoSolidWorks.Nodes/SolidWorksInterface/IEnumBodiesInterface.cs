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
    public class IEnumBodiesObject
    {
        public IEnumBodies IEnumBodiesInstance { get; set; }
        public IEnumBodiesObject(IEnumBodies IEnumBodiesinstance)
        {
            IEnumBodiesInstance = IEnumBodiesinstance;
        }
    }
    public static class IEnumBodiesInterface
    {
        //public static void Next(IEnumBodiesObject IEnumBodiesinstance, Int32 Celt, Body&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumBodiesinstance.IEnumBodiesInstance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumBodiesObject IEnumBodiesinstance, Int32 Celt)
        {
             IEnumBodiesinstance.IEnumBodiesInstance.Skip(Celt);
        }
        public static void Reset(IEnumBodiesObject IEnumBodiesinstance)
        {
             IEnumBodiesinstance.IEnumBodiesInstance.Reset();
        }
        public static IEnumBodiesObject Clone(IEnumBodiesObject IEnumBodiesinstance)
        {
            IEnumBodiesinstance.IEnumBodiesInstance.Clone(out EnumBodies Ppenum);
            return new IEnumBodiesObject(Ppenum);
        }
    }
}
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
    public class IEnumBodies2Object
    {
        public IEnumBodies2 IEnumBodies2Instance { get; set; }
        public IEnumBodies2Object(IEnumBodies2 IEnumBodies2instance)
        {
            IEnumBodies2Instance = IEnumBodies2instance;
        }
    }
    public static class IEnumBodies2Interface
    {
        //public static void Next(IEnumBodies2Object IEnumBodies2instance, Int32 Celt, Body2&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumBodies2instance.IEnumBodies2Instance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumBodies2Object IEnumBodies2instance, Int32 Celt)
        {
            IEnumBodies2instance.IEnumBodies2Instance.Skip(Celt);
        }
        public static void Reset(IEnumBodies2Object IEnumBodies2instance)
        {
            IEnumBodies2instance.IEnumBodies2Instance.Reset();
        }
        //public static void Clone(IEnumBodies2Object IEnumBodies2instance, EnumBodies2&Object Ppenum)
        //{
        //    return IEnumBodies2instance.IEnumBodies2Instance.Clone(Ppenum);
        //}
    }
}
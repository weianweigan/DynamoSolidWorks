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
    public class IEnumComponents2Object
    {
        public IEnumComponents2 IEnumComponents2Instance { get; set; }
        public IEnumComponents2Object(IEnumComponents2 IEnumComponents2instance)
        {
            IEnumComponents2Instance = IEnumComponents2instance;
        }
    }
    public static class IEnumComponents2Interface
    {
        //public static void Next(IEnumComponents2Object IEnumComponents2instance, Int32 Celt, Component2&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumComponents2instance.IEnumComponents2Instance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumComponents2Object IEnumComponents2instance, Int32 Celt)
        {
            IEnumComponents2instance.IEnumComponents2Instance.Skip(Celt);
        }
        public static void Reset(IEnumComponents2Object IEnumComponents2instance)
        {
            IEnumComponents2instance.IEnumComponents2Instance.Reset();
        }
        //public static void Clone(IEnumComponents2Object IEnumComponents2instance, EnumComponents2&Object Ppenum)
        //{
        //    return IEnumComponents2instance.IEnumComponents2Instance.Clone(Ppenum);
        //}
    }
}
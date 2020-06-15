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
    public class IEnumDocuments2Object
    {
        public IEnumDocuments2 IEnumDocuments2Instance { get; set; }
        public IEnumDocuments2Object(IEnumDocuments2 IEnumDocuments2instance)
        {
            IEnumDocuments2Instance = IEnumDocuments2instance;
        }
    }
    public static class IEnumDocuments2Interface
    {
        //public static void Next(IEnumDocuments2Object IEnumDocuments2instance, Int32 Celt, ModelDoc2&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumDocuments2instance.IEnumDocuments2Instance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumDocuments2Object IEnumDocuments2instance, Int32 Celt)
        {
            IEnumDocuments2instance.IEnumDocuments2Instance.Skip(Celt);
        }
        public static void Reset(IEnumDocuments2Object IEnumDocuments2instance)
        {
            IEnumDocuments2instance.IEnumDocuments2Instance.Reset();
        }
        //public static void Clone(IEnumDocuments2Object IEnumDocuments2instance, EnumDocuments2&Object Ppenum)
        //{
        //    return IEnumDocuments2instance.IEnumDocuments2Instance.Clone(Ppenum);
        //}
    }
}
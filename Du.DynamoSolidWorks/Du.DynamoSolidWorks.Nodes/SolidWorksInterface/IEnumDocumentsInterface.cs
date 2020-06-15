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
    public class IEnumDocumentsObject
    {
        public IEnumDocuments IEnumDocumentsInstance { get; set; }
        public IEnumDocumentsObject(IEnumDocuments IEnumDocumentsinstance)
        {
            IEnumDocumentsInstance = IEnumDocumentsinstance;
        }
    }
    public static class IEnumDocumentsInterface
    {
        //public static void Next(IEnumDocumentsObject IEnumDocumentsinstance, Int32 Celt, ModelDoc&Object Rgelt, Int32& PceltFetched)
        //{
        //    return IEnumDocumentsinstance.IEnumDocumentsInstance.Next(Celt, Rgelt, PceltFetched);
        //}
        public static void Skip(IEnumDocumentsObject IEnumDocumentsinstance, Int32 Celt)
        {
            IEnumDocumentsinstance.IEnumDocumentsInstance.Skip(Celt);
        }
        public static void Reset(IEnumDocumentsObject IEnumDocumentsinstance)
        {
            IEnumDocumentsinstance.IEnumDocumentsInstance.Reset();
        }
        //public static void Clone(IEnumDocumentsObject IEnumDocumentsinstance, EnumDocuments&Object Ppenum)
        //{
        //    return IEnumDocumentsinstance.IEnumDocumentsInstance.Clone(Ppenum);
        //}
    }
}
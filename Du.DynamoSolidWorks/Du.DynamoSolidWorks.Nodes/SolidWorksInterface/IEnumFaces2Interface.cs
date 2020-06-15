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
   public class IEnumFaces2Object
    {
         public IEnumFaces2 IEnumFaces2Instance { get; set; }
        public IEnumFaces2Object(IEnumFaces2 IEnumFaces2instance)
        {
                IEnumFaces2Instance = IEnumFaces2instance;
        }
    }
   public static class IEnumFaces2Interface
   {
  public static void Next(IEnumFaces2Object IEnumFaces2instance,Int32 Celt,Face2&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumFaces2instance.IEnumFaces2Instance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumFaces2Object IEnumFaces2instance,Int32 Celt)
     {
            return IEnumFaces2instance.IEnumFaces2Instance.Skip(Celt);
       }
  public static void Reset(IEnumFaces2Object IEnumFaces2instance)
     {
            return IEnumFaces2instance.IEnumFaces2Instance.Reset();
       }
  public static void Clone(IEnumFaces2Object IEnumFaces2instance,EnumFaces2&Object Ppenum)
     {
            return IEnumFaces2instance.IEnumFaces2Instance.Clone(Ppenum);
       }
    }
}
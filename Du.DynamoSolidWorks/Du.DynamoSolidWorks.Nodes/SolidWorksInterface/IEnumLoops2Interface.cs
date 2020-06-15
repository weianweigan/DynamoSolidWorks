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
   public class IEnumLoops2Object
    {
         public IEnumLoops2 IEnumLoops2Instance { get; set; }
        public IEnumLoops2Object(IEnumLoops2 IEnumLoops2instance)
        {
                IEnumLoops2Instance = IEnumLoops2instance;
        }
    }
   public static class IEnumLoops2Interface
   {
  public static void Next(IEnumLoops2Object IEnumLoops2instance,Int32 Celt,Loop2&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumLoops2instance.IEnumLoops2Instance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumLoops2Object IEnumLoops2instance,Int32 Celt)
     {
            return IEnumLoops2instance.IEnumLoops2Instance.Skip(Celt);
       }
  public static void Reset(IEnumLoops2Object IEnumLoops2instance)
     {
            return IEnumLoops2instance.IEnumLoops2Instance.Reset();
       }
  public static void Clone(IEnumLoops2Object IEnumLoops2instance,EnumLoops2&Object Ppenum)
     {
            return IEnumLoops2instance.IEnumLoops2Instance.Clone(Ppenum);
       }
    }
}
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
   public class IEnumLoopsObject
    {
         public IEnumLoops IEnumLoopsInstance { get; set; }
        public IEnumLoopsObject(IEnumLoops IEnumLoopsinstance)
        {
                IEnumLoopsInstance = IEnumLoopsinstance;
        }
    }
   public static class IEnumLoopsInterface
   {
  public static void Next(IEnumLoopsObject IEnumLoopsinstance,Int32 Celt,Loop&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumLoopsinstance.IEnumLoopsInstance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumLoopsObject IEnumLoopsinstance,Int32 Celt)
     {
            return IEnumLoopsinstance.IEnumLoopsInstance.Skip(Celt);
       }
  public static void Reset(IEnumLoopsObject IEnumLoopsinstance)
     {
            return IEnumLoopsinstance.IEnumLoopsInstance.Reset();
       }
  public static void Clone(IEnumLoopsObject IEnumLoopsinstance,EnumLoops&Object Ppenum)
     {
            return IEnumLoopsinstance.IEnumLoopsInstance.Clone(Ppenum);
       }
    }
}
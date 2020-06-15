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
   public class IEnumEdgesObject
    {
         public IEnumEdges IEnumEdgesInstance { get; set; }
        public IEnumEdgesObject(IEnumEdges IEnumEdgesinstance)
        {
                IEnumEdgesInstance = IEnumEdgesinstance;
        }
    }
   public static class IEnumEdgesInterface
   {
  public static void Next(IEnumEdgesObject IEnumEdgesinstance,Int32 Celt,Edge&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumEdgesinstance.IEnumEdgesInstance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumEdgesObject IEnumEdgesinstance,Int32 Celt)
     {
            return IEnumEdgesinstance.IEnumEdgesInstance.Skip(Celt);
       }
  public static void Reset(IEnumEdgesObject IEnumEdgesinstance)
     {
            return IEnumEdgesinstance.IEnumEdgesInstance.Reset();
       }
  public static void Clone(IEnumEdgesObject IEnumEdgesinstance,EnumEdges&Object Ppenum)
     {
            return IEnumEdgesinstance.IEnumEdgesInstance.Clone(Ppenum);
       }
    }
}
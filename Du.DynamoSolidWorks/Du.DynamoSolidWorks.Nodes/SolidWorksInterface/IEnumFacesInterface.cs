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
   public class IEnumFacesObject
    {
         public IEnumFaces IEnumFacesInstance { get; set; }
        public IEnumFacesObject(IEnumFaces IEnumFacesinstance)
        {
                IEnumFacesInstance = IEnumFacesinstance;
        }
    }
   public static class IEnumFacesInterface
   {
  public static void Next(IEnumFacesObject IEnumFacesinstance,Int32 Celt,Face&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumFacesinstance.IEnumFacesInstance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumFacesObject IEnumFacesinstance,Int32 Celt)
     {
            return IEnumFacesinstance.IEnumFacesInstance.Skip(Celt);
       }
  public static void Reset(IEnumFacesObject IEnumFacesinstance)
     {
            return IEnumFacesinstance.IEnumFacesInstance.Reset();
       }
  public static void Clone(IEnumFacesObject IEnumFacesinstance,EnumFaces&Object Ppenum)
     {
            return IEnumFacesinstance.IEnumFacesInstance.Clone(Ppenum);
       }
    }
}
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
   public class IEnumModelViewsObject
    {
         public IEnumModelViews IEnumModelViewsInstance { get; set; }
        public IEnumModelViewsObject(IEnumModelViews IEnumModelViewsinstance)
        {
                IEnumModelViewsInstance = IEnumModelViewsinstance;
        }
    }
   public static class IEnumModelViewsInterface
   {
  public static void Next(IEnumModelViewsObject IEnumModelViewsinstance,Int32 Celt,ModelView&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumModelViewsinstance.IEnumModelViewsInstance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumModelViewsObject IEnumModelViewsinstance,Int32 Celt)
     {
            return IEnumModelViewsinstance.IEnumModelViewsInstance.Skip(Celt);
       }
  public static void Reset(IEnumModelViewsObject IEnumModelViewsinstance)
     {
            return IEnumModelViewsinstance.IEnumModelViewsInstance.Reset();
       }
  public static void Clone(IEnumModelViewsObject IEnumModelViewsinstance,EnumModelViews&Object Ppenum)
     {
            return IEnumModelViewsinstance.IEnumModelViewsInstance.Clone(Ppenum);
       }
    }
}
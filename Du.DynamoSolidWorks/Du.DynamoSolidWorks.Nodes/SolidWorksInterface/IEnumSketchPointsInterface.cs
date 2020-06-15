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
   public class IEnumSketchPointsObject
    {
         public IEnumSketchPoints IEnumSketchPointsInstance { get; set; }
        public IEnumSketchPointsObject(IEnumSketchPoints IEnumSketchPointsinstance)
        {
                IEnumSketchPointsInstance = IEnumSketchPointsinstance;
        }
    }
   public static class IEnumSketchPointsInterface
   {
  public static void Next(IEnumSketchPointsObject IEnumSketchPointsinstance,Int32 Celt,SketchPoint&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumSketchPointsinstance.IEnumSketchPointsInstance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumSketchPointsObject IEnumSketchPointsinstance,Int32 Celt)
     {
            return IEnumSketchPointsinstance.IEnumSketchPointsInstance.Skip(Celt);
       }
  public static void Reset(IEnumSketchPointsObject IEnumSketchPointsinstance)
     {
            return IEnumSketchPointsinstance.IEnumSketchPointsInstance.Reset();
       }
  public static void Clone(IEnumSketchPointsObject IEnumSketchPointsinstance,EnumSketchPoints&Object Ppenum)
     {
            return IEnumSketchPointsinstance.IEnumSketchPointsInstance.Clone(Ppenum);
       }
    }
}
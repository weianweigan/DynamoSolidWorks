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
   public class IEnumSketchHatchesObject
    {
         public IEnumSketchHatches IEnumSketchHatchesInstance { get; set; }
        public IEnumSketchHatchesObject(IEnumSketchHatches IEnumSketchHatchesinstance)
        {
                IEnumSketchHatchesInstance = IEnumSketchHatchesinstance;
        }
    }
   public static class IEnumSketchHatchesInterface
   {
  public static void Next(IEnumSketchHatchesObject IEnumSketchHatchesinstance,Int32 Celt,SketchHatch&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumSketchHatchesinstance.IEnumSketchHatchesInstance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumSketchHatchesObject IEnumSketchHatchesinstance,Int32 Celt)
     {
            return IEnumSketchHatchesinstance.IEnumSketchHatchesInstance.Skip(Celt);
       }
  public static void Reset(IEnumSketchHatchesObject IEnumSketchHatchesinstance)
     {
            return IEnumSketchHatchesinstance.IEnumSketchHatchesInstance.Reset();
       }
  public static void Clone(IEnumSketchHatchesObject IEnumSketchHatchesinstance,EnumSketchHatches&Object Ppenum)
     {
            return IEnumSketchHatchesinstance.IEnumSketchHatchesInstance.Clone(Ppenum);
       }
    }
}
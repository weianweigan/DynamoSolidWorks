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
   public class IEnumSketchSegmentsObject
    {
         public IEnumSketchSegments IEnumSketchSegmentsInstance { get; set; }
        public IEnumSketchSegmentsObject(IEnumSketchSegments IEnumSketchSegmentsinstance)
        {
                IEnumSketchSegmentsInstance = IEnumSketchSegmentsinstance;
        }
    }
   public static class IEnumSketchSegmentsInterface
   {
  public static void Next(IEnumSketchSegmentsObject IEnumSketchSegmentsinstance,Int32 Celt,SketchSegment&Object Rgelt,Int32& PceltFetched)
     {
            return IEnumSketchSegmentsinstance.IEnumSketchSegmentsInstance.Next(Celt,Rgelt,PceltFetched);
       }
  public static void Skip(IEnumSketchSegmentsObject IEnumSketchSegmentsinstance,Int32 Celt)
     {
            return IEnumSketchSegmentsinstance.IEnumSketchSegmentsInstance.Skip(Celt);
       }
  public static void Reset(IEnumSketchSegmentsObject IEnumSketchSegmentsinstance)
     {
            return IEnumSketchSegmentsinstance.IEnumSketchSegmentsInstance.Reset();
       }
  public static void Clone(IEnumSketchSegmentsObject IEnumSketchSegmentsinstance,EnumSketchSegments&Object Ppenum)
     {
            return IEnumSketchSegmentsinstance.IEnumSketchSegmentsInstance.Clone(Ppenum);
       }
    }
}
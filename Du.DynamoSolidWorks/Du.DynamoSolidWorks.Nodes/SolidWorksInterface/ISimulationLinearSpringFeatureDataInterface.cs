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
   public class ISimulationLinearSpringFeatureDataObject
    {
         public ISimulationLinearSpringFeatureData ISimulationLinearSpringFeatureDataInstance { get; set; }
        public ISimulationLinearSpringFeatureDataObject(ISimulationLinearSpringFeatureData ISimulationLinearSpringFeatureDatainstance)
        {
                ISimulationLinearSpringFeatureDataInstance = ISimulationLinearSpringFeatureDatainstance;
        }
    }
   public static class ISimulationLinearSpringFeatureDataInterface
   {
  public static void GetEndPoints(ISimulationLinearSpringFeatureDataObject ISimulationLinearSpringFeatureDatainstance,Object& PDirDisp1,Object& PDirDisp2,Int32& Type1,Int32& Type2)
     {
            return ISimulationLinearSpringFeatureDatainstance.ISimulationLinearSpringFeatureDataInstance.GetEndPoints(PDirDisp1,PDirDisp2,Type1,Type2);
       }
  public static void SetEndPoints(ISimulationLinearSpringFeatureDataObject ISimulationLinearSpringFeatureDatainstance,Object PDirDisp1,Object PDirDisp2)
     {
            return ISimulationLinearSpringFeatureDatainstance.ISimulationLinearSpringFeatureDataInstance.SetEndPoints(PDirDisp1,PDirDisp2);
       }
  public static Double FreeLength(ISimulationLinearSpringFeatureDataObject ISimulationLinearSpringFeatureDatainstance)
      {
            return ISimulationLinearSpringFeatureDatainstance.ISimulationLinearSpringFeatureDataInstance.FreeLength;
      }
  public static Double SpringConstant(ISimulationLinearSpringFeatureDataObject ISimulationLinearSpringFeatureDatainstance)
      {
            return ISimulationLinearSpringFeatureDatainstance.ISimulationLinearSpringFeatureDataInstance.SpringConstant;
      }
    }
}
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
   public class ISimulationGravityFeatureDataObject
    {
         public ISimulationGravityFeatureData ISimulationGravityFeatureDataInstance { get; set; }
        public ISimulationGravityFeatureDataObject(ISimulationGravityFeatureData ISimulationGravityFeatureDatainstance)
        {
                ISimulationGravityFeatureDataInstance = ISimulationGravityFeatureDatainstance;
        }
    }
   public static class ISimulationGravityFeatureDataInterface
   {
  public static Object DirectionReference(ISimulationGravityFeatureDataObject ISimulationGravityFeatureDatainstance)
      {
            return ISimulationGravityFeatureDatainstance.ISimulationGravityFeatureDataInstance.DirectionReference;
      }
  public static Boolean ReverseDirection(ISimulationGravityFeatureDataObject ISimulationGravityFeatureDatainstance)
      {
            return ISimulationGravityFeatureDatainstance.ISimulationGravityFeatureDataInstance.ReverseDirection;
      }
  public static Double Strength(ISimulationGravityFeatureDataObject ISimulationGravityFeatureDatainstance)
      {
            return ISimulationGravityFeatureDatainstance.ISimulationGravityFeatureDataInstance.Strength;
      }
  public static Int32 Axis(ISimulationGravityFeatureDataObject ISimulationGravityFeatureDatainstance)
      {
            return ISimulationGravityFeatureDatainstance.ISimulationGravityFeatureDataInstance.Axis;
      }
    }
}
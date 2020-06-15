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
   public class ISimulationDamperFeatureDataObject
    {
         public ISimulationDamperFeatureData ISimulationDamperFeatureDataInstance { get; set; }
        public ISimulationDamperFeatureDataObject(ISimulationDamperFeatureData ISimulationDamperFeatureDatainstance)
        {
                ISimulationDamperFeatureDataInstance = ISimulationDamperFeatureDatainstance;
        }
    }
   public static class ISimulationDamperFeatureDataInterface
   {
  public static Boolean GetEndPoints(ISimulationDamperFeatureDataObject ISimulationDamperFeatureDatainstance,Object& PDirDisp1,Object& PDirDisp2,Int32& Type1,Int32& Type2)
     {
            return ISimulationDamperFeatureDatainstance.ISimulationDamperFeatureDataInstance.GetEndPoints(PDirDisp1,PDirDisp2,Type1,Type2);
       }
  public static Boolean SetEndPoints(ISimulationDamperFeatureDataObject ISimulationDamperFeatureDatainstance,Object PDirDisp1,Object PDirDisp2)
     {
            return ISimulationDamperFeatureDatainstance.ISimulationDamperFeatureDataInstance.SetEndPoints(PDirDisp1,PDirDisp2);
       }
  public static Int32 Type(ISimulationDamperFeatureDataObject ISimulationDamperFeatureDatainstance)
      {
            return ISimulationDamperFeatureDatainstance.ISimulationDamperFeatureDataInstance.Type;
      }
  public static Double DampingConstant(ISimulationDamperFeatureDataObject ISimulationDamperFeatureDatainstance)
      {
            return ISimulationDamperFeatureDatainstance.ISimulationDamperFeatureDataInstance.DampingConstant;
      }
  public static Int32 ExponentOfDamperForceExpression(ISimulationDamperFeatureDataObject ISimulationDamperFeatureDatainstance)
      {
            return ISimulationDamperFeatureDatainstance.ISimulationDamperFeatureDataInstance.ExponentOfDamperForceExpression;
      }
  public static IComponent2Object BaseComponent(ISimulationDamperFeatureDataObject ISimulationDamperFeatureDatainstance)
      {
            return new IComponent2Object(ISimulationDamperFeatureDatainstance.ISimulationDamperFeatureDataInstance.BaseComponent);
      }
  public static Object LoadReferences(ISimulationDamperFeatureDataObject ISimulationDamperFeatureDatainstance)
      {
            return ISimulationDamperFeatureDatainstance.ISimulationDamperFeatureDataInstance.LoadReferences;
      }
    }
}
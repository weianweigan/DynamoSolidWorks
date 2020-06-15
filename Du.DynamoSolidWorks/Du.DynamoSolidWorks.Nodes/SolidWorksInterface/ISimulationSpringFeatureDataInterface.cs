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
   public class ISimulationSpringFeatureDataObject
    {
         public ISimulationSpringFeatureData ISimulationSpringFeatureDataInstance { get; set; }
        public ISimulationSpringFeatureDataObject(ISimulationSpringFeatureData ISimulationSpringFeatureDatainstance)
        {
                ISimulationSpringFeatureDataInstance = ISimulationSpringFeatureDatainstance;
        }
    }
   public static class ISimulationSpringFeatureDataInterface
   {
  public static Boolean GetEndPoints(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance,Object& PDirDisp1,Object& PDirDisp2,Int32& Type1,Int32& Type2)
     {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.GetEndPoints(PDirDisp1,PDirDisp2,Type1,Type2);
       }
  public static Boolean SetEndPoints(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance,Object PDirDisp1,Object PDirDisp2)
     {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.SetEndPoints(PDirDisp1,PDirDisp2);
       }
  public static Double FreeLength(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.FreeLength;
      }
  public static Double SpringConstant(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.SpringConstant;
      }
  public static Int32 Type(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.Type;
      }
  public static Int32 ExponentOfSpringForceExpression(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.ExponentOfSpringForceExpression;
      }
  public static Boolean UpdateToModelChanges(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.UpdateToModelChanges;
      }
  public static Boolean HasDamper(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.HasDamper;
      }
  public static Double DampingConstant(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.DampingConstant;
      }
  public static Int32 ExponentOfDamperForceExpression(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.ExponentOfDamperForceExpression;
      }
  public static Double CoilDiameter(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.CoilDiameter;
      }
  public static Int32 NumberOfCoils(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.NumberOfCoils;
      }
  public static Double WireDiameter(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.WireDiameter;
      }
  public static IComponent2Object BaseComponent(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return new IComponent2Object(ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.BaseComponent);
      }
  public static Boolean ReverseDirection(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.ReverseDirection;
      }
  public static Object LoadReferences(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.LoadReferences;
      }
  public static Double FreeAngle(ISimulationSpringFeatureDataObject ISimulationSpringFeatureDatainstance)
      {
            return ISimulationSpringFeatureDatainstance.ISimulationSpringFeatureDataInstance.FreeAngle;
      }
    }
}
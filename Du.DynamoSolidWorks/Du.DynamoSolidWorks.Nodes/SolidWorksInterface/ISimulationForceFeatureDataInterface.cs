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
   public class ISimulationForceFeatureDataObject
    {
         public ISimulationForceFeatureData ISimulationForceFeatureDataInstance { get; set; }
        public ISimulationForceFeatureDataObject(ISimulationForceFeatureData ISimulationForceFeatureDatainstance)
        {
                ISimulationForceFeatureDataInstance = ISimulationForceFeatureDatainstance;
        }
    }
   public static class ISimulationForceFeatureDataInterface
   {
  public static Boolean GetFunctionStepValues(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance,Double& F1InitialValue,Double& T1StartStepTime,Double& F2InitialValue,Double& T2EndStepTime)
     {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.GetFunctionStepValues(F1InitialValue,T1StartStepTime,F2InitialValue,T2EndStepTime);
       }
  public static Boolean SetFunctionStepValues(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance,Double F1InitialValue,Double T1StartStepTime,Double F2InitialValue,Double T2EndStepTime)
     {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.SetFunctionStepValues(F1InitialValue,T1StartStepTime,F2InitialValue,T2EndStepTime);
       }
  public static Boolean GetFunctionHarmonicValues(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance,Double& Amplitude,Double& Frequency,Double& Average,Double& PhaseShift)
     {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.GetFunctionHarmonicValues(Amplitude,Frequency,Average,PhaseShift);
       }
  public static Boolean SetFunctionHarmonicValues(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance,Double Amplitude,Double Frequency,Double Average,Double PhaseShift)
     {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.SetFunctionHarmonicValues(Amplitude,Frequency,Average,PhaseShift);
       }
  public static Boolean GetEndPoints(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance,Object& PDirDisp1,Object& PDirDisp2,Int32& Type1,Int32& Type2)
     {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.GetEndPoints(PDirDisp1,PDirDisp2,Type1,Type2);
       }
  public static Boolean SetEndPoints(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance,Object PDirDisp1,Object PDirDisp2)
     {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.SetEndPoints(PDirDisp1,PDirDisp2);
       }
  public static Boolean LoadSplineData(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance,String Value)
     {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.LoadSplineData(Value);
       }
  public static Double GetInterpolatedValue(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance,Double Time)
     {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.GetInterpolatedValue(Time);
       }
  public static Int32 ForceType(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ForceType;
      }
  public static Int32 ActionType(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ActionType;
      }
  public static Int32 ForceFunctionType(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ForceFunctionType;
      }
  public static Double FunctionConstantValue(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.FunctionConstantValue;
      }
  public static Object FunctionInterpolatedValues(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.FunctionInterpolatedValues;
      }
  public static String FunctionExpression(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.FunctionExpression;
      }
  public static IComponent2Object ReferenceComponent(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return new IComponent2Object(ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ReferenceComponent);
      }
  public static Boolean ReverseDirection(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ReverseDirection;
      }
  public static Object LoadReferences(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.LoadReferences;
      }
  public static Boolean ExternalState(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ExternalState;
      }
  public static Object ActionLocation(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ActionLocation;
      }
  public static Object ActionDirection(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ActionDirection;
      }
  public static Object ReactionLocation(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.ReactionLocation;
      }
  public static Int32 InterpolationScheme(ISimulationForceFeatureDataObject ISimulationForceFeatureDatainstance)
      {
            return ISimulationForceFeatureDatainstance.ISimulationForceFeatureDataInstance.InterpolationScheme;
      }
    }
}
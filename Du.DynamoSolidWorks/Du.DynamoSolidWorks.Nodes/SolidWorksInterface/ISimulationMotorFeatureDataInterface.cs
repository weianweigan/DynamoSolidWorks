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
   public class ISimulationMotorFeatureDataObject
    {
         public ISimulationMotorFeatureData ISimulationMotorFeatureDataInstance { get; set; }
        public ISimulationMotorFeatureDataObject(ISimulationMotorFeatureData ISimulationMotorFeatureDatainstance)
        {
                ISimulationMotorFeatureDataInstance = ISimulationMotorFeatureDatainstance;
        }
    }
   public static class ISimulationMotorFeatureDataInterface
   {
  public static void ConstantSpeedMotor(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance,Double Speed)
     {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.ConstantSpeedMotor(Speed);
       }
  public static void OscillatingMotor(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance,Double Displacement,Double Frequency)
     {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.OscillatingMotor(Displacement,Frequency);
       }
  public static void DistanceMotor(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance,Double Displacement,Double StartTime,Double Duration)
     {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.DistanceMotor(Displacement,StartTime,Duration);
       }
  public static void InterpolatedMotor(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance,Int32 DriveType,Int32 InterpolationScheme)
     {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.InterpolatedMotor(DriveType,InterpolationScheme);
       }
  public static Boolean LoadSplineData(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance,String Value)
     {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.LoadSplineData(Value);
       }
  public static Double GetInterpolatedValue(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance,Double Time)
     {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.GetInterpolatedValue(Time);
       }
  public static Object DirectionReference(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.DirectionReference;
      }
  public static Boolean ReverseDirection(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.ReverseDirection;
      }
  public static Double Velocity(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.Velocity;
      }
  public static Int32 MotorType(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.MotorType;
      }
  public static Boolean ExternalState(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.ExternalState;
      }
  public static Int32 MotionType(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.MotionType;
      }
  public static Int32 DriveType(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.DriveType;
      }
  public static Object SplineData(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.SplineData;
      }
  public static String Expression(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.Expression;
      }
  public static Int32 InterpolationScheme(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.InterpolationScheme;
      }
  public static Object LoadReferences(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.LoadReferences;
      }
  public static IComponent2Object RelativeComponent(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return new IComponent2Object(ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.RelativeComponent);
      }
  public static Object Location(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.Location;
      }
  public static Double Magnitude(ISimulationMotorFeatureDataObject ISimulationMotorFeatureDatainstance)
      {
            return ISimulationMotorFeatureDatainstance.ISimulationMotorFeatureDataInstance.Magnitude;
      }
    }
}
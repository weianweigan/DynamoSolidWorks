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
   public class ISimulation3DContactFeatureDataObject
    {
         public ISimulation3DContactFeatureData ISimulation3DContactFeatureDataInstance { get; set; }
        public ISimulation3DContactFeatureDataObject(ISimulation3DContactFeatureData ISimulation3DContactFeatureDatainstance)
        {
                ISimulation3DContactFeatureDataInstance = ISimulation3DContactFeatureDatainstance;
        }
    }
   public static class ISimulation3DContactFeatureDataInterface
   {
  public static Boolean SpecifyMaterial(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.SpecifyMaterial;
      }
  public static Int32 MaterialID(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.MaterialID;
      }
  public static Boolean UseRestitutionCoefficient(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.UseRestitutionCoefficient;
      }
  public static Double RestitutionCoefficient(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.RestitutionCoefficient;
      }
  public static Double Stiffness(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.Stiffness;
      }
  public static Double Exponent(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.Exponent;
      }
  public static Double MaxDamping(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.MaxDamping;
      }
  public static Double Penetration(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.Penetration;
      }
  public static Int32 FrictionOption(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.FrictionOption;
      }
  public static Double StaticFrictionVelocity(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.StaticFrictionVelocity;
      }
  public static Double DynamicFrictionVelocity(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.DynamicFrictionVelocity;
      }
  public static Double StaticFrictionCoefficient(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.StaticFrictionCoefficient;
      }
  public static Double DynamicFrictionCoefficient(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.DynamicFrictionCoefficient;
      }
  public static Object ContactComponents(ISimulation3DContactFeatureDataObject ISimulation3DContactFeatureDatainstance)
      {
            return ISimulation3DContactFeatureDatainstance.ISimulation3DContactFeatureDataInstance.ContactComponents;
      }
    }
}
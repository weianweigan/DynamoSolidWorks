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
   public class ISimulationObject
    {
         public ISimulation ISimulationInstance { get; set; }
        public ISimulationObject(ISimulation ISimulationinstance)
        {
                ISimulationInstance = ISimulationinstance;
        }
    }
   public static class ISimulationInterface
   {
  public static IFeatureObject GetFeature(ISimulationObject ISimulationinstance)
     {
            return new IFeatureObject(ISimulationinstance.ISimulationInstance.GetFeature());
       }
  public static Boolean ResetComponents(ISimulationObject ISimulationinstance)
     {
            return ISimulationinstance.ISimulationInstance.ResetComponents();
       }
  public static Boolean IsAnimationPlaying(ISimulationObject ISimulationinstance)
     {
            return ISimulationinstance.ISimulationInstance.IsAnimationPlaying();
       }
  public static IAnimationObject PlayAnimation(ISimulationObject ISimulationinstance)
     {
            return new IAnimationObject(ISimulationinstance.ISimulationInstance.PlayAnimation());
       }
  public static Boolean Status(ISimulationObject ISimulationinstance)
      {
            return ISimulationinstance.ISimulationInstance.Status;
      }
  public static Double Duration(ISimulationObject ISimulationinstance)
      {
            return ISimulationinstance.ISimulationInstance.Duration;
      }
  public static Int32 Frames(ISimulationObject ISimulationinstance)
      {
            return ISimulationinstance.ISimulationInstance.Frames;
      }
  public static Int32 TimeStamp(ISimulationObject ISimulationinstance)
      {
            return ISimulationinstance.ISimulationInstance.TimeStamp;
      }
  public static IAnimationObject Animation(ISimulationObject ISimulationinstance)
      {
            return new IAnimationObject(ISimulationinstance.ISimulationInstance.Animation);
      }
    }
}
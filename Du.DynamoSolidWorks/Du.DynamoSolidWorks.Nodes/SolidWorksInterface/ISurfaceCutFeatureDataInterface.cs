//using SolidWorks.Interop.sldworks;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using SolidWorks.Interop.swconst;
//using DynamoSolidWorks;
//using Du.SolidWorks.Extension;
//using Autodesk.DesignScript.Runtime;
//using Du.DynamoSolidWorks.Nodes;

//namespace DynamoSolidWorks
//{
//   public class ISurfaceCutFeatureDataObject
//    {
//         public ISurfaceCutFeatureData ISurfaceCutFeatureDataInstance { get; set; }
//        public ISurfaceCutFeatureDataObject(ISurfaceCutFeatureData ISurfaceCutFeatureDatainstance)
//        {
//                ISurfaceCutFeatureDataInstance = ISurfaceCutFeatureDatainstance;
//        }
//    }
//   public static class ISurfaceCutFeatureDataInterface
//   {
//  public static Boolean IAccessSelections(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance,ModelDoc2Object TopDoc,Component2Object Component)
//     {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.IAccessSelections(TopDoc,Component);
//       }
//  public static Boolean AccessSelections(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance,Object TopDoc,Object Component)
//     {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.AccessSelections(TopDoc,Component);
//       }
//  public static void ReleaseSelectionAccess(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance)
//     {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.ReleaseSelectionAccess();
//       }
//  public static Int16 GetBodyIndexKept(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance)
//     {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.GetBodyIndexKept();
//       }
//  public static Int32 GetFeatureScopeBodiesCount(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance)
//     {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.GetFeatureScopeBodiesCount();
//       }
//  public static IBody2Object IGetFeatureScopeBodies(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance,Int32 Count)
//     {
//            return new IBody2Object(ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.IGetFeatureScopeBodies(Count));
//       }
//  public static void ISetFeatureScopeBodies(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance,Int32 Count,Body2&Object BodyArr)
//     {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.ISetFeatureScopeBodies(Count,BodyArr);
//       }
//  public static Object SurfaceForCut(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance)
//      {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.SurfaceForCut;
//      }
//  public static Boolean Flip(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance)
//      {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.Flip;
//      }
//  public static Boolean FeatureScope(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance)
//      {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.FeatureScope;
//      }
//  public static Boolean AutoSelect(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance)
//      {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.AutoSelect;
//      }
//  public static Object FeatureScopeBodies(ISurfaceCutFeatureDataObject ISurfaceCutFeatureDatainstance)
//      {
//            return ISurfaceCutFeatureDatainstance.ISurfaceCutFeatureDataInstance.FeatureScopeBodies;
//      }
//    }
//}
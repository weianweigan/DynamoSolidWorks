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
    public class IEnvironmentObject
    {
        public IEnvironment IEnvironmentInstance { get; set; }
        public IEnvironmentObject(IEnvironment IEnvironmentinstance)
        {
            IEnvironmentInstance = IEnvironmentinstance;
        }
    }
    public static class IEnvironmentInterface
    {
        public static Object GetSymEdgeCounts(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.GetSymEdgeCounts(SymId);
        }
        public static Int16 IGetSymEdgeCounts(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.IGetSymEdgeCounts(SymId);
        }
        public static Object GetSymLines(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.GetSymLines(SymId);
        }
        public static Double IGetSymLines(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.IGetSymLines(SymId);
        }
        public static Object GetSymArcs(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.GetSymArcs(SymId);
        }
        public static Double IGetSymArcs(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.IGetSymArcs(SymId);
        }
        public static Object GetSymCircles(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.GetSymCircles(SymId);
        }
        public static Double IGetSymCircles(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.IGetSymCircles(SymId);
        }
        public static Object GetSymTextPoints(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.GetSymTextPoints(SymId);
        }
        public static Double IGetSymTextPoints(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.IGetSymTextPoints(SymId);
        }
        public static Object GetSymText(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.GetSymText(SymId);
        }
        public static Object GetSymTriangles(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.GetSymTriangles(SymId);
        }
        public static Double IGetSymTriangles(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.IGetSymTriangles(SymId);
        }
        public static Object GetSymArcs2(IEnvironmentObject IEnvironmentinstance, String SymId)
        {
            return IEnvironmentinstance.IEnvironmentInstance.GetSymArcs2(SymId);
        }
        //public static void GetIsBound(IEnvironmentObject IEnvironmentinstance, String SymId, Boolean& Retval)
        //{
        //    return IEnvironmentinstance.IEnvironmentInstance.GetIsBound(SymId, Retval);
        //}
    }
}
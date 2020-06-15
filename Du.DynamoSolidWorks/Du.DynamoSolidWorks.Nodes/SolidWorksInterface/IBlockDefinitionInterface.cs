using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace DynamoSolidWorks
{
    public class IBlockDefinitionObject
    {
        public IBlockDefinition IBlockDefinitionInstance { get; set; }
        public IBlockDefinitionObject(IBlockDefinition IBlockDefinitioninstance)
        {
            IBlockDefinitionInstance = IBlockDefinitioninstance;
        }
    }
    public static class IBlockDefinitionInterface
    {
        public static Int32 GetBlockInstanceCount(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetBlockInstanceCount();
        }
        public static Object GetBlockInstances(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetBlockInstances();
        }
        public static IBlockInstanceObject IGetBlockInstances(IBlockDefinitionObject IBlockDefinitioninstance, Int32 Count)
        {
            return new IBlockInstanceObject(IBlockDefinitioninstance.IBlockDefinitionInstance.IGetBlockInstances(Count));
        }
        public static Boolean GetUseExternalFile(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetUseExternalFile();
        }
        public static Int32 SetUseExternalFile(IBlockDefinitionObject IBlockDefinitioninstance, Boolean UseFile)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.SetUseExternalFile(UseFile);
        }
        public static String GetExternalFileName(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetExternalFileName();
        }
        public static Int32 SetExternalFileName(IBlockDefinitionObject IBlockDefinitioninstance, String FileName)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.SetExternalFileName(FileName);
        }
        public static IBlockInstanceObject InsertInstance(IBlockDefinitionObject IBlockDefinitioninstance, Double X, Double Y, Double Angle, Double Scale)
        {
            return new IBlockInstanceObject(IBlockDefinitioninstance.IBlockDefinitionInstance.InsertInstance(X, Y, Angle, Scale));
        }
        public static Object GetBasePoint(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetBasePoint();
        }
        public static Double IGetBasePoint(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.IGetBasePoint();
        }
        public static Boolean SetBasePoint(IBlockDefinitionObject IBlockDefinitioninstance, Object BasePoint)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.SetBasePoint(BasePoint);
        }

        [MultiReturn(SWValueConst.Result, SWValueConst.BasePoint)]
        public static Dictionary<string, object> ISetBasePoint(IBlockDefinitionObject IBlockDefinitioninstance, Double BasePoint)
        {
            var result = IBlockDefinitioninstance.IBlockDefinitionInstance.ISetBasePoint(BasePoint);
            return new Dictionary<string, object>() { { SWValueConst.Result, result }, { SWValueConst.BasePoint, BasePoint } };
        }
        public static ISketchObject GetSketch(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return new ISketchObject(IBlockDefinitioninstance.IBlockDefinitionInstance.GetSketch());
        }
        public static Int32 GetNoteCount(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetNoteCount();
        }
        public static Object GetNotes(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetNotes();
        }
        public static INoteObject IGetNotes(IBlockDefinitionObject IBlockDefinitioninstance, Int32 NumNotes)
        {
            return new INoteObject(IBlockDefinitioninstance.IBlockDefinitionInstance.IGetNotes(NumNotes));
        }
        public static Int32 GetDimensionCount(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetDimensionCount();
        }
        public static Object GetDimensions(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.GetDimensions();
        }
        public static IDisplayDimensionObject IGetDimensions(IBlockDefinitionObject IBlockDefinitioninstance, Int32 NumDimensions)
        {
            return new IDisplayDimensionObject(IBlockDefinitioninstance.IBlockDefinitionInstance.IGetDimensions(NumDimensions));
        }
        public static String Name(IBlockDefinitionObject IBlockDefinitioninstance)
        {
            return IBlockDefinitioninstance.IBlockDefinitionInstance.Name;
        }
    }
}
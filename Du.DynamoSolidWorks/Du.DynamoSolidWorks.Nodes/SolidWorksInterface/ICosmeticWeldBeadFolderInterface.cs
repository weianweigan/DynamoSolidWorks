using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICosmeticWeldBeadFolderObject
    {
        public ICosmeticWeldBeadFolder ICosmeticWeldBeadFolderInstance { get; set; }
        public ICosmeticWeldBeadFolderObject(ICosmeticWeldBeadFolder ICosmeticWeldBeadFolderinstance)
        {
            ICosmeticWeldBeadFolderInstance = ICosmeticWeldBeadFolderinstance;
        }
    }
    public static class ICosmeticWeldBeadFolderInterface
    {
        public static String Material(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.Material;
        }
        public static String Process(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.Process;
        }
        public static Double MassPerUnitLength(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.MassPerUnitLength;
        }
        public static Double CostPerUnitMass(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.CostPerUnitMass;
        }
        public static Double TimePerUnitLength(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.TimePerUnitLength;
        }
        public static Int32 NumberOfWeldPasses(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.NumberOfWeldPasses;
        }
        public static Double TotalNumber(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.TotalNumber;
        }
        public static Double TotalLength(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.TotalLength;
        }
        public static Double TotalMass(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.TotalMass;
        }
        public static Double TotalCost(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.TotalCost;
        }
        public static Double TotalTime(ICosmeticWeldBeadFolderObject ICosmeticWeldBeadFolderinstance)
        {
            return ICosmeticWeldBeadFolderinstance.ICosmeticWeldBeadFolderInstance.TotalTime;
        }
    }
}
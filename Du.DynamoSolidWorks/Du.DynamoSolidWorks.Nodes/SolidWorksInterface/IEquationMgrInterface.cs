using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IEquationMgrObject
    {
        public IEquationMgr IEquationMgrInstance { get; set; }
        public IEquationMgrObject(IEquationMgr IEquationMgrinstance)
        {
            IEquationMgrInstance = IEquationMgrinstance;
        }
    }
    public static class IEquationMgrInterface
    {
        public static Int32 Add(IEquationMgrObject IEquationMgrinstance, Int32 Index, String Equation)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Add(Index, Equation);
        }
        public static Int32 Delete(IEquationMgrObject IEquationMgrinstance, Int32 Index)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Delete(Index);
        }
        public static Int32 ChangeSuppressionForAllConfigurations(IEquationMgrObject IEquationMgrinstance, Int32 Index, Boolean State)
        {
            return IEquationMgrinstance.IEquationMgrInstance.ChangeSuppressionForAllConfigurations(Index, State);
        }
        public static Int32 ChangeSuppressionForConfiguration(IEquationMgrObject IEquationMgrinstance, Int32 Index, String ConfigName, Boolean State)
        {
            return IEquationMgrinstance.IEquationMgrInstance.ChangeSuppressionForConfiguration(Index, ConfigName, State);
        }
        public static Int32 GetCount(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.GetCount();
        }
        public static Int32 Add2(IEquationMgrObject IEquationMgrinstance, Int32 Index, String Equation, Boolean Solve)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Add2(Index, Equation, Solve);
        }
        public static Int32 EvaluateAll(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.EvaluateAll();
        }
        public static Int32 Add3(IEquationMgrObject IEquationMgrinstance, Int32 Index, String Equation, Boolean Solve, Int32 WhichConfigurations, Object ConfigNames)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Add3(Index, Equation, Solve, WhichConfigurations, ConfigNames);
        }
        //public static Int32 IAdd3(IEquationMgrObject IEquationMgrinstance, Int32 Index, String Equation, Boolean Solve, Int32 WhichConfigurations, Int32 ConfigCount, String& ConfigNames)
        //{
        //    return IEquationMgrinstance.IEquationMgrInstance.IAdd3(Index, Equation, Solve, WhichConfigurations, ConfigCount, ConfigNames);
        //}
        public static Int32 SetEquationAndConfigurationOption(IEquationMgrObject IEquationMgrinstance, Int32 Index, String Equation, Int32 WhichConfigurations, Object ConfigNames)
        {
            return IEquationMgrinstance.IEquationMgrInstance.SetEquationAndConfigurationOption(Index, Equation, WhichConfigurations, ConfigNames);
        }
        //public static Int32 ISetEquationAndConfigurationOption(IEquationMgrObject IEquationMgrinstance, Int32 Index, String Equation, Int32 WhichConfigurations, Int32 ConfigCount, String& ConfigNames)
        //{
        //    return IEquationMgrinstance.IEquationMgrInstance.ISetEquationAndConfigurationOption(Index, Equation, WhichConfigurations, ConfigCount, ConfigNames);
        //}
        public static Int32 GetConfigurationOption(IEquationMgrObject IEquationMgrinstance, Int32 Index)
        {
            return IEquationMgrinstance.IEquationMgrInstance.GetConfigurationOption(Index);
        }
        public static Boolean UpdateValuesFromExternalEquationFile(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.UpdateValuesFromExternalEquationFile();
        }
        public static Int32 GetDisabledEquationCount(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.GetDisabledEquationCount();
        }
        public static Boolean Suppression(IEquationMgrObject IEquationMgrinstance, int Index)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Suppression[Index];
        }
        public static Int32 Status(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Status;
        }
        public static Double Value(IEquationMgrObject IEquationMgrinstance, int Index)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Value[Index];
        }
        public static String Equation(IEquationMgrObject IEquationMgrinstance, int Index)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Equation[Index];
        }
        public static Int32 AngularEquationUnits(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.AngularEquationUnits;
        }
        public static Boolean LinkToFile(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.LinkToFile;
        }
        public static String FilePath(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.FilePath;
        }
        public static Boolean AutomaticSolveOrder(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.AutomaticSolveOrder;
        }
        public static Boolean GlobalVariable(IEquationMgrObject IEquationMgrinstance, int Index)
        {
            return IEquationMgrinstance.IEquationMgrInstance.GlobalVariable[Index];
        }
        public static Boolean Disabled(IEquationMgrObject IEquationMgrinstance, int Index)
        {
            return IEquationMgrinstance.IEquationMgrInstance.Disabled[Index];
        }
        public static Boolean AutomaticRebuild(IEquationMgrObject IEquationMgrinstance)
        {
            return IEquationMgrinstance.IEquationMgrInstance.AutomaticRebuild;
        }
    }
}
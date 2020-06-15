using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IManipulatorObject
    {
        public IManipulator IManipulatorInstance { get; set; }
        public IManipulatorObject(IManipulator IManipulatorinstance)
        {
            IManipulatorInstance = IManipulatorinstance;
        }
    }
    public static class IManipulatorInterface
    {
        public static void Show(IManipulatorObject IManipulatorinstance, Object PModelDoc)
        {
            IManipulatorinstance.IManipulatorInstance.Show(PModelDoc);
        }
        public static void Remove(IManipulatorObject IManipulatorinstance)
        {
            IManipulatorinstance.IManipulatorInstance.Remove();
        }
        public static Object GetSpecificManipulator(IManipulatorObject IManipulatorinstance)
        {
            return IManipulatorinstance.IManipulatorInstance.GetSpecificManipulator();
        }
        public static Boolean Select(IManipulatorObject IManipulatorinstance, Boolean Append, ISelectDataObject Data)
        {
            return IManipulatorinstance.IManipulatorInstance.Select(Append, Data.ISelectDataInstance as SelectData);
        }
        public static Boolean Visible(IManipulatorObject IManipulatorinstance)
        {
            return IManipulatorinstance.IManipulatorInstance.Visible;
        }
        public static String Name(IManipulatorObject IManipulatorinstance)
        {
            return IManipulatorinstance.IManipulatorInstance.Name;
        }
        public static Boolean Selectable(IManipulatorObject IManipulatorinstance)
        {
            return IManipulatorinstance.IManipulatorInstance.Selectable;
        }
        public static Int32 Options(IManipulatorObject IManipulatorinstance)
        {
            return IManipulatorinstance.IManipulatorInstance.Options;
        }
    }
}
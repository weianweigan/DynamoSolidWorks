using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICommandTabObject
    {
        public ICommandTab ICommandTabInstance { get; set; }
        public ICommandTabObject(ICommandTab ICommandTabinstance)
        {
            ICommandTabInstance = ICommandTabinstance;
        }
    }
    public static class ICommandTabInterface
    {
        public static Int32 GetCommandTabBoxCount(ICommandTabObject ICommandTabinstance)
        {
            return ICommandTabinstance.ICommandTabInstance.GetCommandTabBoxCount();
        }
        public static Object CommandTabBoxes(ICommandTabObject ICommandTabinstance)
        {
            return ICommandTabinstance.ICommandTabInstance.CommandTabBoxes();
        }
        public static ICommandTabBoxObject IGetCommandTabBoxes(ICommandTabObject ICommandTabinstance, Int32 TabBoxCount)
        {
            return new ICommandTabBoxObject(ICommandTabinstance.ICommandTabInstance.IGetCommandTabBoxes(TabBoxCount));
        }
        public static ICommandTabBoxObject AddCommandTabBox(ICommandTabObject ICommandTabinstance)
        {
            return new ICommandTabBoxObject(ICommandTabinstance.ICommandTabInstance.AddCommandTabBox());
        }
        //public static void RemoveCommandTabBox(ICommandTabObject ICommandTabinstance, CommandTabBoxObject CommandTabBox)
        //{
        //    return ICommandTabinstance.ICommandTabInstance.RemoveCommandTabBox(CommandTabBox);
        //}
        //public static ICommandTabBoxObject AddSeparator(ICommandTabObject ICommandTabinstance, CommandTabBoxObject CommandTabBoxIn, Int32 CommandID)
        //{
        //    return new ICommandTabBoxObject(ICommandTabinstance.ICommandTabInstance.AddSeparator(CommandTabBoxIn, CommandID));
        //}
        public static Boolean Visible(ICommandTabObject ICommandTabinstance)
        {
            return ICommandTabinstance.ICommandTabInstance.Visible;
        }
        public static Boolean Active(ICommandTabObject ICommandTabinstance)
        {
            return ICommandTabinstance.ICommandTabInstance.Active;
        }
        public static String Name(ICommandTabObject ICommandTabinstance)
        {
            return ICommandTabinstance.ICommandTabInstance.Name;
        }
    }
}
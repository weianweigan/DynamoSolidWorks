using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICommandTabBoxObject
    {
        public ICommandTabBox ICommandTabBoxInstance { get; set; }
        public ICommandTabBoxObject(ICommandTabBox ICommandTabBoxinstance)
        {
            ICommandTabBoxInstance = ICommandTabBoxinstance;
        }
    }
    public static class ICommandTabBoxInterface
    {
        public static Boolean AddCommands(ICommandTabBoxObject ICommandTabBoxinstance, Object CommandIDs, Object TextDisplayStyles)
        {
            return ICommandTabBoxinstance.ICommandTabBoxInstance.AddCommands(CommandIDs, TextDisplayStyles);
        }
        //public static Boolean IAddCommands(ICommandTabBoxObject ICommandTabBoxinstance, Int32 CommandIDCount, Int32& CommandIDs, Int32& TextDisplayStyles)
        //{
        //    return ICommandTabBoxinstance.ICommandTabBoxInstance.IAddCommands(CommandIDCount, CommandIDs, TextDisplayStyles);
        //}
        //public static Boolean RemoveCommands(ICommandTabBoxObject ICommandTabBoxinstance, Object CommandIDs)
        //{
        //    return ICommandTabBoxinstance.ICommandTabBoxInstance.RemoveCommands(CommandIDs);
        //}
        //public static Boolean IRemoveCommands(ICommandTabBoxObject ICommandTabBoxinstance, Int32 CommandIDCount, Int32& CommandIDs)
        //{
        //    return ICommandTabBoxinstance.ICommandTabBoxInstance.IRemoveCommands(CommandIDCount, CommandIDs);
        //}
        //public static Int32 GetCommands(ICommandTabBoxObject ICommandTabBoxinstance, Object& CommandIDs, Object& TextDisplayStyles)
        //{
        //    return ICommandTabBoxinstance.ICommandTabBoxInstance.GetCommands(CommandIDs, TextDisplayStyles);
        //}
        //public static Int32 IGetCommands(ICommandTabBoxObject ICommandTabBoxinstance, Int32& CommandIDs, Int32& TextDisplayStyles)
        //{
        //    return ICommandTabBoxinstance.ICommandTabBoxInstance.IGetCommands(CommandIDs, TextDisplayStyles);
        //}
    }
}
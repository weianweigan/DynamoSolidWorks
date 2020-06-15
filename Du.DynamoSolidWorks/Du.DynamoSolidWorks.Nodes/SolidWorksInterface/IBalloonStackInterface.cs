using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBalloonStackObject
    {
        public IBalloonStack IBalloonStackInstance { get; set; }
        public IBalloonStackObject(IBalloonStack IBalloonStackinstance)
        {
            IBalloonStackInstance = IBalloonStackinstance;
        }
    }
    public static class IBalloonStackInterface
    {
        public static INoteObject IGetStack(IBalloonStackObject IBalloonStackinstance, Int32 Count)
        {
            return new INoteObject(IBalloonStackinstance.IBalloonStackInstance.IGetStack(Count));
        }
        public static INoteObject AddTo(IBalloonStackObject IBalloonStackinstance, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
        {
            return new INoteObject(IBalloonStackinstance.IBalloonStackInstance.AddTo(UpperTextStyle, UpperText, LowerTextStyle, LowerText));
        }
        public static INoteObject Master(IBalloonStackObject IBalloonStackinstance)
        {
            return new INoteObject(IBalloonStackinstance.IBalloonStackInstance.Master);
        }
        public static Int32 Count(IBalloonStackObject IBalloonStackinstance)
        {
            return IBalloonStackinstance.IBalloonStackInstance.Count;
        }
        public static Object Stack(IBalloonStackObject IBalloonStackinstance)
        {
            return IBalloonStackinstance.IBalloonStackInstance.Stack;
        }
        public static Int32 Length(IBalloonStackObject IBalloonStackinstance)
        {
            return IBalloonStackinstance.IBalloonStackInstance.Length;
        }
        public static Int32 Direction(IBalloonStackObject IBalloonStackinstance)
        {
            return IBalloonStackinstance.IBalloonStackInstance.Direction;
        }
    }
}
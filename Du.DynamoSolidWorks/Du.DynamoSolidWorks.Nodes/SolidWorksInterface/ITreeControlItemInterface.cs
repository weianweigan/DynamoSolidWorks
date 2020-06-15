using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITreeControlItemObject
    {
        public ITreeControlItem ITreeControlItemInstance { get; set; }
        public ITreeControlItemObject(ITreeControlItem ITreeControlIteminstance)
        {
            ITreeControlItemInstance = ITreeControlIteminstance;
        }
    }
    public static class ITreeControlItemInterface
    {
        public static ITreeControlItemObject GetRoot(ITreeControlItemObject ITreeControlIteminstance)
        {
            return new ITreeControlItemObject(ITreeControlIteminstance.ITreeControlItemInstance.GetRoot());
        }
        public static ITreeControlItemObject GetParent(ITreeControlItemObject ITreeControlIteminstance)
        {
            return new ITreeControlItemObject(ITreeControlIteminstance.ITreeControlItemInstance.GetParent());
        }
        public static ITreeControlItemObject GetNext(ITreeControlItemObject ITreeControlIteminstance)
        {
            return new ITreeControlItemObject(ITreeControlIteminstance.ITreeControlItemInstance.GetNext());
        }
        public static ITreeControlItemObject GetPrevious(ITreeControlItemObject ITreeControlIteminstance)
        {
            return new ITreeControlItemObject(ITreeControlIteminstance.ITreeControlItemInstance.GetPrevious());
        }
        public static ITreeControlItemObject GetFirstChild(ITreeControlItemObject ITreeControlIteminstance)
        {
            return new ITreeControlItemObject(ITreeControlIteminstance.ITreeControlItemInstance.GetFirstChild());
        }
        public static String Text(ITreeControlItemObject ITreeControlIteminstance)
        {
            return ITreeControlIteminstance.ITreeControlItemInstance.Text;
        }
        public static Int32 ObjectType(ITreeControlItemObject ITreeControlIteminstance)
        {
            return ITreeControlIteminstance.ITreeControlItemInstance.ObjectType;
        }
        public static Object Object(ITreeControlItemObject ITreeControlIteminstance)
        {
            return ITreeControlIteminstance.ITreeControlItemInstance.Object;
        }
        public static Boolean IsRoot(ITreeControlItemObject ITreeControlIteminstance)
        {
            return ITreeControlIteminstance.ITreeControlItemInstance.IsRoot;
        }
        public static Boolean Expanded(ITreeControlItemObject ITreeControlIteminstance)
        {
            return ITreeControlIteminstance.ITreeControlItemInstance.Expanded;
        }
    }
}
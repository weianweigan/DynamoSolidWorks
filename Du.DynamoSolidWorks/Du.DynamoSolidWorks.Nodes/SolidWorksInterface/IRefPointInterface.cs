using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IRefPointObject
    {
        public IRefPoint IRefPointInstance { get; set; }
        public IRefPointObject(IRefPoint IRefPointinstance)
        {
            IRefPointInstance = IRefPointinstance;
        }
    }
    public static class IRefPointInterface
    {
        public static IMathPointObject GetRefPoint(IRefPointObject IRefPointinstance)
        {
            return new IMathPointObject(IRefPointinstance.IRefPointInstance.GetRefPoint());
        }
    }
}
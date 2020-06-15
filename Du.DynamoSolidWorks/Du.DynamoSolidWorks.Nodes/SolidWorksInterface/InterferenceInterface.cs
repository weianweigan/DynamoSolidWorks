using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class InterferenceObject
    {
        public Interference InterferenceInstance { get; set; }
        public InterferenceObject(Interference Interferenceinstance)
        {
            InterferenceInstance = Interferenceinstance;
        }
    }
    public static class InterferenceInterface
    {
    }
}
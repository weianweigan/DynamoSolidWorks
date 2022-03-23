using SolidWorks.Interop.sldworks;
using Xarial.XCad.SolidWorks;

namespace SldWorksService
{
    public static class SwContext
    {
        public static ISldWorksContext Instance { get; private set; }

        public static ISldWorks Sw => Instance?.Sw;

        public static ISwApplication SwApplication => Instance?.SwApplication;

        public static void Init(ISldWorksContext context)
        {
            if(Instance == null)
                Instance = context;
        }
    }
}

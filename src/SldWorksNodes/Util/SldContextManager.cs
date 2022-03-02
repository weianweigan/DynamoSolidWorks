using Autodesk.DesignScript.Runtime;
using SldWorksService;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Util
{
    [IsVisibleInDynamoLibrary(false)]
    public class SldContextManager
    {
        private SldContextManager(ISldWorksContext context)
        {
            Context = context;
        }

        public static SldContextManager Instance { get;private set; }

        public ISldWorksContext Context { get; }

        public static void Init(ISldWorksContext context)
        {
            if (Instance == null)
            {
                Instance = new SldContextManager(context);
            }
        }

        public static ISldWorks Sw => SldContextManager.Instance.Context.App;
    }
}

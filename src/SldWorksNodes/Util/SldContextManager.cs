using SldWorksService;

namespace SldWorksNodes.Util
{
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
    }
}

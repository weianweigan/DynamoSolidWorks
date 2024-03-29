﻿using Autodesk.DesignScript.Runtime;
using SldWorksService;
using SolidWorks.Interop.sldworks;
using Xarial.XCad.SolidWorks;

namespace SldWorksNodes.Util
{
    [IsVisibleInDynamoLibrary(false)]
    public class SldContextManager
    {
        private static IModeler _modeler;
        private static IMathUtility _mathUtility;

        private SldContextManager(ISldWorksContext context)
        {
            Context = context;
        }

        public static SldContextManager Instance { get; private set; }

        public ISldWorksContext Context { get; }

        public static void Init(ISldWorksContext context)
        {
            if (Instance == null)
            {
                Instance = new SldContextManager(context);
            }
        }

        public static ISldWorks Sw => SldContextManager.Instance.Context.Sw;

        public static ISwApplication SwApplication => SldContextManager.Instance.Context.SwApplication;

        public static IModeler Modeler => _modeler ?? (_modeler = Sw.GetModeler() as IModeler);

        public static IMathUtility MathUtility => _mathUtility ?? (_mathUtility = Sw.IGetMathUtility());
    }
}

using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public static class SolidWorksInstance
    {
        private static ISldWorks _swApp;

        /// <summary>
        /// ISldWorks 对象
        /// </summary>
        public static ISldWorks SwApp
        {
            get
            {
                if (_swApp != null)
                {
                    return _swApp;
                }
                var progId = "SldWorks.Application.26";
                try
                {
                    ISldWorks app = (ISldWorks)System.Runtime.InteropServices.Marshal.GetActiveObject(progId);

                    return app;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static ISldWorksObject SldWorksObject
        {
            get
            {
                return new DynamoSolidWorks.ISldWorksObject(SwApp);
            }
        }

    }
}

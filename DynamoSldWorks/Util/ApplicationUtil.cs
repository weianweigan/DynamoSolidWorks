using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DynamoSldWorks.Util
{
    public static class ApplicationUtil
    {
        public static Application Create()
        {
            var app = new Application();
            app.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            return app;
        }
    }
}

using Dynamo.Graph.Nodes;
using Dynamo.Models;
using SldWorksService;
using SolidWorks.Interop.sldworks;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Xarial.XCad.SolidWorks;

namespace DynamoSldWorks.Model
{
    public class SldDynamoModel : DynamoModel, ISldWorksContext
    {
        protected SldDynamoModel(IStartConfiguration config) : base(config)
        {
            
        }

        public ISldWorks App => SwApplication.Sw;
        
        public ISwApplication SwApplication { get; private set; }

        public static SldDynamoModel Make(ISwApplication swApp,bool CLIModel = false)
        {
            return Start(new SldStartConfiguation()
            {
                //SchedulerThread = new SwSchedulerThread(swApp),
            },swApp);
        }

        public static SldDynamoModel Start(SldStartConfiguation configuation, ISwApplication swApp)
        {
            var model = new SldDynamoModel(configuation)
            {
                HostName = "Dynamo SolidWorks",
                //HostAnalyticsInfo = new HostAnalyticsInfo() { HostName = "Dynamo SolidWorks" },
                HostVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                SwApplication = swApp,
            };

            model.UpdateManager.RegisterExternalApplicationProcessId(Process.GetCurrentProcess().Id);

            return model;
        }
    }
}

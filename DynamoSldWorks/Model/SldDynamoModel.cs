using Dynamo.Graph.Nodes;
using Dynamo.Models;
using SldWorksService;
using SolidWorks.Interop.sldworks;
using System.IO;
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

        public static SldDynamoModel Start(ISwApplication swApp,bool CLIModel = false)
        {
            return Start(new SldStartConfiguation(),swApp);
        }

        public static SldDynamoModel Start(SldStartConfiguation configuation, ISwApplication swApp)
        {
            return new SldDynamoModel(configuation)
            {
                HostName = "Dynamo SolidWorks",
                //HostAnalyticsInfo = new HostAnalyticsInfo() { HostName = "Dynamo SolidWorks" },
                HostVersion = swApp.Version.ToString(),
                SwApplication = swApp,
            };
        }
    }
}

using Dynamo.Graph.Nodes;
using Dynamo.Models;
using System.IO;

namespace DynamoSldWorks.Model
{
    public class SldDynamoModel : DynamoModel
    {
        protected SldDynamoModel(IStartConfiguration config) : base(config)
        {

        }

        public static SldDynamoModel Start(bool CLIModel = false)
        {
            return Start(new SldStartConfiguation());
        }

        public static SldDynamoModel Start(SldStartConfiguation configuation)
        {
            return new SldDynamoModel(configuation);
        }
    }
}

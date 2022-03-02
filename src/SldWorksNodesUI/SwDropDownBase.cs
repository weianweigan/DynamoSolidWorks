using CoreNodeModels;
using Dynamo.Graph.Nodes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SldWorksNodesUI
{
    public abstract class SwDropDownBase:DSDropDownBase
    {
        protected SwDropDownBase(string value) : base(value)
        {
        }

        [JsonConstructor]
        public SwDropDownBase(string value, IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(value, inPorts, outPorts)
        {
        }
    }
}

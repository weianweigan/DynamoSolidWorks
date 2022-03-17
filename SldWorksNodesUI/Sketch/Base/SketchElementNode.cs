using Dynamo.Graph.Nodes;
using SldWorksNodes.Base;

namespace SldWorksNodesUI.Sketch
{
    public abstract class SketchElementNode : NodeModel, IPID
    {
        public string PID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamo.Graph.Nodes;
using ProtoCore.AST.AssociativeAST;
using SldWorksNodes.Geometry;

namespace SldWorksNodesUI.Sketch
{
    [NodeName("ByStartPointEndPoint")]
    [NodeDescription("Create a sketchline by start point and endpoint")]
    [NodeCategory("SolidWorks.Sketch.SketchLine")]
    [InPortNames("startPoint","endPoint")]
    [InPortTypes("SldWorksNodes.SldWorksNodes.Geometry.Point3D")]
    [InPortDescriptions("","")]
    [OutPortNames("SketchLine")]
    [OutPortTypes("SldWorksNodes.SldWorksNodes.Sketch.SketchLine")]
    [OutPortDescriptions("")]
    public class SketchLineNode:SketchSegmentNode
    {
        public SketchLineNode()
        {
            RegisterAllPorts();
        }

        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
            if (InputNodes.Count < 2)
            {
                return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
            }

            

            var pidNode = AstFactory.BuildStringNode(PID);


        }
    }
}

using Autodesk.DesignScript.Runtime;
using CoreNodeModels;
using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using Newtonsoft.Json;
using ProtoCore.AST.AssociativeAST;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodesUI
{
    public abstract class SwFeatureDropDown : SwDropDownBase
    {

        protected SwFeatureDropDown(string value) : base(value)
        {
            InPorts.Clear();
            OutPorts.Clear();

            RegisterAllPorts();
        }


        [JsonConstructor]
        public SwFeatureDropDown(string value, IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(value, inPorts, outPorts)
        {
        }

        protected IEnumerable<DynamoDropDownItem> GetNeededFeats(string featTypeName)
        {
            var doc = SwContextUtil.GetActivePartDocContext();

            var feats = doc
                .GetAllFeats()
                .Where(p => !p.GetUIState((int)swUIStates_e.swIsHiddenInFeatureMgr));

            if (!string.IsNullOrWhiteSpace(featTypeName))
                feats = feats.Where(p => p.GetTypeName2() == featTypeName);

            var items = feats
                .Select(p => new DynamoDropDownItem(p.Name, p.Name));
            return items;
        }

    
    }
}

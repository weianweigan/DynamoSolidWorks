using CoreNodeModels;
using Dynamo.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodesUI.Selection
{
    public class SwModelSelectionHelper<TSelection> : IModelSelectionHelper<TSelection>
    {
        public event Action<ILogMessage> MessageLogged;

        public IEnumerable<TSelection> RequestSelectionOfType(string selectionMessage, SelectionType selectionType, SelectionObjectType objectType)
        {

            return new List<TSelection>() { };
        }
    }
}

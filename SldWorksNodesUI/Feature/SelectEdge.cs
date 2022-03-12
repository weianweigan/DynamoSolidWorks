using CoreNodeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodesUI.Feature
{
    public abstract class SwObjectSelction<TSelection, TResult> : SelectionBase<TSelection, TResult>
    {
        protected SwObjectSelction(SelectionType selectionType, SelectionObjectType selectionObjectType, string message, string prefix) : base(selectionType, selectionObjectType, message, prefix)
        {
        }
    }

    public class SelectEdge
    {
    }

    
}

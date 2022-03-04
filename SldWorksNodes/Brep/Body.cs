using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Brep
{
    [IsVisibleInDynamoLibrary(false)]
    public class Body:BrepNode<IBody2>
    {
    }
}

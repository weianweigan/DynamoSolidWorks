using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes
{
    public class FeaturesFunctions
    {
        private FeaturesFunctions()
        {

        }

        [IsVisibleInDynamoLibrary(false)]
        public static string GetNodeInput()
        {
            return "";
        }
    }
}

using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.CustomProperty
{
    public class CustomPropertyManager
    {
        private CustomPropertyManager()
        {

        }

        /// <summary>
        /// Add a custom property in solidworks active document
        /// </summary>
        /// <param name="customProperty"></param>
        /// <param name="configuation"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="SwException.CustomPropertyAddException"></exception>
        [IsVisibleInDynamoLibrary(false)]
        public static string Add(CustomProperty customProperty,string configuation = "")
        {
            if (customProperty == null)
                return "No Property Input";

            var doc = SwContextUtil.GetActivDocContext();

            var cusMgr = doc.Extension.CustomPropertyManager[configuation];

            if (cusMgr == null)
                throw new ArgumentNullException($"Missing Configuation:{configuation}");

            //后期考虑添加替换
            var res = (swCustomInfoAddResult_e)cusMgr.Add3(customProperty.Name, (int)customProperty.SwCustomInfoType, customProperty.ToValue(), (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);

            return
                res != swCustomInfoAddResult_e.swCustomInfoAddResult_AddedOrChanged ?  $"False:{res}" :
                "True";     
        }

        [IsVisibleInDynamoLibrary(false)]
        public static CustomProperty Get(string name,string configuation= "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            var doc = SwContextUtil.GetActivDocContext();

            var cusMgr = doc.Extension.CustomPropertyManager[configuation ?? ""];

            if (cusMgr == null)
                throw new ArgumentNullException($"Missing Configuation:{configuation}");

            cusMgr.Get2(name, out var value, out var resolvedValue);

            return new StringCustomProperty(name,resolvedValue, configuation);
        }
    }
}

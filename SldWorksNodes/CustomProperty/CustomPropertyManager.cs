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

            var doc = SwContextUtil.GetActivePartDocContext();

            var cusMgr = doc.Extension.CustomPropertyManager[configuation];

            if (cusMgr == null)
                throw new ArgumentNullException($"Missing Configuation:{configuation}");

            //后期考虑添加替换
            var res = (swCustomInfoAddResult_e)cusMgr.Add3(customProperty.Name, (int)customProperty.SwCustomInfoType, customProperty.ToValue(), (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);

            return
                res != swCustomInfoAddResult_e.swCustomInfoAddResult_AddedOrChanged ?  $"False:{res}" :
                "True";     
        }

        public static CustomProperty Get(string name,string configuation= "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            var doc = SwContextUtil.GetActivePartDocContext();

            var cusMgr = doc.Extension.CustomPropertyManager[configuation];

            if (cusMgr == null)
                throw new ArgumentNullException($"Missing Configuation:{configuation}");

            cusMgr.Get2(name, out var value, out var resolvedValue);

            return new StringCustomProperty(name,resolvedValue, configuation);
        }

        /// <summary>
        /// Get all custom properties in solidworks active document
        /// </summary>
        /// <param name="configuation"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static List<CustomProperty> GetAll(string configuation = "")
        {
            var doc = SwContextUtil.GetActivePartDocContext();

            var cusMgr = doc.Extension.CustomPropertyManager[configuation];

            if (cusMgr == null)
                throw new ArgumentNullException($"Missing Configuation:{configuation}");

            object names = null;
            object types = null;
            object values = null;
            object resolved = null;
            object link = null;
            int count = cusMgr.GetAll3(ref names, ref types, ref values, ref resolved, ref link);
            if(count == 0)
                return new List<CustomProperty> { };
            
            var cusProperties = new List<CustomProperty>(count);

            object[] nameArray = names as object[];
            int[] typesArray = (int[])types;
            object[] valuesArray = values as object[];
            int[] resolvedArray = resolved as int[];
            int[] linkArray = link as int[];

            for (int i = 0; i < count; i++)
            {
                CustomProperty property;
                var type = (swCustomInfoType_e)typesArray[i];
                switch (type)
                {
                    case swCustomInfoType_e.swCustomInfoUnknown:
                        continue;
                    case swCustomInfoType_e.swCustomInfoText:
                        property = new StringCustomProperty(nameArray[i] as string, valuesArray[i] as string,configuation);
                        break;
                    case swCustomInfoType_e.swCustomInfoDate:
                        property = new StringCustomProperty(nameArray[i] as string, valuesArray[i] as string, configuation);
                        break;
                    case swCustomInfoType_e.swCustomInfoNumber:
                        property = new NumberCustomProperty(nameArray[i] as string, (int)valuesArray[i], configuation);
                        break;
                    case swCustomInfoType_e.swCustomInfoDouble:
                        property = new DoubleCustomProperty(nameArray[i] as string, (double)valuesArray[i], configuation);
                        break;
                    case swCustomInfoType_e.swCustomInfoYesOrNo:
                        property = new StringCustomProperty(nameArray[i] as string,valuesArray[i] as string, configuation);
                        break;
                    default:
                        continue;
                }
                cusProperties.Add(property);
            }

            return cusProperties;
        }
    }
}

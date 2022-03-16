using SldWorksNodes.Util;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.CustomProperty
{
    public abstract class CustomProperty
    {
        #region Query
        public string Name { get; set; }
        #endregion

        #region Properties
        internal string Configuation { get; set; }

        internal abstract swCustomInfoType_e SwCustomInfoType { get; set; }
        #endregion

        #region Creation
        /// <summary>
        /// Init a text customproperty by name and value
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CustomProperty ByNameText(string name, string value, string configuation = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return new StringCustomProperty(name, value, configuation);
        }

        /// <summary>
        /// Init a double customproperty by name and value
        /// </summary>
        /// <param name="name">key name of customproperty</param>
        /// <param name="value">value of customproperty</param>
        /// <returns></returns>
        public static CustomProperty ByNameDouble(string name, double value, string configuation = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return new DoubleCustomProperty(name, value, configuation);
        }

        public static CustomProperty ByNameYesOrNo(string name, bool yesOrNo, string configuation = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return new YesOrNoCustomProperty(name, yesOrNo, configuation);
        }

        public static CustomProperty ByNameDateTime(string name, DateTime dateTime, string configuation = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return new DateCustomProperty(name, dateTime, configuation);
        }
        #endregion

        #region Action
        /// <summary>
        /// Get all custom properties in solidworks active document
        /// </summary>
        /// <param name="configuation"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static List<CustomProperty> All(string configuation = "")
        {
            var doc = SwContextUtil.GetActivDocContext();

            var cusMgr = doc.Extension.CustomPropertyManager[configuation];

            if (cusMgr == null)
                throw new ArgumentNullException($"Missing Configuation:{configuation}");

            object names = null;
            object types = null;
            object values = null;
            object resolved = null;
            object link = null;
            int count = cusMgr.GetAll3(ref names, ref types, ref values, ref resolved, ref link);
            if (count == 0)
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
                        property = new StringCustomProperty(nameArray[i] as string, valuesArray[i] as string, configuation);
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
                        property = new StringCustomProperty(nameArray[i] as string, valuesArray[i] as string, configuation);
                        break;
                    default:
                        continue;
                }
                cusProperties.Add(property);
            }

            return cusProperties;
        }

        internal virtual string ToValue()
        {
            return string.Empty;
        }

        public string Value()
        {
            var doc = SwContextUtil.GetActivDocContext();

            var cusMgr = doc.Extension.CustomPropertyManager[Configuation];

            if (cusMgr == null)
                throw new ArgumentNullException($"Missing Configuation:{Configuation}");

            cusMgr.Get2(Name, out var value, out var resolvedValue);

            return resolvedValue;
        }
        #endregion
    }
   
    public abstract class CustomProperty<TValue>:CustomProperty
    {
        internal TValue Value { get; set; }

        public override string ToString()
        {
            return $"{Name}:{Value}";
        }

        internal override string ToValue()
        {
            return Value?.ToString();
        }
    }
}

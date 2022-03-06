using System;

namespace SldWorksNodes.CustomProperty
{
    public class CustomPropertyCreation
    {
        private CustomPropertyCreation()
        {

        }

        /// <summary>
        /// Init a text customproperty by name and value
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CustomProperty ByNameText(string name,string value, string configuation = "")
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
        public static CustomProperty ByNameDouble(string name, double value,string configuation = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return new DoubleCustomProperty(name, value, configuation);
        }

        public static CustomProperty ByNameYesOrNo(string name,bool yesOrNo, string configuation = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return new YesOrNoCustomProperty(name, yesOrNo,configuation);
        }

        public static CustomProperty ByNameDateTime(string name,DateTime dateTime,string configuation = "")
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return new DateCustomProperty(name, dateTime, configuation);
        }
    }
}

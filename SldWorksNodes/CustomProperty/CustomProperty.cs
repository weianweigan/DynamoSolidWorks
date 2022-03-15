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
        public string Name { get; set; }

        internal string Configuation { get; set; }

        internal abstract swCustomInfoType_e SwCustomInfoType { get; set; }

        internal virtual string ToValue()
        {
            return string.Empty;
        }

        public string Value()
        {
            var doc = SwContextUtil.GetActivePartDocContext();

            var cusMgr = doc.Extension.CustomPropertyManager[Configuation];

            if (cusMgr == null)
                throw new ArgumentNullException($"Missing Configuation:{Configuation}");

            cusMgr.Get2(Name, out var value, out var resolvedValue);

            return resolvedValue;
        }
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

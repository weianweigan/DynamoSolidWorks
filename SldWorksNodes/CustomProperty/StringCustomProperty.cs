using SolidWorks.Interop.swconst;
using System;

namespace SldWorksNodes.CustomProperty
{
    public class StringCustomProperty : CustomProperty<string>
    {
        internal StringCustomProperty(string name, string value,string config)
        {
            Name = name;
            Value = value;
            Configuation = config;

            CustomPropertyManager.Add(this);
        }

        internal override swCustomInfoType_e SwCustomInfoType { get; set; } = swCustomInfoType_e.swCustomInfoText;
    }

    public class DoubleCustomProperty : CustomProperty<double>
    {
        internal DoubleCustomProperty(string name, double value, string config)
        {
            Name = name;
            Value = value;
            Configuation = config;


            CustomPropertyManager.Add(this);
        }

        internal override swCustomInfoType_e SwCustomInfoType { get; set; } = swCustomInfoType_e.swCustomInfoDouble;
    }

    public class NumberCustomProperty : CustomProperty<int>
    {
        internal NumberCustomProperty(string name, int value, string config)
        {
            Name = name;
            Value = value;
            Configuation = config;


            CustomPropertyManager.Add(this);
        }

        internal override swCustomInfoType_e SwCustomInfoType { get; set; } = swCustomInfoType_e.swCustomInfoNumber;

    }

    public class DateCustomProperty : CustomProperty<DateTime>
    {
        internal DateCustomProperty(string name,DateTime value, string config)
        {
            Name=name;
            Value = value;
            Configuation = config;

            CustomPropertyManager.Add(this);
        }

        internal override swCustomInfoType_e SwCustomInfoType { get; set; } = swCustomInfoType_e.swCustomInfoDate;
    }

    public class YesOrNoCustomProperty : CustomProperty<bool>
    {
        internal YesOrNoCustomProperty(string name, bool value, string config)
        {
            Name = name;
            Value = value;

            CustomPropertyManager.Add(this);
        }
        internal override swCustomInfoType_e SwCustomInfoType { get; set; } = swCustomInfoType_e.swCustomInfoYesOrNo;
    }

}

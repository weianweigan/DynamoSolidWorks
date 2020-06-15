using System;

namespace Du.SolidWorks.Attributes
{
    /// <summary>
    /// Box序列
    /// </summary>
    public class BoxOrderAttribute : Attribute
    {
        public int Order { get; set; }
    }
}

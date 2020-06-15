using System;

namespace Du.SolidWorks.Extension
{
    /// <summary>
    /// 基准轴未找到异常
    /// </summary>
    public class RefAxisNotFoundException : Exception
    {
        public RefAxisNotFoundException(string msg) : base(msg) { }
    }
}

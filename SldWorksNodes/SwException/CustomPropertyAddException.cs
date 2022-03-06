using SolidWorks.Interop.swconst;
using System;

namespace SldWorksNodes.SwException
{
    public class CustomPropertyAddException : Exception
    {
        public CustomPropertyAddException(swCustomInfoAddResult_e swCustomInfoAddResult_e):base(swCustomInfoAddResult_e.ToString())
        {
        }
    }
}

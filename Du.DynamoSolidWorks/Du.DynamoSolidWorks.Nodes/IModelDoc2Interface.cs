using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du.DynamoSolidWorks.Nodes
{
    public class IModelDoc2Wrapper
    {
        public IModelDoc2Wrapper(IModelDoc2 doc)
        {
            Doc = doc;
        }

        public IModelDoc2 Doc { get; }

    }

    public static class IModelDoc2Interface
    {

        /// <summary>
        /// 获取文档Title
        /// </summary>
        /// <param name="doc">SolidWorks文档</param>
        /// <returns></returns>
        public static string GetTitle(IModelDoc2Wrapper doc)
        {
            return doc.Doc.GetTitle();
        }
    }
}

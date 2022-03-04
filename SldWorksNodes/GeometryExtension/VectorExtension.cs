using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Media
{
    [IsVisibleInDynamoLibrary(false)]
    public static class VectorExtension
    {
        /// <summary>
        /// 点在向量坐标还是右边
        /// </summary>
        /// <see cref="https://blog.csdn.net/shijie_nihao/article/details/99566466"/>
        public static bool LeftOrRight(this Vector vector, Point point)
        {
            var ap = point - new Point();

            var res = Vector.CrossProduct(vector, ap);

            return res > 0;
        }
    }
}

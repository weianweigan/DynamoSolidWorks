using Autodesk.DesignScript.Runtime;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SldWorksNodes.Util
{
    /// <summary>
    /// 封送工具类
    /// </summary>
    [IsVisibleInDynamoLibrary(false)]    
    public static class DispathWrapperUtil
    {
        /// <summary>
        /// 将对象列表封装为 <see cref="DispatchWrapper[]"/>
        /// </summary>
        /// <typeparam name="TSwInterface"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DispatchWrapper[] ObjectArrayToDispatchWrapperArray<TSwInterface>(IList<TSwInterface> list)
        {
            DispatchWrapper[] d = new DispatchWrapper[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                d[i] = new DispatchWrapper(list[i]);
            }

            return d;
        }

        public static DispatchWrapper ObjectToDispatchWrapper(this object obj)
        {
            return new DispatchWrapper(obj);
        }
    }
}

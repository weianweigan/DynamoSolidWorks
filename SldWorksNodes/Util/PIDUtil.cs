using Autodesk.DesignScript.Runtime;
using SldWorksNodes.SwException;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;

namespace SldWorksNodes.Util
{
    [IsVisibleInDynamoLibrary(false)]
    public static class PIDUtil
    {

        public static string GetPID(this IModelDoc2 doc, object obj)
        {
            var data = doc.Extension.GetPersistReference3(obj) as byte[];

            return data == null ? string.Empty : ByteArrayToString(data);
        }

        public static string GetPID(object obj)
        {
            return GetPID(SwContextUtil.GetActivDocContext(), obj);
        }

        /// <summary>
        /// 判断两个PID是否是同一个
        /// </summary>
        /// <param name="p1">Base64编码的PID</param>
        /// <param name="p2">Base64编码的另外一个PID</param>
        /// <returns>是否相等</returns>
        public static bool IsSamePID(this IModelDocExtension extension, string p1, string p2)
        {
            var res = (swObjectEquality)extension.IsSamePersistentID(Convert.FromBase64String(p1), Convert.FromBase64String(p2));
            return res == swObjectEquality.swObjectSame;
        }

        internal static void AssertState(swPersistReferencedObjectStates_e state)
        {
            if (state != swPersistReferencedObjectStates_e.swPersistReferencedObject_Ok)
            {
                throw new PIDErrorException(state);
            }
        }

        /// <summary>
        /// 从PID中获取对象
        /// </summary>
        /// <param name="doc">当前文档</param>
        /// <param name="pid">base64编码的pid</param>
        /// <param name="state">状态</param>
        /// <returns></returns>
        public static object GetObjectFromPID(this IModelDoc2 doc, string pid, out swPersistReferencedObjectStates_e state)
        {
            var byteId = Convert.FromBase64String(pid); //_encoder.GetBytes(pid);

            var obj = doc.Extension.GetObjectByPersistReference3(byteId, out int errorCode);
            state = (swPersistReferencedObjectStates_e)errorCode;

            return obj;
        }

        public static object GetObjectFromPID(string pid, out swPersistReferencedObjectStates_e state)
        {
            return GetObjectFromPID(SwContextUtil.GetActivDocContext(), pid, out state);
        }

        private static string ByteArrayToString(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length < 2)
            {
                return $"Byte Error {byteArray?.Length}";
            }

            string value = Convert.ToBase64String(byteArray);

            return value;
        }
    }
}

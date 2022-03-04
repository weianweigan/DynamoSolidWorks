/*
 * Created By WeiGan 2021.4.1 NJ.Touch Ltd
 * 1.对于Vector4的扩展方法
 * 
 */

using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace System.Numerics
{
    [IsVisibleInDynamoLibrary(false)]
    public static class Vector4Extension
    {
        public static Vector3D ToVector3D(this Vector4 vector4)
        {
            return new Vector3D(vector4.X, vector4.Y, vector4.Z);
        }
    }
}

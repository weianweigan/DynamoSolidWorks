/*
 * Created By WeiGan 2021/4/23 NJ.Touch.Ltd
 * 用来描述四个点构成的矩形
 */

using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Media.Media3D
{
    [IsVisibleInDynamoLibrary(false)]
    public struct RectPoint3Ds
    {


        public Point3D LeftDown { get; set; }

        public Point3D LeftTop { get; set; }

        public Point3D RightTop { get; set; }

        public Point3D RightDown { get; set; }
    }

}

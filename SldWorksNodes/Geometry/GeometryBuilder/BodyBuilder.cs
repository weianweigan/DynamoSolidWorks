using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Util
{
    [IsVisibleInDynamoLibrary(false)]
    public static class BodyBuilder
    {
        public static IBody2 CreateFromBox(
            IModeler modeler,
            Point3D downLeft,
            Point3D topRight)
        {
            var data = ToBodyBox(
                new double[] {
                downLeft.X, downLeft.Y, downLeft.Z,
                topRight.X, topRight.Y, topRight.Z });

            return modeler.CreateBodyFromBox(data) as IBody2;
        }

        public static IBody2 CreateCylinderBody(
            IModeler modeler,
            Point3D center,
            Vector3D axis,
            double raduis,
            double height)
        {
            return modeler.CreateBodyFromCyl(
               new double[]
            {
                center.X,center.Y,center.Z,
                axis.X,axis.Y,axis.Z,
                raduis,
                height
            }) as IBody2;
        }

        public static IBody2 CreateConeBody(
            Point3D center,
            Vector3D axis, 
            double bottomRaduis, 
            double topRadius,
            double height)
        {
            var data =
                new double[]
            {
                center.X,center.Y, center.Z,
                axis.X, axis.Y, axis.Z,
                bottomRaduis,
                topRadius,
                height
            };

            return SldContextManager.Modeler.CreateBodyFromCone(data) as IBody2;
        }
      
        #region Private Methods
        private static double[] ToBodyBox(double[] box)
        {
            if (box is null)
            {
                throw new ArgumentNullException(nameof(box));
            }

            if (box.Length < 6)
            {
                throw new ArgumentException($"{nameof(box)} Length Error");
            }

            var result = new double[] {
                //底面中心
                (box[0] + box[3])/2,
                (box[1]+box[4])/2,
                box[2],

                //轴向
                0d,0d,1d,

                //长宽高
                box[3] - box[0],
                box[4] - box[1],
                box[5] - box[2],
            };

            return result;
        }
        #endregion
    }
}

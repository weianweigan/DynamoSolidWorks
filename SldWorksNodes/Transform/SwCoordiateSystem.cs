using System;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Geometry;
using SldWorksNodes.Manager;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Transform
{
    /// <summary>
    /// CoordiateSystem for SolidWorks
    ///    |a b c.n |  0 1 2   12 
    ///    |d e f.o |  3 4 5   13
    ///    |g h i.p |  6 7 8   14
    ///    |j k l.m |  9 10 11 15
    /// </summary>
    public class SwCoordiateSystem
    {
        #region Ctor
        internal SwCoordiateSystem(Point3D postion, Vector3D xAxis, Vector3D yAxis, Vector3D zAxis,double scale = 1)
        {
            Postion = postion;
            XAxis = xAxis;
            YAxis = yAxis;
            ZAxis = zAxis;
            ScaleFactor = scale;
        }
        #endregion

        #region Query
        public Point3D Postion { get; }

        public Vector3D XAxis { get; }

        public Vector3D YAxis { get; }

        public Vector3D ZAxis { get; }

        public double ScaleFactor { get; set; } = 1;
        #endregion

        #region Create
        public static SwCoordiateSystem ByPostionAndDirection(Point3D postion,Vector3D xAxis,Vector3D yAxis,Vector3D zAxis)
        {
            if(postion == null || xAxis == null || yAxis == null || zAxis == null)
                return null;

            return new SwCoordiateSystem(postion, xAxis, yAxis, zAxis);
        }

        public static SwCoordiateSystem ByOrign(Point3D postion)
        {
            if (postion == null)
                return null;

            return new SwCoordiateSystem(postion, Vector3D.XAxis, Vector3D.YAxis, Vector3D.ZAxis);
        }

        /// <summary>
        /// In put a 16 length double array to create a transform
        /// </summary>
        /// <param name="arrayData"></param>
        /// <returns></returns>
        public static SwCoordiateSystem ByMatrix(double[] arrayData)
        {
            if (arrayData == null) return null;
            if (arrayData.Length < 16)
                throw new ArgumentException($"{arrayData.Length} is not 16");

            return new SwCoordiateSystem(
                new Point3D(arrayData[9], arrayData[10], arrayData[11]),
                new Vector3D(arrayData[0], arrayData[1], arrayData[2]),
                new Vector3D(arrayData[3], arrayData[4], arrayData[5]),
                new Vector3D(arrayData[6], arrayData[7], arrayData[8]),
                arrayData[15]
                );
        }

        public static SwCoordiateSystem Identity()
        {
            return new SwCoordiateSystem(
                Point3D.Orign, 
                Vector3D.XAxis, 
                Vector3D.YAxis, 
                Vector3D.ZAxis);
        }
        #endregion

        #region Action
        /// <summary>
        /// Newly created math transform object or null if the operation fails
        /// </summary>
        /// <param name="transform">Math transform by which to multiply the calling math transform</param>
        /// <returns></returns>
        public SwCoordiateSystem Mutiply(SwCoordiateSystem transform)
        {
            var current = ToSwTransform(null);
            var inTrans = transform.ToSwTransform(null);

            var newSwTrans = current.Multiply(inTrans) as MathTransform;

            if (newSwTrans == null)
                return null;

            return ByMatrix(newSwTrans.ArrayData as double[]);
        }

        /// <summary>
        /// Creates a new math transform by inverting the values in an already existing math transform. 
        /// </summary>
        /// <returns>Math transform or NULL if the operation fails</returns>
        public SwCoordiateSystem Invert()
        {
            var current = ToSwTransform(null);

            var newSwTrans = current.Inverse() as MathTransform;

            if (newSwTrans == null)
                return null;

            return ByMatrix(newSwTrans.ArrayData as double[]);
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Postion}-{XAxis}-{YAxis}-{ZAxis}";
        }

        [IsVisibleInDynamoLibrary(false)]
        public MathTransform ToSwTransform(UnitManager unitManager)
        {
            var newPostion = unitManager == null ? 
                Postion :
                unitManager.ConvertPoint(Postion);
            return SldContextManager.MathUtility.CreateTransform(new double[]
            {
                XAxis.X,XAxis.Y,XAxis.Z,0,
                YAxis.X,YAxis.Y,YAxis.Z,0,
                ZAxis.X,ZAxis.Y,ZAxis.Z,0,
                newPostion.X,newPostion.Y,newPostion.Z,1
            }) as MathTransform;
        }
        #endregion
    }
}

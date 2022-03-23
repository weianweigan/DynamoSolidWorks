using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Manager;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodes.Geometry
{
    public class SolidBody : SwBodyNode
    {
        protected readonly bool _display;

        #region Ctor
        [IsVisibleInDynamoLibrary(false)]
        public SolidBody(IBody2 body,bool display = true)
        {
            SwObject=body;
            _display = display;

            if (display)
                DisplayBody();
        }

        [IsVisibleInDynamoLibrary(false)]
        public SolidBody()
        {

        }
        #endregion

        #region Query
        public List<Brep.Face> Faces()
        {
            if (SwObject == null)
                return null;

            var objs = SwObject.GetFaces() as object[];

            return objs
                .Cast<IFace2>()
                .Select(p => new Brep.Face(p))
                .ToList();
        }
        #endregion

        #region Create
        public static SolidBody ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IBody2;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new SolidBody(obj);
            else
                throw new SwObjectLostException(typeof(IFace2));
        }

        #endregion

        #region Action

        public static SolidBody ByExtrued(
            List<Curve> curves,
            Vector3D direction,
            double length)
        {
            if (curves?.Any() != true || direction == null || length <= 0)
                return null;

            var swUnit = new UnitManager();

            var nLength = swUnit.ConvertDouble(length);

            var vector = SldContextManager.MathUtility.CreateVector(direction.ToArray()) as MathVector;
            var body = BodyBuilder.Extrued(
                SldContextManager.Modeler,
                curves, vector, length);

            if (body == null)
                throw new Exception("Creation Failed");

            return new SolidBody(body);
        }

        #endregion

        #region Methods

        public Dictionary<string,Point3D> Box()
        {
            if (SwObject == null)
                return null;

            var box = SwObject.GetBodyBox() as double[];
            if (box == null)
                return null;

            return new Dictionary<string, Point3D>()
            {
                {"min",new Point3D(box[0],box[1],box[2]) },
                {"max",new Point3D(box[3],box[4],box[5]) },
            };
        }
        #endregion
    }
}

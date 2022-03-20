using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamoServices;
using SldWorksNodes.Base;
using SldWorksNodes.Geometry;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchLine : SketchSegment<ISketchLine>
    {
        #region Fields
        private Point3D _sPt;
        private Point3D _ePt;
        #endregion

        #region Ctor
        internal SketchLine(Point3D startPoint,Point3D endPoint, SwSketch sketch) 
        {
            _sPt = _swUnit.ConvertPoint(startPoint);
            _ePt = _swUnit.ConvertPoint(endPoint);

            CreateSegment(_sPt, _ePt);            
        }

        internal SketchLine(ISketchLine skeSeg)
        {
            SkeSegment = skeSeg;
            SwObject = skeSeg as ISketchSegment;

            SolvePoints();
        }
        #endregion

        #region Create
        public static SketchLine ByStartPointAndEndPoint(Point3D startPoint, Point3D endPoint)
        {
            if (startPoint == null || endPoint == null)
                return null;

            return new SketchLine(startPoint, endPoint, null);
        }

        #endregion

        #region Query
        public SketchPoint StartPoint { get;private set; }

        public SketchPoint EndPoint { get;private set;}

        #endregion

        #region Action

        #endregion

        #region Methods
        private void CreateSegment(Point3D newSpt, Point3D newEpt)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            {
                SwObject = skeMgr.CreateLine(
                    newSpt.X, newSpt.Y, newSpt.Z,
                    newEpt.X, newEpt.Y, newEpt.Z);
            });

            SkeSegment = (ISketchLine)SwObject;

            if (SkeSegment == null)
                throw new Exception($"{newSpt}-{newEpt} Failed");

            SolvePoints();
        }

        private void SolvePoints()
        {
            StartPoint = new SketchPoint(
                _sketch,
                SkeSegment.GetStartPoint2() as ISketchPoint);

            EndPoint = new SketchPoint(
                _sketch,
                SkeSegment.GetEndPoint2() as ISketchPoint);
        }

        public override string ToString()
        {
            if (SwObject == null)
                return $"Failed {_sPt}-{_ePt}";
            else
                return $"{_sPt}-{_ePt}";
        }
        #endregion
    }
}

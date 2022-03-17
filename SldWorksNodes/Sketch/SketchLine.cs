using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorksNodes.Base;
using SldWorksNodes.Geometry;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchLine : SketchSegment<ISketchLine>
    {
        private Point3D _sPt;
        private Point3D _ePt;

        internal SketchLine(SwSketch sketch)
            : base(sketch) { }

        #region Create
        public static SketchLine BySketch(SwSketch sketch)
        {
            if(sketch == null) return null;
            return new SketchLine(sketch);
        }
        #endregion

        #region Query
        public SketchPoint StartPoint { get;private set; }

        public SketchPoint EndPoint { get;private set;}

        #endregion

        #region Action
        public bool StartPointAndEndPoint(Point3D startPoint,Point3D endPoint)
        {
            if (startPoint == null || endPoint == null)
                return false;

            _sPt = _swUnit.ConvertPoint(startPoint);
            _ePt = _swUnit.ConvertPoint(endPoint);

            if (SwObject != null)
            {
                return Update(startPoint,endPoint);
            }
            else
            {
                CreateSegment(_sPt, _ePt);
            }

            return SwObject != null;
        }

        private bool Update(Point3D startPoint, Point3D endPoint)
        {
            //var skeMgr = GetSkeContext();

            return StartPoint.Postion(startPoint) ||
                EndPoint.Postion(endPoint);
        }
        #endregion

        #region Methods
        private void CreateSegment(Point3D newSpt, Point3D newEpt)
        {
            var skeMgr = GetSkeContext();

            SwObject = skeMgr.CreateLine(
                newSpt.X, newSpt.Y, newSpt.Z,
                newEpt.X, newEpt.Y, newEpt.Z);

            SkeSegment = (ISketchLine)SwObject;

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
                return $"Use {nameof(StartPointAndEndPoint)} Action To CreatePoint";
            else
                return $"{_sPt}-{_ePt}";
        }
        #endregion
    }
}

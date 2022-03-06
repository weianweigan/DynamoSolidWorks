using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Geometry
{
    public class Curve:IDisposable
    {
        private ICurve _curve;
        private ICurve _baseCurve;

        internal Curve(ICurve curve)
        {
            _curve = curve;
            if(curve.IsTrimmedCurve())
            {
                _baseCurve = curve.GetBaseCurve();
            }
            else
            {
                _baseCurve = curve;
            }
        }

        public void Dispose()
        {
            _curve = null;
            _baseCurve = null;
        }

    }
}

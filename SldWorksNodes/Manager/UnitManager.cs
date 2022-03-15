/*
 * Created By WeiGan
 * Dynamo is unitless,but solidworks use meter as default unit.
 * This manager provide a interface to convert unit.
 */

using System;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SldWorksNodes.Manager
{
    public enum UnitType
    {
        UseMM,
        UseMeter,
        //TODO：SolidWorks用户单位
        UseUserValueInSw,
    }

    [IsVisibleInDynamoLibrary(false)]
    public class UnitManager:IDisposable
    {
        private IUserUnit _lengthUnit;
        private IUserUnit _angleUnit;

        public static UnitType UnitType { get; set; }

        #region Ctor
        public UnitManager(IModelDoc2 doc)
        {
            if(UnitType == UnitType.UseUserValueInSw)
            {
                _lengthUnit = doc.GetUserUnit((int)swUserUnitsType_e.swLengthUnit) as IUserUnit;
                _angleUnit = doc.GetUserUnit((int)swUserUnitsType_e.swAngleUnit) as IUserUnit;
            }
        }

        public UnitManager()
        {
            if(UnitType == UnitType.UseUserValueInSw)
            {
                throw new ArgumentException("In System UnitType,Please Use UnitManager(IModelDoc2 doc)");
            }
        }

        public UnitManager(IUserUnit lengthUnit, IUserUnit angleUnit)
        {
            _lengthUnit = lengthUnit;
            _angleUnit = angleUnit;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 将用户值转换为系统值
        /// </summary>
        /// <param name="value">用户值，用户在Dynamo界面上输入的值</param>
        /// <returns></returns>
        public double ConvertDouble(double value)
        {
            switch (UnitType)
            {
                case UnitType.UseMM:
                    value /= 1000;
                    break;
                case UnitType.UseMeter:
                    break;
                case UnitType.UseUserValueInSw:
                    value = _lengthUnit.ConvertDoubleToSystemValue(value);
                    break;
                default:
                    break;
            }
            return value;
        }

        public Point3D ConvertPoint(Point3D point)
        {
            if (UnitType == UnitType.UseMeter)
                return point;

            var x = ConvertDouble(point.X);
            var y = ConvertDouble(point.Y);
            var z = ConvertDouble(point.Z);

            return new Point3D(x,y,z);
        }

        public void Dispose()
        {
            _lengthUnit = null;
            _angleUnit = null;
        }
        #endregion
    }
}

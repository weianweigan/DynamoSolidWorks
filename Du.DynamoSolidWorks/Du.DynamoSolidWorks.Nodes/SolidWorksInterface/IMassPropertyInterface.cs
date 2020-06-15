using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMassPropertyObject
    {
        public IMassProperty IMassPropertyInstance { get; set; }
        public IMassPropertyObject(IMassProperty IMassPropertyinstance)
        {
            IMassPropertyInstance = IMassPropertyinstance;
        }
    }
    public static class IMassPropertyInterface
    {
        public static Double IGetCenterOfMass(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.IGetCenterOfMass();
        }
        public static Double IGetPrincipleAxesOfInertia(IMassPropertyObject IMassPropertyinstance, Int32 Axis)
        {
            return IMassPropertyinstance.IMassPropertyInstance.IGetPrincipleAxesOfInertia(Axis);
        }
        public static Double IGetPrincipleMomentsOfInertia(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.IGetPrincipleMomentsOfInertia();
        }
        public static Object GetMomentOfInertia(IMassPropertyObject IMassPropertyinstance, Int32 WhereTaken)
        {
            return IMassPropertyinstance.IMassPropertyInstance.GetMomentOfInertia(WhereTaken);
        }
        public static Double IGetMomentOfInertia(IMassPropertyObject IMassPropertyinstance, Int32 WhereTaken)
        {
            return IMassPropertyinstance.IMassPropertyInstance.IGetMomentOfInertia(WhereTaken);
        }
        public static Boolean SetCoordinateSystem(IMassPropertyObject IMassPropertyinstance, IMathTransformObject Coords)
        {
            return IMassPropertyinstance.IMassPropertyInstance.SetCoordinateSystem(Coords.IMathTransformInstance as MathTransform);
        }
        public static Boolean AddBodies(IMassPropertyObject IMassPropertyinstance, Object BodyListIn)
        {
            return IMassPropertyinstance.IMassPropertyInstance.AddBodies(BodyListIn);
        }
        //public static Boolean IAddBodies(IMassPropertyObject IMassPropertyinstance, Int32 NumBodies, Body2&Object BodyListIn)
        //{
        //    return IMassPropertyinstance.IMassPropertyInstance.IAddBodies(NumBodies, BodyListIn);
        //}
        public static Boolean SetAssignedMassProp(IMassPropertyObject IMassPropertyinstance, Double Mass, Double Center_x, Double Center_y, Double Center_z, Int32 Config_opt, Object Config_names)
        {
            return IMassPropertyinstance.IMassPropertyInstance.SetAssignedMassProp(Mass, Center_x, Center_y, Center_z, Config_opt, Config_names);
        }
        //public static Boolean ISetAssignedMassProp(IMassPropertyObject IMassPropertyinstance, Double Mass, Double Center_x, Double Center_y, Double Center_z, Int32 Config_opt, Int32 ConfigNum, String& Config_names)
        //{
        //    return IMassPropertyinstance.IMassPropertyInstance.ISetAssignedMassProp(Mass, Center_x, Center_y, Center_z, Config_opt, ConfigNum, Config_names);
        //}
        public static Boolean SetOverrideMassValue(IMassPropertyObject IMassPropertyinstance, Double Value, Int32 Config_option, Object Config_names)
        {
            return IMassPropertyinstance.IMassPropertyInstance.SetOverrideMassValue(Value, Config_option, Config_names);
        }
        //public static Boolean ISetOverrideMassValue(IMassPropertyObject IMassPropertyinstance, Double Value, Int32 Config_option, Int32 Config_numbers, String& Config_names)
        //{
        //    return IMassPropertyinstance.IMassPropertyInstance.ISetOverrideMassValue(Value, Config_option, Config_numbers, Config_names);
        //}
        public static Boolean SetOverrideCenterOfMassValue(IMassPropertyObject IMassPropertyinstance, Object Value, String CoordinateSystemName, Int32 Config_option, Object Config_names)
        {
            return IMassPropertyinstance.IMassPropertyInstance.SetOverrideCenterOfMassValue(Value, CoordinateSystemName, Config_option, Config_names);
        }
        //public static Boolean ISetOverrideCenterOfMassValue(IMassPropertyObject IMassPropertyinstance, Double& Value, String CoordinateSystemName, Int32 Config_option, Int32 Config_numbers, String& Config_names)
        //{
        //    return IMassPropertyinstance.IMassPropertyInstance.ISetOverrideCenterOfMassValue(Value, CoordinateSystemName, Config_option, Config_numbers, Config_names);
        //}
        public static Boolean SetOverridePrincipleAxesOrientation(IMassPropertyObject IMassPropertyinstance, Int32 Axis, Object Value, Int32 Config_option, Object Config_names)
        {
            return IMassPropertyinstance.IMassPropertyInstance.SetOverridePrincipleAxesOrientation(Axis, Value, Config_option, Config_names);
        }
        //public static Boolean ISetOverridePrincipleAxesOrientation(IMassPropertyObject IMassPropertyinstance, Int32 Axis, Double& Value, Int32 Config_option, Int32 Config_numbers, String& Config_names)
        //{
        //    return IMassPropertyinstance.IMassPropertyInstance.ISetOverridePrincipleAxesOrientation(Axis, Value, Config_option, Config_numbers, Config_names);
        //}
        //public static Boolean SetOverridePrincipleMomentsOfInertia(IMassPropertyObject IMassPropertyinstance, Object Value, Int32 Config_option, Object Config_names)
        //{
        //    return IMassPropertyinstance.IMassPropertyInstance.SetOverridePrincipleMomentsOfInertia(Value, Config_option, Config_names);
        //}
        //public static Boolean ISetOverridePrincipleMomentsOfInertia(IMassPropertyObject IMassPropertyinstance, Double& Value, Int32 Config_option, Int32 Config_numbers, String& Config_names)
        //{
        //    return IMassPropertyinstance.IMassPropertyInstance.ISetOverridePrincipleMomentsOfInertia(Value, Config_option, Config_numbers, Config_names);
        //}
        public static Boolean SetOverrideMomentsOfInertiaValue(IMassPropertyObject IMassPropertyinstance, Int32 ReferenceFrame, String CoordinateSystemName, Object Value, Int32 Config_option, Object Config_names)
        {
            return IMassPropertyinstance.IMassPropertyInstance.SetOverrideMomentsOfInertiaValue(ReferenceFrame, CoordinateSystemName, Value, Config_option, Config_names);
        }
        //public static Boolean ISetOverrideMomentsOfInertiaValue(IMassPropertyObject IMassPropertyinstance, Int32 ReferenceFrame, String CoordinateSystemName, Double& Value, Int32 Config_option, Int32 Config_numbers, String& Config_names)
        //{
        //    return IMassPropertyinstance.IMassPropertyInstance.ISetOverrideMomentsOfInertiaValue(ReferenceFrame, CoordinateSystemName, Value, Config_option, Config_numbers, Config_names);
        //}
        public static Boolean UseSystemUnits(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.UseSystemUnits;
        }
        public static Double Mass(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.Mass;
        }
        public static Double Volume(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.Volume;
        }
        public static Double Density(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.Density;
        }
        public static Double SurfaceArea(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.SurfaceArea;
        }
        public static Object CenterOfMass(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.CenterOfMass;
        }
        public static Object PrincipleAxesOfInertia(IMassPropertyObject IMassPropertyinstance, int Axis)
        {
            return IMassPropertyinstance.IMassPropertyInstance.PrincipleAxesOfInertia[Axis];
        }
        public static Object PrincipleMomentsOfInertia(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.PrincipleMomentsOfInertia;
        }
        public static Boolean UserAssigned(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.UserAssigned;
        }
        public static Boolean OverrideMass(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.OverrideMass;
        }
        public static Boolean OverrideCenterOfMass(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.OverrideCenterOfMass;
        }
        public static Boolean OverrideMomentsOfInertia(IMassPropertyObject IMassPropertyinstance)
        {
            return IMassPropertyinstance.IMassPropertyInstance.OverrideMomentsOfInertia;
        }
    }
}

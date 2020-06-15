using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISectionViewDataObject
    {
        public ISectionViewData ISectionViewDataInstance { get; set; }
        public ISectionViewDataObject(ISectionViewData ISectionViewDatainstance)
        {
            ISectionViewDataInstance = ISectionViewDatainstance;
        }
    }
    public static class ISectionViewDataInterface
    {
        //public static void GetFirstPlaneParameters(ISectionViewDataObject ISectionViewDatainstance, MathPoint&Object PlaneCenter, MathVector&Object PlaneVector)
        //{
        //    return ISectionViewDatainstance.ISectionViewDataInstance.GetFirstPlaneParameters(PlaneCenter, PlaneVector);
        //}
        //public static void GetSecondPlaneParameters(ISectionViewDataObject ISectionViewDatainstance, MathPoint&Object PlaneCenter, MathVector&Object PlaneVector)
        //{
        //    return ISectionViewDatainstance.ISectionViewDataInstance.GetSecondPlaneParameters(PlaneCenter, PlaneVector);
        //}
        //public static void GetThirdPlaneParameters(ISectionViewDataObject ISectionViewDatainstance, MathPoint&Object PlaneCenter, MathVector&Object PlaneVector)
        //{
        //    return ISectionViewDatainstance.ISectionViewDataInstance.GetThirdPlaneParameters(PlaneCenter, PlaneVector);
        //}
        public static IMathTransformObject GetDynamicCenterTransform(ISectionViewDataObject ISectionViewDatainstance, Int32 Index)
        {
            return new IMathTransformObject(ISectionViewDatainstance.ISectionViewDataInstance.GetDynamicCenterTransform(Index));
        }
        public static Object FirstPlane(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.FirstPlane;
        }
        public static Object SecondPlane(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SecondPlane;
        }
        public static Object ThirdPlane(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ThirdPlane;
        }
        public static Double FirstOffset(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.FirstOffset;
        }
        public static Double SecondOffset(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SecondOffset;
        }
        public static Double ThirdOffset(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ThirdOffset;
        }
        public static Double FirstRotationX(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.FirstRotationX;
        }
        public static Double SecondRotationX(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SecondRotationX;
        }
        public static Double ThirdRotationX(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ThirdRotationX;
        }
        public static Double FirstRotationY(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.FirstRotationY;
        }
        public static Double SecondRotationY(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SecondRotationY;
        }
        public static Double ThirdRotationY(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ThirdRotationY;
        }
        public static Int32 FirstColor(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.FirstColor;
        }
        public static Int32 SecondColor(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SecondColor;
        }
        public static Int32 ThirdColor(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ThirdColor;
        }
        public static Boolean FirstReverseDirection(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.FirstReverseDirection;
        }
        public static Boolean SecondReverseDirection(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SecondReverseDirection;
        }
        public static Boolean ThirdReverseDirection(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ThirdReverseDirection;
        }
        public static Boolean ShowSectionCap(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ShowSectionCap;
        }
        public static Boolean Redraw(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.Redraw;
        }
        public static Boolean KeepCapColor(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.KeepCapColor;
        }
        public static Boolean GraphicsOnlySection(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.GraphicsOnlySection;
        }
        public static Boolean ZonalSection(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ZonalSection;
        }
        public static Int32 SectionedZones(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SectionedZones;
        }
        public static Boolean SelectiveSection(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SelectiveSection;
        }
        public static Boolean ExcludeSelectedItems(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.ExcludeSelectedItems;
        }
        public static Object SelectiveSectioningList(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SelectiveSectioningList;
        }
        public static Boolean TransparentSection(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.TransparentSection;
        }
        public static Boolean SectionTransparentItemsTransparent(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.SectionTransparentItemsTransparent;
        }
        public static Double TransparencyValue(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.TransparencyValue;
        }
        public static Object TransparencyList(ISectionViewDataObject ISectionViewDatainstance)
        {
            return ISectionViewDatainstance.ISectionViewDataInstance.TransparencyList;
        }
    }
}
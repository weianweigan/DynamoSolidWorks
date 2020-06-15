using Autodesk.DesignScript.Runtime;
using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace DynamoSolidWorks
{
    public class IModelViewObject
    {
        public IModelView IModelViewInstance { get; set; }
        public IModelViewObject(IModelView IModelViewinstance)
        {
            IModelViewInstance = IModelViewinstance;
        }
    }
    public static class IModelViewInterface
    {
        public static Boolean SetCameraByName(IModelViewObject IModelViewinstance, String Name)
        {
            return IModelViewinstance.IModelViewInstance.SetCameraByName(Name);
        }
        public static Double GetIsoPlaneDistance(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetIsoPlaneDistance();
        }
        public static Int64 GetViewDIBx64(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetViewDIBx64();
        }
        public static void GetDIBHeaderx64(IModelViewObject IModelViewinstance, Int64 Ldib)
        {
            IModelViewinstance.IModelViewInstance.GetDIBHeaderx64(Ldib);
        }
        public static void GetStripsOfDIBx64(IModelViewObject IModelViewinstance, Int64 Ldib, Int32 NScanLinesPerStrip, Int32 StripIndex)
        {
            IModelViewinstance.IModelViewInstance.GetStripsOfDIBx64(Ldib, NScanLinesPerStrip, StripIndex);
        }
        public static Int64 GetViewHWndx64(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetViewHWndx64();
        }
        public static IMouseObject GetMouse(IModelViewObject IModelViewinstance)
        {
            return new IMouseObject(IModelViewinstance.IModelViewInstance.GetMouse());
        }
        public static void SectionAnnotationViewAttr(IModelViewObject IModelViewinstance, Boolean BarrayIn, Double DistIn, String LabelIn)
        {
            IModelViewinstance.IModelViewInstance.SectionAnnotationViewAttr(BarrayIn, DistIn, LabelIn);
        }
        public static void RollBy(IModelViewObject IModelViewinstance, Double Angle)
        {
            IModelViewinstance.IModelViewInstance.RollBy(Angle);
        }
        public static void TurnBy(IModelViewObject IModelViewinstance, Double XAngle, Double YAngle)
        {
            IModelViewinstance.IModelViewInstance.TurnBy(XAngle, YAngle);
        }
        public static void GraphicsRedraw(IModelViewObject IModelViewinstance, Object Rect)
        {
            IModelViewinstance.IModelViewInstance.GraphicsRedraw(Rect);
        }
        //public static void IGraphicsRedraw(IModelViewObject IModelViewinstance, Int32& Rect)
        //{
        //    return IModelViewinstance.IModelViewInstance.IGraphicsRedraw(Rect);
        //}
        public static void Activate(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.Activate();
        }
        public static Object GetVisibleBox(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetVisibleBox();
        }
        public static Int32 IGetVisibleBox(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.IGetVisibleBox();
        }
        public static Double GetBkgdImageDisplayAreaAspectRatio(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetBkgdImageDisplayAreaAspectRatio();
        }
        public static void ShowMagnifyingGlass(IModelViewObject IModelViewinstance, Double Ptx, Double Pty, Double Ptz, Double ZoomFactor, Boolean HideOnClick, Boolean FollowMouse)
        {
            IModelViewinstance.IModelViewInstance.ShowMagnifyingGlass(Ptx, Pty, Ptz, ZoomFactor, HideOnClick, FollowMouse);
        }
        public static void HideMagnifyingGlass(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.HideMagnifyingGlass();
        }
        public static void MoveMagnifyingGlass(IModelViewObject IModelViewinstance, Double Ptx, Double Pty, Double Ptz)
        {
            IModelViewinstance.IModelViewInstance.MoveMagnifyingGlass(Ptx, Pty, Ptz);
        }
        public static IModelDocObject GetModelDoc(IModelViewObject IModelViewinstance)
        {
            return new IModelDocObject(IModelViewinstance.IModelViewInstance.GetModelDoc());
        }
        public static ICalloutObject CreateCallout(IModelViewObject IModelViewinstance, Int32 NumberOfRows, Object LpHandler)
        {
            return new ICalloutObject(IModelViewinstance.IModelViewInstance.CreateCallout(NumberOfRows, LpHandler));
        }
        public static Int32 GetViewHWnd(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetViewHWnd();
        }
        public static void StartDynamics(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.StartDynamics();
        }
        public static void StopDynamics(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.StopDynamics();
        }
        public static void AddPerspective(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.AddPerspective();
        }
        public static void RemovePerspective(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.RemovePerspective();
        }
        public static Boolean HasPerspective(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.HasPerspective();
        }
        public static Object GetEyePoint(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetEyePoint();
        }
        //public static void IGetEyePoint(IModelViewObject IModelViewinstance, Double& Eyept)
        //{
        //    return IModelViewinstance.IModelViewInstance.IGetEyePoint(Eyept);
        //}
        public static Double GetViewPlaneDistance(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetViewPlaneDistance();
        }
        public static void InitializeShading(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.InitializeShading();
        }
        public static Boolean GetDisplayState(IModelViewObject IModelViewinstance, Int32 DisplayType)
        {
            return IModelViewinstance.IModelViewInstance.GetDisplayState(DisplayType);
        }
        public static Int32 GetViewDIB(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetViewDIB();
        }
        public static void ZoomByFactor(IModelViewObject IModelViewinstance, Double Factor)
        {
            IModelViewinstance.IModelViewInstance.ZoomByFactor(Factor);
        }
        public static void TranslateBy(IModelViewObject IModelViewinstance, Double X, Double Y)
        {
            IModelViewinstance.IModelViewInstance.TranslateBy(X, Y);
        }
        public static void RotateAboutCenter(IModelViewObject IModelViewinstance, Double XAngle, Double YAngle)
        {
            IModelViewinstance.IModelViewInstance.RotateAboutCenter(XAngle, YAngle);
        }
        public static void RotateAboutPoint(IModelViewObject IModelViewinstance, Double XAngle, Double YAngle, Double Ptx, Double Pty, Double Ptz)
        {
            IModelViewinstance.IModelViewInstance.RotateAboutPoint(XAngle, YAngle, Ptx, Pty, Ptz);
        }
        public static void RotateAboutAxis(IModelViewObject IModelViewinstance, Double Angle, Double Ptx, Double Pty, Double Ptz, Double AxisVecX, Double AxisVecY, Double AxisVecZ)
        {
            IModelViewinstance.IModelViewInstance.RotateAboutAxis(Angle, Ptx, Pty, Ptz, AxisVecX, AxisVecY, AxisVecZ);
        }
        public static Boolean SetEyePoint(IModelViewObject IModelViewinstance, Object Eyept)
        {
            return IModelViewinstance.IModelViewInstance.SetEyePoint(Eyept);
        }
        //public static Boolean ISetEyePoint(IModelViewObject IModelViewinstance, Double& Eyept)
        //{
        //    return IModelViewinstance.IModelViewInstance.ISetEyePoint(Eyept);
        //}
        public static Boolean SetStereoSeparation(IModelViewObject IModelViewinstance, Object DfSeparation)
        {
            return IModelViewinstance.IModelViewInstance.SetStereoSeparation(DfSeparation);
        }
        //public static Boolean ISetStereoSeparation(IModelViewObject IModelViewinstance, Double& DfSeparation)
        //{
        //    return IModelViewinstance.IModelViewInstance.ISetStereoSeparation(DfSeparation);
        //}
        public static Object GetStereoSeparation(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetStereoSeparation();
        }
        public static Double IGetStereoSeparation(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.IGetStereoSeparation();
        }
        public static void GetDIBHeader(IModelViewObject IModelViewinstance, Int32 Ldib)
        {
            IModelViewinstance.IModelViewInstance.GetDIBHeader(Ldib);
        }
        public static void GetStripsOfDIB(IModelViewObject IModelViewinstance, Int32 Ldib, Int32 NScanLinesPerStrip, Int32 StripIndex)
        {
            IModelViewinstance.IModelViewInstance.GetStripsOfDIB(Ldib, NScanLinesPerStrip, StripIndex);
        }
        public static void DrawHighlightedItems(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.DrawHighlightedItems();
        }
        public static Object GetNext(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.GetNext();
        }
        public static IModelViewObject IGetNext(IModelViewObject IModelViewinstance)
        {
            return new IModelViewObject(IModelViewinstance.IModelViewInstance.IGetNext());
        }
        [MultiReturn(SWValueConst.Outx, SWValueConst.Outy, SWValueConst.Outz)]
        public static Dictionary<string, double> ProjectModelPoint(IModelViewObject IModelViewinstance, Double X, Double Y, Double Z)
        {
            IModelViewinstance.IModelViewInstance.ProjectModelPoint(X, Y, Z, out double XOut, out double YOut, out double ZOut);
            return new Dictionary<string, double>() { { SWValueConst.Outx, XOut }, { SWValueConst.Outy, YOut }, { SWValueConst.Outz, ZOut } };
        }
        [MultiReturn(SWValueConst.Outx, SWValueConst.Outy, SWValueConst.Outz)]
        public static Dictionary<string, double> UnprojectModelPoint(IModelViewObject IModelViewinstance, Double X, Double Y, Double Z)
        {
            IModelViewinstance.IModelViewInstance.UnprojectModelPoint(X, Y, Z, out double XOut, out double YOut, out double ZOut);
            return new Dictionary<string, double>() { { SWValueConst.Outx, XOut }, { SWValueConst.Outy, YOut }, { SWValueConst.Outz, ZOut } };

        }
        public static void DrawTransparentFeatureTree(IModelViewObject IModelViewinstance)
        {
            IModelViewinstance.IModelViewInstance.DrawTransparentFeatureTree();
        }
        public static Object Xform(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Xform;
        }
        public static Object Orientation(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Orientation;
        }
        public static Object Translation(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Translation;
        }
        public static Double Scale(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Scale;
        }
        public static IMathTransformObject IXform(IModelViewObject IModelViewinstance)
        {
            return new IMathTransformObject(IModelViewinstance.IModelViewInstance.Xform.CastObj<IMathTransform>());
        }
        public static object IOrientation(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Orientation;
        }
        public static object ITranslation(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Translation;
        }
        public static Object Orientation2(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Orientation2;
        }
        public static Object Translation2(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Translation2;
        }
        public static object IOrientation2(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Orientation2;
        }
        public static object ITranslation2(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Translation2;
        }
        public static Int32 FrameLeft(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.FrameLeft;
        }
        public static Int32 FrameTop(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.FrameTop;
        }
        public static Int32 FrameWidth(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.FrameWidth;
        }
        public static Int32 FrameHeight(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.FrameHeight;
        }
        public static Int32 FrameState(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.FrameState;
        }
        public static Double ObjectSizesAway(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.ObjectSizesAway;
        }
        public static Int32 DynamicMode(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.DynamicMode;
        }
        public static Double Scale2(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Scale2;
        }
        public static Int32 HlrQuality(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.HlrQuality;
        }
        public static Boolean XorHighlight(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.XorHighlight;
        }
        public static Boolean DisplayZebraStripes(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.DisplayZebraStripes;
        }
        public static IMathTransformObject Transform(IModelViewObject IModelViewinstance)
        {
            return new IMathTransformObject(IModelViewinstance.IModelViewInstance.Transform);
        }
        public static IMathTransformObject Orientation3(IModelViewObject IModelViewinstance)
        {
            return new IMathTransformObject(IModelViewinstance.IModelViewInstance.Orientation3);
        }
        public static IMathVectorObject Translation3(IModelViewObject IModelViewinstance)
        {
            return new IMathVectorObject(IModelViewinstance.IModelViewInstance.Translation3);
        }
        public static Boolean SuppressWaitCursorDuringRedraw(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.SuppressWaitCursorDuringRedraw;
        }
        public static Int32 DisplayMode(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.DisplayMode;
        }
        public static Boolean EnableGraphicsUpdate(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.EnableGraphicsUpdate;
        }
        public static ICameraObject Camera(IModelViewObject IModelViewinstance)
        {
            return new ICameraObject(IModelViewinstance.IModelViewInstance.Camera);
        }
        public static Boolean Linked(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.Linked;
        }
        public static Boolean VisibilityViewTools(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.VisibilityViewTools;
        }
        public static Boolean UpdateAllGraphicsLayers(IModelViewObject IModelViewinstance)
        {
            return IModelViewinstance.IModelViewInstance.UpdateAllGraphicsLayers;
        }
    }
}
using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISelectionMgrObject
    {
        public ISelectionMgr ISelectionMgrInstance { get; set; }
        public ISelectionMgrObject(ISelectionMgr ISelectionMgrinstance)
        {
            ISelectionMgrInstance = ISelectionMgrinstance;
        }
    }
    public static class ISelectionMgrInterface
    {
        public static Int32 GetSelectedObjectCount(ISelectionMgrObject ISelectionMgrinstance)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectCount();
        }
        public static Int32 GetSelectedObjectType(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectType(AtIndex);
        }
        public static Object GetSelectedObject(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObject(AtIndex);
        }
        public static Object IGetSelectedObject(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectedObject(AtIndex);
        }
        public static Object GetSelectionPoint(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectionPoint(AtIndex);
        }
        public static Object GetSelectionPointInSketchSpace(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectionPointInSketchSpace(AtIndex);
        }
        public static Object GetSelectedObject2(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObject2(AtIndex);
        }
        public static Object IGetSelectedObject2(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectedObject2(AtIndex);
        }
        public static Boolean IsInEditTarget(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IsInEditTarget(AtIndex);
        }
        public static Object GetSelectedObjectsComponent(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectsComponent(AtIndex);
        }
        public static IComponentObject IGetSelectedObjectsComponent(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return new IComponentObject(ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectedObjectsComponent(AtIndex));
        }
        public static Object GetSelectedObject3(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObject3(AtIndex);
        }
        public static Object IGetSelectedObject3(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectedObject3(AtIndex);
        }
        public static Int32 GetSelectedObjectType2(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectType2(AtIndex);
        }
        public static Double IGetSelectionPoint(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectionPoint(AtIndex);
        }
        public static Double IGetSelectionPointInSketchSpace(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectionPointInSketchSpace(AtIndex);
        }
        public static Int32 GetSelectedObjectMark(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectMark(AtIndex);
        }
        public static Boolean SetSelectedObjectMark(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex, Int32 Mark, Int32 Action)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.SetSelectedObjectMark(AtIndex, Mark, Action);
        }
        public static Int32 DeSelect(ISelectionMgrObject ISelectionMgrinstance, Object AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.DeSelect(AtIndex);
        }
        //public static Int32 IDeSelect(ISelectionMgrObject ISelectionMgrinstance, Int32 Count, Int32& AtIndex)
        //{
        //    return ISelectionMgrinstance.ISelectionMgrInstance.IDeSelect(Count, AtIndex);
        //}
        public static IComponent2Object IGetSelectedObjectsComponent2(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return new IComponent2Object(ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectedObjectsComponent2(AtIndex));
        }
        public static ICalloutObject CreateCallout(ISelectionMgrObject ISelectionMgrinstance)
        {
            return new ICalloutObject(ISelectionMgrinstance.ISelectionMgrInstance.CreateCallout());
        }
        public static IViewObject GetSelectedObjectsDrawingView(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return new IViewObject(ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectsDrawingView(AtIndex));
        }
        public static Boolean SetSelectionPoint(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex, Double X, Double Y, Double Z)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.SetSelectionPoint(AtIndex, X, Y, Z);
        }
        public static Object GetSelectedObject4(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObject4(AtIndex);
        }
        public static Object IGetSelectedObject4(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectedObject4(AtIndex);
        }
        public static Object GetSelectedObject5(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObject5(AtIndex);
        }
        public static Object GetSelectedObjectsComponent2(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectsComponent2(AtIndex);
        }
        public static ISelectDataObject CreateSelectData(ISelectionMgrObject ISelectionMgrinstance)
        {
            return new ISelectDataObject(ISelectionMgrinstance.ISelectionMgrInstance.CreateSelectData());
        }
        public static ILoop2Object GetSelectedObjectLoop(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex)
        {
            return new ILoop2Object(ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectLoop(AtIndex));
        }
        public static void ClearSelectionColors(ISelectionMgrObject ISelectionMgrinstance)
        {
            ISelectionMgrinstance.ISelectionMgrInstance.ClearSelectionColors();
        }
        public static Int32 GetSelectedObjectCount2(ISelectionMgrObject ISelectionMgrinstance, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectCount2(Mark);
        }
        public static Int32 GetSelectedObjectType3(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectType3(Index, Mark);
        }
        public static Object GetSelectedObject6(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObject6(Index, Mark);
        }
        public static Object GetSelectionPoint2(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectionPoint2(Index, Mark);
        }
        public static Double IGetSelectionPoint2(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectionPoint2(Index, Mark);
        }
        public static Boolean SetSelectionPoint2(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark, Double X, Double Y, Double Z)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.SetSelectionPoint2(Index, Mark, X, Y, Z);
        }
        public static Object GetSelectionPointInSketchSpace2(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectionPointInSketchSpace2(Index, Mark);
        }
        public static Double IGetSelectionPointInSketchSpace2(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IGetSelectionPointInSketchSpace2(Index, Mark);
        }
        public static Boolean IsInEditTarget2(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.IsInEditTarget2(Index, Mark);
        }
        public static IComponent2Object GetSelectedObjectsComponent3(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return new IComponent2Object(ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectsComponent3(Index, Mark));
        }
        public static Int32 DeSelect2(ISelectionMgrObject ISelectionMgrinstance, Object AtIndex, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.DeSelect2(AtIndex, Mark);
        }
        //public static Int32 IDeSelect2(ISelectionMgrObject ISelectionMgrinstance, Int32 Count, Int32& AtIndex, Int32 Mark)
        //{
        //    return ISelectionMgrinstance.ISelectionMgrInstance.IDeSelect2(Count, AtIndex, Mark);
        //}
        public static IViewObject GetSelectedObjectsDrawingView2(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return new IViewObject(ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectsDrawingView2(Index, Mark));
        }
        public static ILoop2Object GetSelectedObjectLoop2(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return new ILoop2Object(ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectLoop2(Index, Mark));
        }
        public static Boolean SetCallout(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, ICalloutObject PCallout)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.SetCallout(Index, PCallout?.ICalloutInstance?.CastObj<Callout>());
        }
        public static ICalloutObject CreateCallout2(ISelectionMgrObject ISelectionMgrinstance, Int32 NumberOfRows, Object LpHandler)
        {
            return new ICalloutObject(ISelectionMgrinstance.ISelectionMgrInstance.CreateCallout2(NumberOfRows, LpHandler));
        }
        public static IFace2Object GetSelectedObjectsFace(ISelectionMgrObject ISelectionMgrinstance, Int32 AtIndex, Int32 Mark)
        {
            return new IFace2Object(ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectsFace(AtIndex, Mark));
        }
        public static Object GetPreSelectedObject(ISelectionMgrObject ISelectionMgrinstance)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetPreSelectedObject();
        }
        public static Int32 SuspendSelectionList(ISelectionMgrObject ISelectionMgrinstance)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.SuspendSelectionList();
        }
        public static void ResumeSelectionList(ISelectionMgrObject ISelectionMgrinstance)
        {
            ISelectionMgrinstance.ISelectionMgrInstance.ResumeSelectionList();
        }
        public static Int32 AddSelectionListObjects(ISelectionMgrObject ISelectionMgrinstance, Object Objects, Object SelectData)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.AddSelectionListObjects(Objects, SelectData);
        }
        public static Boolean AddSelectionListObject(ISelectionMgrObject ISelectionMgrinstance, Object Object, Object SelectData)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.AddSelectionListObject(Object, SelectData);
        }
        public static Object GetSelectedObjectsComponent4(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, Int32 Mark)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectedObjectsComponent4(Index, Mark);
        }
        //public static Boolean GetSelectionSpecification(ISelectionMgrObject ISelectionMgrinstance, Int32 Index, String& SelectByString, String& ObjectType, Int32& Type, Double& X, Double& Y, Double& Z)
        //{
        //    return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectionSpecification(Index, SelectByString, ObjectType, Type, X, Y, Z);
        //}
        //public static Boolean GetSelectByIdSpecification(ISelectionMgrObject ISelectionMgrinstance, Object Object, String& SelectByString, String& ObjectType, Int32& Type)
        //{
        //    return ISelectionMgrinstance.ISelectionMgrInstance.GetSelectByIdSpecification(Object, SelectByString, ObjectType, Type);
        //}
        public static Boolean EnableContourSelection(ISelectionMgrObject ISelectionMgrinstance)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.EnableContourSelection;
        }
        //public static Int32 SelectionColor(ISelectionMgrObject ISelectionMgrinstance)
        //{
        //    return ISelectionMgrinstance.ISelectionMgrInstance.SelectionColor;
        //}
        public static Boolean EnableSelection(ISelectionMgrObject ISelectionMgrinstance)
        {
            return ISelectionMgrinstance.ISelectionMgrInstance.EnableSelection;
        }
    }
}
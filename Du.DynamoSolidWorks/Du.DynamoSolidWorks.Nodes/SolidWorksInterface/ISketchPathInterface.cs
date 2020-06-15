using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchPathObject
    {
        public ISketchPath ISketchPathInstance { get; set; }
        public ISketchPathObject(ISketchPath ISketchPathinstance)
        {
            ISketchPathInstance = ISketchPathinstance;
        }
    }
    public static class ISketchPathInterface
    {
        public static Boolean Select(ISketchPathObject ISketchPathinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISketchPathinstance.ISketchPathInstance.Select(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
        public static ISketchObject GetSketch(ISketchPathObject ISketchPathinstance)
        {
            return new ISketchObject(ISketchPathinstance.ISketchPathInstance.GetSketch());
        }
        public static Object GetConstraints(ISketchPathObject ISketchPathinstance)
        {
            return ISketchPathinstance.ISketchPathInstance.GetConstraints();
        }
        public static Int32 GetConstraintsCount(ISketchPathObject ISketchPathinstance)
        {
            return ISketchPathinstance.ISketchPathInstance.GetConstraintsCount();
        }
        public static String IGetConstraints(ISketchPathObject ISketchPathinstance, Int32 Count)
        {
            return ISketchPathinstance.ISketchPathInstance.IGetConstraints(Count);
        }
        public static Object GetRelations(ISketchPathObject ISketchPathinstance)
        {
            return ISketchPathinstance.ISketchPathInstance.GetRelations();
        }
        public static Int32 GetRelationsCount(ISketchPathObject ISketchPathinstance)
        {
            return ISketchPathinstance.ISketchPathInstance.GetRelationsCount();
        }
        public static ISketchRelationObject IGetRelations(ISketchPathObject ISketchPathinstance, Int32 Count)
        {
            return new ISketchRelationObject(ISketchPathinstance.ISketchPathInstance.IGetRelations(Count));
        }
        public static Double GetLength(ISketchPathObject ISketchPathinstance)
        {
            return ISketchPathinstance.ISketchPathInstance.GetLength();
        }
        public static Object GetSketchSegments(ISketchPathObject ISketchPathinstance)
        {
            return ISketchPathinstance.ISketchPathInstance.GetSketchSegments();
        }
        public static Int32 GetSketchSegmentCount(ISketchPathObject ISketchPathinstance)
        {
            return ISketchPathinstance.ISketchPathInstance.GetSketchSegmentCount();
        }
        public static ISketchSegmentObject IGetSketchSegments(ISketchPathObject ISketchPathinstance, Int32 Count)
        {
            return new ISketchSegmentObject(ISketchPathinstance.ISketchPathInstance.IGetSketchSegments(Count));
        }
    }
}
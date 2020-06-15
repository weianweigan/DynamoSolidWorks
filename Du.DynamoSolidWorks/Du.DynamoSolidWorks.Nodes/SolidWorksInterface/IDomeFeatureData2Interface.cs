using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDomeFeatureData2Object
    {
        public IDomeFeatureData2 IDomeFeatureData2Instance { get; set; }
        public IDomeFeatureData2Object(IDomeFeatureData2 IDomeFeatureData2instance)
        {
            IDomeFeatureData2Instance = IDomeFeatureData2instance;
        }
    }
    public static class IDomeFeatureData2Interface
    {
        public static Boolean AccessSelections(IDomeFeatureData2Object IDomeFeatureData2instance, Object TopDoc, Object Component)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IDomeFeatureData2Object IDomeFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            IDomeFeatureData2instance.IDomeFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Int32 GetFaceCount(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.GetFaceCount();
        }
        public static IFace2Object IGetFaces(IDomeFeatureData2Object IDomeFeatureData2instance, Int32 FaceCount)
        {
            return new IFace2Object(IDomeFeatureData2instance.IDomeFeatureData2Instance.IGetFaces(FaceCount));
        }
        //public static void ISetFaces(IDomeFeatureData2Object IDomeFeatureData2instance, Int32 FaceCount, Face2&Object FaceList)
        //{
        //    return IDomeFeatureData2instance.IDomeFeatureData2Instance.ISetFaces(FaceCount, FaceList);
        //}
        public static Double Height(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.Height;
        }
        public static Boolean ReverseDir(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.ReverseDir;
        }
        public static Boolean Elliptical(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.Elliptical;
        }
        public static Object Face(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.Face;
        }
        public static IFace2Object IFace(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return new IFace2Object(IDomeFeatureData2instance.IDomeFeatureData2Instance.IFace);
        }
        public static Object ConstraintPointOrSketch(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.ConstraintPointOrSketch;
        }
        public static Object Direction(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.Direction;
        }
        public static Object Faces(IDomeFeatureData2Object IDomeFeatureData2instance)
        {
            return IDomeFeatureData2instance.IDomeFeatureData2Instance.Faces;
        }
    }
}
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILibraryFeatureDataObject
    {
        public ILibraryFeatureData ILibraryFeatureDataInstance { get; set; }
        public ILibraryFeatureDataObject(ILibraryFeatureData ILibraryFeatureDatainstance)
        {
            ILibraryFeatureDataInstance = ILibraryFeatureDatainstance;
        }
    }
    public static class ILibraryFeatureDataInterface
    {
        public static Boolean AccessSelections(ILibraryFeatureDataObject ILibraryFeatureDatainstance, IModelDoc2Object PTopDoc, IComponent2Object PComponent)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.AccessSelections(PTopDoc.IModelDoc2Instance as ModelDoc2, PComponent.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(ILibraryFeatureDataObject ILibraryFeatureDatainstance)
        {
            ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static Object GetPlacementPlane(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32& Type)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetPlacementPlane(Type);
        //}
        public static void SetPlacementPlane(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Object PDispIn)
        {
            ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.SetPlacementPlane(PDispIn);
        }
        //public static Object GetReferences(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Object& RefType)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetReferences(RefType);
        //}
        public static void SetReferences(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Object RefVar)
        {
            ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.SetReferences(RefVar);
        }
        public static Int32 GetReferencesCount(ILibraryFeatureDataObject ILibraryFeatureDatainstance)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetReferencesCount();
        }
        //public static Object IGetReferences(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Count, Int32& RefType)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.IGetReferences(Count, RefType);
        //}
        //public static void ISetReferences(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Count, Object& RefVar)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.ISetReferences(Count, RefVar);
        //}
        //public static Object GetDimensions(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Type, Object& DimName)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetDimensions(Type, DimName);
        //}
        public static Boolean SetDimension(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Type, String DimName, Double DimVal)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.SetDimension(Type, DimName, DimVal);
        }
        public static Int32 GetDimensionsCount(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Type)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetDimensionsCount(Type);
        }
        //public static Double IGetDimensions(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Type, Int32 Count, String& DimName)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.IGetDimensions(Type, Count, DimName);
        //}
        public static Int32 GetConfigurationCount(ILibraryFeatureDataObject ILibraryFeatureDatainstance)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetConfigurationCount();
        }
        public static Object GetAllConfigurationNames(ILibraryFeatureDataObject ILibraryFeatureDatainstance)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetAllConfigurationNames();
        }
        public static String IGetAllConfigurationNames(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Count)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.IGetAllConfigurationNames(Count);
        }
        public static Boolean Initialize(ILibraryFeatureDataObject ILibraryFeatureDatainstance, String FileNameIn)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.Initialize(FileNameIn);
        }
        //public static Object GetPlacementPlane2(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Scope, Int32& Type)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetPlacementPlane2(Scope, Type);
        //}
        //public static Object GetReferences2(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Scope, Object& RefType)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetReferences2(Scope, RefType);
        //}
        //public static Object IGetReferences2(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Scope, Int32 Count, Int32& RefType)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.IGetReferences2(Scope, Count, RefType);
        //}
        //public static Object GetReferences3(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Scope, Object& RefType, Object& RefName)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.GetReferences3(Scope, RefType, RefName);
        //}
        //public static Object IGetReferences3(ILibraryFeatureDataObject ILibraryFeatureDatainstance, Int32 Scope, Int32 Count, Int32& RefType, String& RefName)
        //{
        //    return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.IGetReferences3(Scope, Count, RefType, RefName);
        //}
        public static String ConfigurationName(ILibraryFeatureDataObject ILibraryFeatureDatainstance)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.ConfigurationName;
        }
        public static Boolean LinkToLibraryPart(ILibraryFeatureDataObject ILibraryFeatureDatainstance)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.LinkToLibraryPart;
        }
        public static Boolean OverrideDimension(ILibraryFeatureDataObject ILibraryFeatureDatainstance)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.OverrideDimension;
        }
        public static String LibraryPart(ILibraryFeatureDataObject ILibraryFeatureDatainstance)
        {
            return ILibraryFeatureDatainstance.ILibraryFeatureDataInstance.LibraryPart;
        }
    }
}
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISymmetricMateFeatureDataObject
    {
        public ISymmetricMateFeatureData ISymmetricMateFeatureDataInstance { get; set; }
        public ISymmetricMateFeatureDataObject(ISymmetricMateFeatureData ISymmetricMateFeatureDatainstance)
        {
            ISymmetricMateFeatureDataInstance = ISymmetricMateFeatureDatainstance;
        }
    }
    public static class ISymmetricMateFeatureDataInterface
    {
        public static Object SymmetryPlane(ISymmetricMateFeatureDataObject ISymmetricMateFeatureDatainstance)
        {
            return ISymmetricMateFeatureDatainstance.ISymmetricMateFeatureDataInstance.SymmetryPlane;
        }
        public static Object EntitiesToMate(ISymmetricMateFeatureDataObject ISymmetricMateFeatureDatainstance)
        {
            return ISymmetricMateFeatureDatainstance.ISymmetricMateFeatureDataInstance.EntitiesToMate;
        }
        public static Int32 MateAlignment(ISymmetricMateFeatureDataObject ISymmetricMateFeatureDatainstance)
        {
            return ISymmetricMateFeatureDatainstance.ISymmetricMateFeatureDataInstance.MateAlignment;
        }
    }
}
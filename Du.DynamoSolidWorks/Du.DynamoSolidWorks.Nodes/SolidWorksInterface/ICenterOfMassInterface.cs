using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICenterOfMassObject
    {
        public ICenterOfMass ICenterOfMassInstance { get; set; }
        public ICenterOfMassObject(ICenterOfMass ICenterOfMassinstance)
        {
            ICenterOfMassInstance = ICenterOfMassinstance;
        }
    }
    public static class ICenterOfMassInterface
    {
        public static Object GetNext(ICenterOfMassObject ICenterOfMassinstance)
        {
            return ICenterOfMassinstance.ICenterOfMassInstance.GetNext();
        }
        public static ICenterOfMassObject IGetNext(ICenterOfMassObject ICenterOfMassinstance)
        {
            return new ICenterOfMassObject(ICenterOfMassinstance.ICenterOfMassInstance.IGetNext());
        }
        public static Object GetAnnotation(ICenterOfMassObject ICenterOfMassinstance)
        {
            return ICenterOfMassinstance.ICenterOfMassInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(ICenterOfMassObject ICenterOfMassinstance)
        {
            return new IAnnotationObject(ICenterOfMassinstance.ICenterOfMassInstance.IGetAnnotation());
        }
        public static Object GetCoordinates(ICenterOfMassObject ICenterOfMassinstance)
        {
            return ICenterOfMassinstance.ICenterOfMassInstance.GetCoordinates();
        }
        public static Double IGetCoordinates(ICenterOfMassObject ICenterOfMassinstance)
        {
            return ICenterOfMassinstance.ICenterOfMassInstance.IGetCoordinates();
        }
    }
}
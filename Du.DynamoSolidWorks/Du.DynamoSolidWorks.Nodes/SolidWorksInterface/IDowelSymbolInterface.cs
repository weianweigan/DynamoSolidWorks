using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDowelSymbolObject
    {
        public IDowelSymbol IDowelSymbolInstance { get; set; }
        public IDowelSymbolObject(IDowelSymbol IDowelSymbolinstance)
        {
            IDowelSymbolInstance = IDowelSymbolinstance;
        }
    }
    public static class IDowelSymbolInterface
    {
        public static Object GetNext(IDowelSymbolObject IDowelSymbolinstance)
        {
            return IDowelSymbolinstance.IDowelSymbolInstance.GetNext();
        }
        public static IDowelSymbolObject IGetNext(IDowelSymbolObject IDowelSymbolinstance)
        {
            return new IDowelSymbolObject(IDowelSymbolinstance.IDowelSymbolInstance.IGetNext());
        }
        public static Object GetAnnotation(IDowelSymbolObject IDowelSymbolinstance)
        {
            return IDowelSymbolinstance.IDowelSymbolInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(IDowelSymbolObject IDowelSymbolinstance)
        {
            return new IAnnotationObject(IDowelSymbolinstance.IDowelSymbolInstance.IGetAnnotation());
        }
        public static Object GetArcPoints(IDowelSymbolObject IDowelSymbolinstance)
        {
            return IDowelSymbolinstance.IDowelSymbolInstance.GetArcPoints();
        }
        public static Double IGetArcPoints(IDowelSymbolObject IDowelSymbolinstance)
        {
            return IDowelSymbolinstance.IDowelSymbolInstance.IGetArcPoints();
        }
        public static Boolean Flipped(IDowelSymbolObject IDowelSymbolinstance)
        {
            return IDowelSymbolinstance.IDowelSymbolInstance.Flipped;
        }
    }
}
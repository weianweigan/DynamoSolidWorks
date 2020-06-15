using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using SolidWorks.Interop.swconst;
using DynamoSolidWorks;
using Du.SolidWorks.Extension;
using Autodesk.DesignScript.Runtime;
using Du.DynamoSolidWorks.Nodes;

namespace DynamoSolidWorks
{
    public class IEnumDrSectionsObject
    {
        public IEnumDrSections IEnumDrSectionsInstance { get; set; }
        public IEnumDrSectionsObject(IEnumDrSections IEnumDrSectionsinstance)
        {
            IEnumDrSectionsInstance = IEnumDrSectionsinstance;
        }
    }
    public static class IEnumDrSectionsInterface
    {
        public static void Next(IEnumDrSectionsObject IEnumDrSectionsinstance, Int32 Celt, DrSection&Object Rgelt, Int32& PceltFetched)
        {
            return IEnumDrSectionsinstance.IEnumDrSectionsInstance.Next(Celt, Rgelt, PceltFetched);
        }
        public static void Skip(IEnumDrSectionsObject IEnumDrSectionsinstance, Int32 Celt)
        {
             IEnumDrSectionsinstance.IEnumDrSectionsInstance.Skip(Celt);
        }
        public static void Reset(IEnumDrSectionsObject IEnumDrSectionsinstance)
        {
             IEnumDrSectionsinstance.IEnumDrSectionsInstance.Reset();
        }
        public static void Clone(IEnumDrSectionsObject IEnumDrSectionsinstance, EnumDrSections&Object Ppenum)
        {
            return IEnumDrSectionsinstance.IEnumDrSectionsInstance.Clone(Ppenum);
        }
    }
}
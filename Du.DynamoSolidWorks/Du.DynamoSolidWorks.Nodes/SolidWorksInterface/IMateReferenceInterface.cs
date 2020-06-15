using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMateReferenceObject
    {
        public IMateReference IMateReferenceInstance { get; set; }
        public IMateReferenceObject(IMateReference IMateReferenceinstance)
        {
            IMateReferenceInstance = IMateReferenceinstance;
        }
    }
    public static class IMateReferenceInterface
    {
        public static Boolean Edit(IMateReferenceObject IMateReferenceinstance, String BstrMateReferenceName, IEntityObject PrimaryReferenceEntity, Int32 PrimaryReferenceType, Int32 PrimaryReferenceAlignment, IEntityObject SecondaryReferenceEntity, Int32 SecondaryReferenceType, Int32 SecondaryReferenceAlignment, IEntityObject TertiaryReferenceEntity, Int32 TertiaryReferenceType, Int32 TertiaryReferenceAlignment)
        {
            return IMateReferenceinstance.IMateReferenceInstance.Edit(BstrMateReferenceName, PrimaryReferenceEntity.IEntityInstance as Entity, PrimaryReferenceType, PrimaryReferenceAlignment, SecondaryReferenceEntity.IEntityInstance as Entity, SecondaryReferenceType, SecondaryReferenceAlignment, TertiaryReferenceEntity.IEntityInstance as Entity, TertiaryReferenceType, TertiaryReferenceAlignment);
        }
        public static String Name(IMateReferenceObject IMateReferenceinstance)
        {
            return IMateReferenceinstance.IMateReferenceInstance.Name;
        }
        public static Int32 ReferenceEntityCount(IMateReferenceObject IMateReferenceinstance)
        {
            return IMateReferenceinstance.IMateReferenceInstance.ReferenceEntityCount;
        }
        public static IEntityObject ReferenceEntity(IMateReferenceObject IMateReferenceinstance, int Index)
        {
            return new IEntityObject(IMateReferenceinstance.IMateReferenceInstance.ReferenceEntity[Index]);
        }
        public static Int32 ReferenceType(IMateReferenceObject IMateReferenceinstance, int Index)
        {
            return IMateReferenceinstance.IMateReferenceInstance.ReferenceType[Index];
        }
        public static Int32 ReferenceAlignment(IMateReferenceObject IMateReferenceinstance, int Index)
        {
            return IMateReferenceinstance.IMateReferenceInstance.ReferenceAlignment[Index];
        }
        public static Object ReferenceEntity2(IMateReferenceObject IMateReferenceinstance, int Index)
        {
            return IMateReferenceinstance.IMateReferenceInstance.ReferenceEntity2[Index];
        }
        public static Int32 ReferenceEntityType(IMateReferenceObject IMateReferenceinstance, int Index)
        {
            return IMateReferenceinstance.IMateReferenceInstance.ReferenceEntityType[Index];
        }
    }
}
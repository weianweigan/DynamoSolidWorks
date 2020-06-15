using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBodyFolderObject
    {
        public IBodyFolder IBodyFolderInstance { get; set; }
        public IBodyFolderObject(IBodyFolder IBodyFolderinstance)
        {
            IBodyFolderInstance = IBodyFolderinstance;
        }
    }
    public static class IBodyFolderInterface
    {
        public static IFeatureObject GetFeature(IBodyFolderObject IBodyFolderinstance)
        {
            return new IFeatureObject(IBodyFolderinstance.IBodyFolderInstance.GetFeature());
        }
        public static Int32 GetBodyCount(IBodyFolderObject IBodyFolderinstance)
        {
            return IBodyFolderinstance.IBodyFolderInstance.GetBodyCount();
        }
        public static Object GetBodies(IBodyFolderObject IBodyFolderinstance)
        {
            return IBodyFolderinstance.IBodyFolderInstance.GetBodies();
        }
        public static IBody2Object IGetBodies(IBodyFolderObject IBodyFolderinstance, Int32 Count)
        {
            return new IBody2Object(IBodyFolderinstance.IBodyFolderInstance.IGetBodies(Count));
        }
        public static Boolean GetAutomaticCutList(IBodyFolderObject IBodyFolderinstance)
        {
            return IBodyFolderinstance.IBodyFolderInstance.GetAutomaticCutList();
        }
        public static Boolean SetAutomaticCutList(IBodyFolderObject IBodyFolderinstance, Boolean CutList)
        {
            return IBodyFolderinstance.IBodyFolderInstance.SetAutomaticCutList(CutList);
        }
        public static Boolean UpdateCutList(IBodyFolderObject IBodyFolderinstance)
        {
            return IBodyFolderinstance.IBodyFolderInstance.UpdateCutList();
        }
        public static Int32 GetCutListType(IBodyFolderObject IBodyFolderinstance)
        {
            return IBodyFolderinstance.IBodyFolderInstance.GetCutListType();
        }
        public static Boolean GetAutomaticUpdate(IBodyFolderObject IBodyFolderinstance)
        {
            return IBodyFolderinstance.IBodyFolderInstance.GetAutomaticUpdate();
        }
        public static Boolean SetAutomaticUpdate(IBodyFolderObject IBodyFolderinstance, Boolean Update)
        {
            return IBodyFolderinstance.IBodyFolderInstance.SetAutomaticUpdate(Update);
        }
        public static Int32 Type(IBodyFolderObject IBodyFolderinstance)
        {
            return IBodyFolderinstance.IBodyFolderInstance.Type;
        }
    }
}


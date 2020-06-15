using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBomFeatureObject
    {
        public IBomFeature IBomFeatureInstance { get; set; }
        public IBomFeatureObject(IBomFeature IBomFeatureinstance)
        {
            IBomFeatureInstance = IBomFeatureinstance;
        }
    }
    public static class IBomFeatureInterface
    {
        public static IFeatureObject GetFeature(IBomFeatureObject IBomFeatureinstance)
        {
            return new IFeatureObject(IBomFeatureinstance.IBomFeatureInstance.GetFeature());
        }
        public static Int32 GetTableAnnotationCount(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.GetTableAnnotations();
        }
        public static IBomTableAnnotationObject IGetTableAnnotations(IBomFeatureObject IBomFeatureinstance, Int32 Count)
        {
            return new IBomTableAnnotationObject(IBomFeatureinstance.IBomFeatureInstance.IGetTableAnnotations(Count));
        }
        public static Int32 GetConfigurationCount(IBomFeatureObject IBomFeatureinstance, Boolean OnlyVisible)
        {
            return IBomFeatureinstance.IBomFeatureInstance.GetConfigurationCount(OnlyVisible);
        }
        //ref not solve
        public static Object GetConfigurations(IBomFeatureObject IBomFeatureinstance, Boolean OnlyVisible, Object Visible)
        {
            return IBomFeatureinstance.IBomFeatureInstance.GetConfigurations(OnlyVisible, Visible);
        }
        //ref not solve
        public static String IGetConfigurations(IBomFeatureObject IBomFeatureinstance, Boolean OnlyVisible, Int32 Count, Boolean Visible)
        {
            return IBomFeatureinstance.IBomFeatureInstance.IGetConfigurations(OnlyVisible, Count, Visible);
        }
        public static Boolean SetConfigurations(IBomFeatureObject IBomFeatureinstance, Boolean OnlyVisible, Object Visible, Object Names)
        {
            return IBomFeatureinstance.IBomFeatureInstance.SetConfigurations(OnlyVisible, Visible, Names);
        }

        //ref not solve
        public static Boolean ISetConfigurations(IBomFeatureObject IBomFeatureinstance, Boolean OnlyVisible, Int32 Count, Boolean Visible, String Names)
        {
            return IBomFeatureinstance.IBomFeatureInstance.ISetConfigurations(OnlyVisible, Count, Visible, Names);
        }
        public static Boolean FollowAssemblyOrder(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.FollowAssemblyOrder();
        }
        public static String GetReferencedModelName(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.GetReferencedModelName();
        }
        public static Int32 TableType(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.TableType;
        }
        public static String Configuration(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.Configuration;
        }
        public static Boolean KeepMissingItems(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.KeepMissingItems;
        }
        public static Boolean StrikeoutMissingItems(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.StrikeoutMissingItems;
        }
        public static Int32 ZeroQuantityDisplay(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.ZeroQuantityDisplay;
        }
        public static Int32 SequenceStartNumber(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.SequenceStartNumber;
        }
        public static Boolean DisplayAsOneItem(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.DisplayAsOneItem;
        }
        public static Boolean KeepCurrentItemNumbers(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.KeepCurrentItemNumbers;
        }
        public static Boolean FollowAssemblyOrder2(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.FollowAssemblyOrder2;
        }
        public static Int32 PartConfigurationGrouping(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.PartConfigurationGrouping;
        }
        public static Boolean DetailedCutList(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.DetailedCutList;
        }
        public static Int32 NumberingTypeOnIndentedBOM(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.NumberingTypeOnIndentedBOM;
        }
        public static Int32 KeepReplacedCompOption(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.KeepReplacedCompOption;
        }
        public static String Name(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.Name;
        }
        public static Int32 RoutingComponentGrouping(IBomFeatureObject IBomFeatureinstance)
        {
            return IBomFeatureinstance.IBomFeatureInstance.RoutingComponentGrouping;
        }
    }
}
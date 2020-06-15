using SolidWorks.Interop.sldworks;
using System;
using System.Diagnostics;

namespace Du.SolidWorks.Extension
{
    public static class IFeatureExtension
    {
        public static T GetDefinition<T>(this IFeature feature)
        {
#if DEBUG
            Debug.Print(typeof(T).Name + " => (通过GetDefinition())" + feature.GetTypeName2());
#else

#endif
            if (!typeof(T).Name.Contains("Data"))
            {
                throw new Exception(string.Format("请确认您的类型{0}是否正确,包含Data的接口需要使用GetSpecFeatData<T>方法", typeof(T).Name));
            }

            return (T)feature.GetDefinition();
        }

        public static T GetSpecFeatData<T>(this IFeature feature)
        {
#if DEBUG
            Debug.Print(typeof(T).Name + " => (通过GetSpecificFeature2())" + feature.GetTypeName2());
#else

#endif
            return (T)feature.GetSpecificFeature2();
        }
    }
}

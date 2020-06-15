using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using SolidWorks.Interop.swconst;
using DynamoSolidWorks;
using Du.SolidWorks.Extension;
using Autodesk.DesignScript.Runtime;
using Du.DynamoSolidWorks.Nodes;

namespace ISolidWorks
{
    public class SolidWorksWrapper
    {
        public SolidWorksWrapper(ISldWorks swApp)
        {
            SwApp = swApp;
        }

        public ISldWorks SwApp { get; set; }
    }

    /// <summary>
    /// ISolidWorks 接口
    /// </summary>
    public static class ISldWorksInterface
    {
        public static SolidWorksWrapper SwAppWrapper()
        {
            return new SolidWorksWrapper(SolidWorksInstance.SwApp);
        }

        #region Const

        private const string IModelDoc2Const = "IModelDoc2";
        private const string ErrorConst = "Error";
        private const string WaringConst = "Warning";

        #endregion

        #region Doc's Open Close Active Activate 

        /// <summary>
        ///  打开SolidWorks文档
        /// </summary>
        /// <param name="FileName">需要打开的文件路径</param>
        /// <param name="Type">打开的文件类型</param>
        /// <param name="Options">选项</param>
        /// <param name="Configuration">打开为特定配置</param>
        /// <returns>打开的ModelDoc2 对象和 打开失败的错误与警告</returns>
        [MultiReturn(new[] { IModelDoc2Const, ErrorConst, WaringConst })]
        public static Dictionary<string,object> OpenDoc6(string FileName,swDocTemplateTypes_e Type,swOpenDocOptions_e Options,string Configuration)
        {
            return OpenDoc6(SolidWorksInstance.SwApp, FileName,Type, Options, Configuration);
        }

        private static Dictionary<string, object> OpenDoc6(ISldWorks SwApp,string FileName, swDocTemplateTypes_e Type, swOpenDocOptions_e Options, string Configuration)
        {
            int error = -1, warning = -1;
            Dictionary<string, object> result = new Dictionary<string, object>();

            var doc = SolidWorksInstance.SwApp.OpenDoc6(FileName, Type.SWToInt(), Options.SWToInt(), Configuration, ref error, ref warning);

            var error_E = error.CastObj<swFileLoadError_e>();
            var waring_E = error.CastObj<swFileLoadWarning_e>();

            if (doc == null)
            {
                throw new Exception($"Opendoc Failed - Error: {error_E.ToString()} ,Waring:{waring_E.ToString()}");
            }

            result.Add(IModelDoc2Const, doc);
            result.Add(ErrorConst, error_E);
            result.Add(WaringConst, waring_E);

            return result;
        }


        public static IModelDoc2Wrapper ActiveDoc(SolidWorksWrapper SwApp)
        {
            return new IModelDoc2Wrapper((IModelDoc2)SwApp.SwApp.ActiveDoc);
        }

        /// <summary>
        /// 获取活动文档
        /// </summary>
        /// <returns>SolidWorks文档对象</returns>
        /// <search>ActiveDoc,活动文档</search>
        public static IModelDoc2Wrapper ActiveDoc()
        {
            return (ActiveDoc(SwAppWrapper()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="UseUserPreferences"></param>
        /// <param name="Options"></param>
        /// <returns></returns>
        /// <serach>激活,切换</serach>
        [MultiReturn(IModelDoc2Const,ErrorConst)]
        public static Dictionary<string,object> ActivateDoc2(string Name,bool UseUserPreferences,swRebuildOptions_e Options)
        {
            int error = -1;
            IModelDoc2 doc = SolidWorksInstance.SwApp.ActivateDoc3(Name, UseUserPreferences, Options.SWToInt(),error) as ModelDoc2;;
            var Error_E = error.CastObj<swActivateDocError_e>();
            if (doc == null)
            {
                throw new Exception($"激活文档错误:{Error_E.ToString()}");
            }

            return new Dictionary<string, object>() { { IModelDoc2Const, doc }, { ErrorConst, Error_E } };
        }

        /// <summary>
        /// 关闭SolidWorks文档
        /// </summary>
        /// <param name="Name">文档名字</param>

        public static void CloseDoc(string Name)
        {
            SolidWorksInstance.SwApp.CloseDoc(Name);
        }

        /// <summary>
        /// 创建文档
        /// </summary>
        /// <param name="swDocumentTypes">文档类型</param>
        /// <returns></returns>
        public static IModelDoc2 CreateDoc(swDocumentTypes_e swDocumentTypes)
        {
            return SolidWorksInstance.SwApp.CreateDocument(false, swDocumentTypes);
        }

        #endregion

        #region Docs In SolidWorks

        public static List<IModelDoc2> GetDocuments()
        {
            var obj = SolidWorksInstance.SwApp.GetDocuments() as object[];

            return obj.Cast<IModelDoc2>().ToList();
        }

        #endregion
    }
}

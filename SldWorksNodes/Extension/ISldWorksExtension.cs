using SolidWorks.Interop.swconst;
using System;
using System.IO;
using System.Windows;

namespace SolidWorks.Interop.sldworks
{
    public static class ISldWorksExtension
    {

        /// <summary>
        /// 根据SolidWorks默认配置的模板路径，新建SolidWorks文档
        /// </summary>
        /// <param name="docTemplateType">默认模板类型</param>
        public static ModelDoc2 NewSolidWorksDoc(this ISldWorks swApp, swUserPreferenceStringValue_e docTemplateType)
        {
            var template = swApp.GetUserPreferenceStringValue((int)docTemplateType);

            if (!File.Exists(template))
            {
                throw new InvalidOperationException("当前SolidWorks未配置模板");
            }
            else
            {
                return swApp.INewDocument2(template, 0, 300d, 300d);
            }

        }

        public static IModelDoc2 OpenDocEx(this ISldWorks app, string filePathName)
        {
            if (!File.Exists(filePathName))
            {
                throw new FileNotFoundException("找不到文件：" + filePathName);
            }

            var ext = Path.GetExtension(filePathName).ToLower();
            swDocumentTypes_e docType = swDocumentTypes_e.swDocPART;
            switch (ext)
            {
                case ".sldprt":
                    docType = swDocumentTypes_e.swDocPART;
                    break;
                case ".sldasm":
                    docType = swDocumentTypes_e.swDocASSEMBLY;
                    break;
                case ".slddrw":
                    docType = swDocumentTypes_e.swDocDRAWING;
                    break;
                default:
                    throw new NotSupportedException($"不支持的文档类型{docType}");
            }
            int errors = -1; int warnings = -1;
            var doc = app.OpenDoc6(filePathName, (int)docType, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref errors, ref warnings);

            if (doc == null)
            {
                throw new Exception($"打开文件失败,Error:{errors},Warnings:{warnings}");
            }

            return doc;
        }

        /// <summary>
        /// 当前前台文档是不是零件
        /// </summary>
        public static bool ActiveDocIsPart(this ISldWorks app)
        {
            var doc = app.ActiveDoc as ModelDoc2;
            if (doc == null)
            {
                return false;
            }

            return doc.GetTypeEx() == swDocumentTypes_e.swDocPART;
        }

        /// <summary>
        /// 当前打开的或者编辑的是不是零件类型
        /// </summary>
        public static bool ActiveEnviromentIsPart(this ISldWorks app)
        {
            var doc = app.ActiveDoc as ModelDoc2;
            if (doc == null)
            {
                return false;
            }

            if (doc.GetTypeEx() == swDocumentTypes_e.swDocPART)
            {
                return true;
            }

            if (doc.GetTypeEx() == swDocumentTypes_e.swDocASSEMBLY)
            {
                var assDoc = doc as IAssemblyDoc;
                var editDoc = assDoc.GetEditTarget() as ModelDoc2;
                return editDoc.GetTypeEx() == swDocumentTypes_e.swDocPART;
            }

            return false;
        }

        public static Point GetSldWorksPostion(this ISldWorks app)
        {
            return new Point(app.FrameLeft, app.FrameTop);
        }
    }
}

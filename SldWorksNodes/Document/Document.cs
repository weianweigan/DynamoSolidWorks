using SldWorksNodes.Base;
using SldWorksNodes.ConfigurationManager;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SldWorksNodes.Document
{
    public class Document:SwNodeModel<IModelDoc2>
    {
        internal Document(IModelDoc2 doc)
        {
            SwObject = doc;
        }

        public static Document Current()
        {
            var doc = SldContextManager.Sw.IActiveDoc2;
            if(doc == null)
                return null;

            return new Document(doc);
        }

        public static Document Open(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            var activeDocFileName = SldContextManager.Sw.IActiveDoc2?.GetPathName();

            if(activeDocFileName == fileName)
                return new Document(SldContextManager.Sw.IActiveDoc2);
            else
                return new Document(SldContextManager.Sw.OpenDocEx(activeDocFileName));
        }

        /// <summary>
        /// Get all docs in current sldworks session.
        /// </summary>
        /// <returns></returns>
        public static List<Document> Documents()
        {
            var docs = SldContextManager.Sw.GetDocuments() as Object[];

            if (docs == null)
                return null;

            return docs
                .Cast<IModelDoc2>()
                .Select(doc => new Document(doc))
                .ToList();
        }

        public bool ReName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                return false;

            bool flag = SwObject.Extension.SelectByID2(SwObject.GetTitle(),
                "COMPONENT", 0, 0, 0, 
                false, 0, null, 0);

            var res =(swRenameDocumentError_e)SwObject.Extension.RenameDocument(newName);

            if (res != swRenameDocumentError_e.swRenameDocumentError_None)
                throw new Exception(res.ToString());

            return true;
        }

        public List<string> Configs()
        {
            var configs = SldContextManager.Sw
                .GetConfigurationNames(SwObject.GetPathName()) as Object[];

            if (configs == null)
                return null;

            return configs.Cast<string>().ToList();
        }

        public PartDocument AsPartDocument()
        {
            if (SwObject == null)
                return null;

            if (SwObject.GetTypeEx() != swDocumentTypes_e.swDocPART)
                throw new SwException.ActiveDocIsNotPartDocException();

            return new PartDocument(SwObject);
        }

        public AssemblyDocument AsAssemblyDocument()
        {
            if (SwObject == null)
                return null;

            if (SwObject.GetTypeEx() != swDocumentTypes_e.swDocASSEMBLY)
                throw new SwException.ActiveDocIsNotAssemblyDocException();

            return new AssemblyDocument(SwObject);
        }

        public DrawingDocument AsDrawingDocument()
        {
            if (SwObject == null)
                return null;

            if (SwObject.GetTypeEx() != swDocumentTypes_e.swDocDRAWING)
                throw new SwException.ActiveDocIsNotDrawingDocException();

            return new DrawingDocument(SwObject);
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <returns></returns>
        public SwConfiguration ActiveConfiguration()
        {
            if (SwObject == null)
                return null;

            return new SwConfiguration(SwObject.ConfigurationManager.ActiveConfiguration);
        }

        public ConfigurationManager.ConfigurationManager ConfigurationManager()
        {
            if (SwObject == null)
                return null;

            return new ConfigurationManager.ConfigurationManager(SwObject.ConfigurationManager);
        }

        public override string ToString()
        {
            return SwObject?.GetTitle() ?? base.ToString();
        }
    }
}

using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;

namespace SldWorksNodes.Document
{
    public class Document:SwNodeModel<IModelDoc2>
    {
        public Document(ModelDoc2 doc)
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
    }
}

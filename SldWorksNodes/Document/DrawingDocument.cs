using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Document
{
    public class DrawingDocument:SwNodeModel<IModelDoc2>
    {
        internal DrawingDocument(IModelDoc2 swObject)
        {
            SwObject = swObject;
            DrawingDoc = swObject as IDrawingDoc;
        }

        [IsVisibleInDynamoLibrary(false)]
        public IDrawingDoc DrawingDoc { get;}
    }
}

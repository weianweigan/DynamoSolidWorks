using System.IO;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.Geometry;
using SldWorksNodes.SwException;
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

        public bool InsertSketchPicture(
            string filePathName,
            Point3D postion,
            double width,double height)
        {
            var nPos = _swUnit.ConvertPoint(postion);
            var nX = _swUnit.ConvertDouble(width);
            var nY = _swUnit.ConvertDouble(height);

            var view = DrawingDoc.IActiveDrawingView;
            if (view != null)
            {
                view.FocusLocked = false;
            }

            if (!File.Exists(filePathName))
                throw new FileNotFoundException(
                    string.Format(Properties.Resources.FileNotFound, filePathName));

            var skePic = SwObject.SketchManager.InsertSketchPicture(filePathName);
            if (skePic == null)
            {
                throw new SwApiException(Properties.Resources.InsertPictureFailed);
            }

            return skePic.SetOrigin(postion.X,postion.Y) && skePic.SetSize(nX,nY,false);
        }
    }
}

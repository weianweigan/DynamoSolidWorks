using Autodesk.DesignScript.Runtime;
using Microsoft.VisualBasic;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SwBodyNode : SwNodeModel<IBody2>, IDisposable
    {
        private Color _color = Colors.Yellow;

        /// <summary>
        /// Clear Body
        /// </summary>
        public void Dispose()
        {
            try
            {
                if (SwObject == null)
                    return;

                var doc = SldContextManager.Sw.IActiveDoc2;
                doc.DeleteBody(SwObject);
                SwObject = null;
            }
            catch (Exception)
            {

            }
        }

        public Color Color
        {
            get => _color; set
            {
                _color = value;
                UpdateColor();
            }
        }

        private void UpdateColor()
        {
            if (SwObject == null)
                return;

            
        }

        protected void DisplayBody(IModelDoc2 doc, Color color)
        {
            if (SwObject == null)
                return;

            if (!SwObject.IsTemporaryBody())
                return;

            SwObject.Display3(doc, Information.RGB(color.R, color.G, color.B), (int)swTempBodySelectOptions_e.swTempBodySelectOptionNone);
        }
    }
}

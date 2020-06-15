using SolidWorks.Interop.swpublished;

namespace Du.SolidWorks.Extension
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class ManipulatorHandler : SwManipulatorHandler2
    {
        public virtual void OnDirectionFlipped(object pManipulator)
        {
        }

        public virtual void OnHandleSelected(object pManipulator, int handleIndex)
        {
        }

        public virtual void OnUpdateDrag(object pManipulator, int handleIndex, object newPosMathPt)
        {
        }

        public virtual void OnEndDrag(object pManipulator, int handleIndex)
        {
        }

        public virtual void OnEndNoDrag(object pManipulator, int handleIndex)
        {
        }

        public virtual void OnHandleRmbSelected(object pManipulator, int handleIndex)
        {
        }
        public virtual void OnItemSetFocus(object pManipulator, int handleIndex)
        {
        }

        #region cancelable
        public virtual bool OnHandleLmbSelected(object pManipulator)
        {
            return true;
        }

        public virtual bool OnDelete(object pManipulator)
        {
            return true;
        }

        public virtual bool OnDoubleValueChanged(object pManipulator, int handleIndex, ref double value)
        {
            return true;
        }

        public virtual bool OnStringValueChanged(object pManipulator, int handleIndex, ref string Value)
        {
            return true;
        }
        #endregion

    }


}

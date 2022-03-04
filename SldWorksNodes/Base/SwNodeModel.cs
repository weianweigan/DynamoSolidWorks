using Autodesk.DesignScript.Runtime;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SwNodeModel<TSwType> : SwNode
        where TSwType : class
    {
        private TSwType _swObject;

        public TSwType SwObject
        {
            get => _swObject; set
            {
                _swObject = value;
                CreatePID();
            }
        }

        protected virtual void CreatePID()
        {
            PID = PIDUtil.GetPID(SldContextManager.Sw.IActiveDoc2, SwObject);
        }

        protected void AssertSwObject()
        {
            if (_swObject == null)
                throw new SwObjectLostException(typeof(TSwType));
        }
    }
}

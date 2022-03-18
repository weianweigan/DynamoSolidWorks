using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Manager;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SwNodeModel<TSwType> : SwNode
        where TSwType : class
    {
        #region Fields
        private TSwType _swObject;
        protected UnitManager _swUnit = new UnitManager();
        #endregion

        #region Properties
        public TSwType SwObject
        {
            get => _swObject; set
            {
                _swObject = value;
                CreatePID();//暂时不需要创建PID
            }
        }
        #endregion

        #region Methods
        protected virtual void CreatePID()
        {
            PID = PIDUtil.GetPID(SldContextManager.Sw.IActiveDoc2, SwObject);
        }

        protected void AssertSwObject()
        {
            if (_swObject == null)
                throw new SwObjectLostException(typeof(TSwType));
        }
        #endregion
    }
}

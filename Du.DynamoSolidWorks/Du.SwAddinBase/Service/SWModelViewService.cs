using Du.SolidWorks;
using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Du.SwAddinBase.Service
{
    public interface ISWModelViewService
    {
        WPFModelBuilder ShowWPFModelViewInModel(UIElement ui, string name, bool splitWindow = true);
    }
    public class SWModelViewService : ISWModelViewService
    {
        #region service

        private readonly ISolidWorksAddin _addin;

        #endregion

        #region .ctor

        public SWModelViewService(ISolidWorksAddin addin)
        {
            _addin = addin;
        }

        #endregion

        #region methods

        public WPFModelBuilder ShowWPFModelViewInModel(UIElement ui, string name, bool splitWindow = true)
        {
            return new WPFModelBuilder(_addin, ui, name, splitWindow);
        }

        #endregion
    }

    public class WPFModelBuilder
    {
        #region services

        private readonly ISolidWorksAddin _addin;

        #endregion

        #region properties

        public string WPFModelViewControlName { get; private set; }

        public IModelDoc2 Doc { get; private set; }

        public IModelViewManager ModelViewMgr { get; private set; }

        public bool IsCreated { get; set; }

        #endregion

        #region .ctor

        public WPFModelBuilder(ISolidWorksAddin addin, UIElement ui, string name, bool splitWindow)
        {
            _addin = addin;
            WPFModelViewControlName = name;

            Doc = _addin.SwApp.ActiveDocEx(); ;
            if (Doc == null)
            {
                throw new NullReferenceException($"无法获取到打开的文档,所有无法创建ModelView Control");
            }
            ModelViewMgr = Doc.ModelViewManager;

            var modelViewelhost = new ElementHost();
            modelViewelhost.Child = ui;
            IsCreated = ModelViewMgr.DisplayWindowFromHandlex64(name, modelViewelhost.Handle.ToInt64(), splitWindow);
        }

        #endregion
    }
}

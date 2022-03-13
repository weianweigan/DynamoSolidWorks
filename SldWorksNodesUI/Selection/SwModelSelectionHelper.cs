using System;
using System.Linq;
using CoreNodeModels;
using Dynamo.Logging;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SldWorksNodesUI.Control;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SldWorksNodesUI.Selection
{
    /// <summary>
    /// Helper class for comminucate with
    /// </summary>
    /// <typeparam name="TSelection"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class SwModelSelectionHelper<TSelection,TResult> : 
        IModelSelectionHelper<TSelection>
        where TSelection : class
        where TResult : SwNodeModel<TSelection>
    {
        #region Fields
        private SelectionPage _page;
        private SwObjectSelction<TSelection, TResult> _swObjectSelction;
        #endregion

        #region Ctor
        public SwModelSelectionHelper(
            SwObjectSelction<TSelection, TResult> swObjectSelction)
        {
            _swObjectSelction = swObjectSelction;
        }
        #endregion

        #region Event
        public event Action<ILogMessage> MessageLogged;
        #endregion

        #region Methods
        public IEnumerable<TSelection> RequestSelectionOfType(
            string selectionMessage, 
            SelectionType selectionType, 
            SelectionObjectType objectType)
        {
            if (_page == null)
            {
                var selectType = default(swSelectType_e);
                bool isAllFeat = false;

                switch (typeof(TSelection).Name)
                {
                    case "IFeature":
                        isAllFeat = true;
                        break;
                    case "IEdge":
                        selectType = swSelectType_e.swSelEDGES;
                        break;
                    case "IFace2":
                        selectType = swSelectType_e.swSelFACES;
                        break;
                    case "IBody2":
                        selectType = swSelectType_e.swSelSOLIDBODIES;
                        break;
                    default:
                        break;
                }

                _page = new Control.SelectionPage(
                    SldContextManager.Sw, 
                    selectType,
                    _swObjectSelction.Name,
                    _swObjectSelction.Description,
                    isAllFeat);
                _page.Closed += _page_Closed;
            }

            _page.ShowPage();

            return new List<TSelection>() { };
        }

        private void _page_Closed(swPropertyManagerPageCloseReasons_e reason)
        {
            _page.Closed -= _page_Closed;

            if (reason == swPropertyManagerPageCloseReasons_e.swPropertyManagerPageClose_Okay)
            {
                UpdateSelection();
            }
            else
            {
                _swObjectSelction.ClearSelections();
            }
            _page.Dispose();
            _page = null;
        }

        private void UpdateSelection()
        {
            if (_page.VM.Selections.Any())
            {
                _swObjectSelction
                    .UpdateSelection(_page.VM.Selections.
                    Select(p => p.SelectedObject)
                    .Cast<TSelection>());
            }
        }
        #endregion
    }
}

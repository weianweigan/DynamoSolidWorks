using System;
using System.Linq;
using CoreNodeModels;
using Dynamo.Logging;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SldWorksNodesUI.Control;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;
using SldWorksNodes.Geometry;

namespace SldWorksNodesUI.Selection
{
    /// <summary>
    /// Helper class for comminucate with
    /// </summary>
    /// <typeparam name="TSelection"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class SwModelSelectionHelper<TSelection, TResult> :
        IModelSelectionHelper<TSelection>
        where TSelection : class
        where TResult : class, IPID
    {
        #region Fields
        private SelectionPage _page;
        private SwObjectSelction<TSelection, TResult> _swObjectSelction;
        private string _typeName;
        #endregion

        #region Ctor
        public SwModelSelectionHelper(
            SwObjectSelction<TSelection, TResult> swObjectSelction)
        {
            _swObjectSelction = swObjectSelction;
            _typeName = typeof(TSelection).Name;
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
                var swSelectType = default(swSelectType_e);
                bool isAllFeat = false;

                switch (_typeName)
                {
                    case "IFeature":
                        isAllFeat = true;
                        break;
                    case "IEdge":
                        swSelectType = swSelectType_e.swSelEDGES;
                        break;
                    case "Point3D":
                    case "IFace2":
                        swSelectType = swSelectType_e.swSelFACES;
                        break;
                    case "IBody2":
                        swSelectType = swSelectType_e.swSelSOLIDBODIES;
                        break;
                    case "IComponent2":
                        swSelectType = swSelectType_e.swSelCOMPONENTS;
                        break;
                    default:
                        break;
                }

                _page = new Control.SelectionPage(
                    SldContextManager.Sw,
                    swSelectType,
                    selectionType,
                    $"Select {_swObjectSelction.Prefix}",
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
                if (_typeName == "Point3D")
                {
                    _swObjectSelction
                    .UpdateSelection(_page.VM.Selections.
                             Select(p => Point3D.ByCoordinates(p.Point[0],p.Point[1],p.Point[2]))
                            .Cast<TSelection>());
                }
                else
                {
                    _swObjectSelction
                        .UpdateSelection(_page.VM.Selections.
                        Select(p => p.SelectedObject)
                        .Cast<TSelection>());
                }
            }
        }
        #endregion
    }
}

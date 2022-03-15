using System.ComponentModel;
using CoreNodeModels;
using Du.PMPage.Wpf;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SldWorksNodesUI.Control
{
    /// <summary>
    /// SelectionPage.xaml 的交互逻辑
    /// 
    /// avoid load Du.PMPage.Wpf in other addin
    /// </summary>
    public partial class SelectionPage : SldPMPage
    {
        private SelectionPageViewModel _vm;

        public SelectionPage(
            ISldWorks app, 
            swSelectType_e swSelectType,
            SelectionType selectionType,

            string name, 
            string description,
            bool isAllFeat = false)
            :base(app)
        {
            InitializeComponent();

            _selectionBox.SldCaption = description;
            _selectionBox.SldTip = description;
            _selectionBox.SingleEntityOnly = selectionType == SelectionType.One;
            _selectionBox.SldHeight = selectionType == SelectionType.One ? 20 : 40;
            VM = new SelectionPageViewModel(swSelectType, isAllFeat)
            {
                NodeName = name,
                Description = description,
            };
            DataContext = VM;

            //UpdateIcon(swSelectType);
        }

        private void UpdateIcon(swSelectType_e selectType)
        {
            switch (selectType)
            {
                case swSelectType_e.swSelEDGES:
                    _selectionBox.StandardPictureLabel = swControlBitmapLabelType_e.swBitmapLabel_SelectEdge;
                    break;
                case swSelectType_e.swSelFACES:
                    _selectionBox.StandardPictureLabel = swControlBitmapLabelType_e.swBitmapLabel_SelectFace;
                    break;
                case swSelectType_e.swSelCOMPONENTS:
                    _selectionBox.StandardPictureLabel = swControlBitmapLabelType_e.swBitmapLabel_SelectComponent;
                    break;
                default:
                    break;
            }
        }

        public SelectionPageViewModel VM { get => _vm; set => _vm = value; }
    }

    public class SelectionPageViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<swSeleTypeObjectPair> _selections = new ObservableCollection<swSeleTypeObjectPair>();

        public SelectionPageViewModel(swSelectType_e selectType, bool isAllFeat)
        {
            if (isAllFeat)
            {
                SelectTypes = new List<swSelectType_e>() {
                        swSelectType_e.swSelDATUMPLANES,
                        swSelectType_e.swSelDATUMAXES,
                        swSelectType_e.swSelDATUMPOINTS,
                        swSelectType_e.swSelATTRIBUTES,
                        swSelectType_e.swSelSKETCHES,
                        swSelectType_e.swSelSECTIONLINES,
                        swSelectType_e.swSelDETAILCIRCLES,
                        swSelectType_e.swSelBODYFEATURES ,
                        swSelectType_e.swSelREFCURVES,
                        swSelectType_e.swSelREFERENCECURVES,
                        swSelectType_e.swSelCTHREADS,
                        swSelectType_e.swSelCONFIGURATIONS,
                        swSelectType_e.swSelREFSILHOUETTE,
                        swSelectType_e.swSelCAMERAS,
                        swSelectType_e.swSelSWIFTANNOTATIONS,
                        swSelectType_e.swSelSWIFTFEATURES,};
            } 
            else
                SelectTypes = new List<swSelectType_e>() {selectType};
              
        }

        /// <summary>
        /// 可以选择的内容，包括孔腔面和孔腔宏特征
        /// </summary>
        public List<swSelectType_e> SelectTypes { get; set; }

        /// <summary>
        /// 所有选择项目
        /// </summary>
        public ObservableCollection<swSeleTypeObjectPair> Selections
        {
            get => _selections; set
            {
                _selections=value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Selections)));
            }
        }

        public string NodeName { get; internal set; }

        public string Description { get; internal set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

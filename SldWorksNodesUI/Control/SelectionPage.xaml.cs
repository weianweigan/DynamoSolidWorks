using Du.PMPage.Wpf;
using Microsoft.Practices.Prism.ViewModel;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SldWorksNodesUI.Control
{
    /// <summary>
    /// SelectionPage.xaml 的交互逻辑
    /// </summary>
    public partial class SelectionPage : SldPMPage
    {
        private SelectionPageViewModel _vm;

        public SelectionPage(
            ISldWorks app, 
            swSelectType_e selectType,
            string name, 
            string description,
            bool isAllFeat = false)
            :base(app)
        {
            InitializeComponent();

            UpdateIcon(selectType);

            VM = new SelectionPageViewModel(selectType, isAllFeat)
            {
                NodeName = name,
                Description = description,
            };

            DataContext = VM;
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
                default:
                    break;
            }
        }

        public SelectionPageViewModel VM { get => _vm; set => _vm = value; }
    }

    public class SelectionPageViewModel:NotificationObject
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
                RaisePropertyChanged(nameof(Selections));
            }
        }

        public string NodeName { get; internal set; }

        public string Description { get; internal set; }
    }
}

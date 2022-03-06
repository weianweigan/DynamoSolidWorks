using DynamoSldWorks.Properties;
using DynamoSldWorks.ViewModel;
using System.Windows.Controls;
using Xarial.XCad.Base.Attributes;

namespace DynamoSldWorks.View
{
    /// <summary>
    /// DynamoTaskPane.xaml 的交互逻辑
    /// </summary>
    [Title("DynamoSldWorks")]
    [Icon(typeof(Resources), nameof(Properties.Resources.logo_square_32x32))]
    public partial class DynamoTaskPane : UserControl
    {
        private DynamoTaskPaneViewModel _viewmodel;

        public DynamoTaskPane()
        {
            InitializeComponent();
        }

        public void Init(SwAddin addin)
        {
            DataContext = (_viewmodel = new DynamoTaskPaneViewModel(addin, SwAddin.DynamoCorePath));
        }
    }
}

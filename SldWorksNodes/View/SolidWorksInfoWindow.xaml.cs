using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Manager;
using SldWorksNodes.Util;
using System.Windows;

namespace SldWorksNodes.View
{
    /// <summary>
    /// SolidWorksInfoWindow.xaml 的交互逻辑
    /// </summary>
    [IsVisibleInDynamoLibrary(false)]
    public partial class SolidWorksInfoWindow : Window
    {
        public SolidWorksInfoWindow()
        {
            InitializeComponent();

            _swVersion.Text = SldContextManager.SwApplication.Version.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void _swUnitSys_Checked(object sender, RoutedEventArgs e)
        {
            UnitManager.UnitType = UnitType.UseUserValueInSw;
        }

        private void _mm_Checked(object sender, RoutedEventArgs e)
        {
            UnitManager.UnitType = UnitType.UseMM;
        }

        private void _meter_Checked(object sender, RoutedEventArgs e)
        {
            UnitManager.UnitType = UnitType.UseMeter;
        }
    }
}

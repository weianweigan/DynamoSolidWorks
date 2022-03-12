using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using System;
using System.Collections.Generic;
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

        }

        private void _mm_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void _meter_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

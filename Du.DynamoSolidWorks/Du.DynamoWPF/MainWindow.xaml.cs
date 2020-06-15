using System.Diagnostics;
using System.Reflection;
using System.Windows;

namespace Du.DynamoWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            var ass = Assembly.LoadFrom(@"D:\weigan\repos\DynamoSolidWorks\Du.DynamoSolidWorks\packages\SolidWorks2016\SolidWorks.Interop.sldworks.dll");
            var types = ass.GetTypes();

            foreach (var item in types)
            {
                Debug.Print(item.FullName);
                var proerties = item.GetProperties();
                var methods = item.GetMethods();
            }
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace MyProgram.MPVM.CustomElements
{
    /// <summary>
    /// Логика взаимодействия для LicenseControl.xaml
    /// </summary>
    public partial class LicenseControl : UserControl
    {
        public LicenseControl()
        {
            InitializeComponent();
        }

        private void AcceptButton(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.LicenseBorder.Visibility = Visibility.Collapsed;
        }
    }
}

using Reverse.Modules.ModuleNames.Views;
using System.ComponentModel;
using System.Windows;

namespace Reverse_Analytics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += ShowLoginDialog;
        }

        private void ShowLoginDialog(object sender, RoutedEventArgs e)
        {
            var window = new LoginView()
            {
                Owner = Application.Current.MainWindow
            };

            window.ShowDialog();
        }

        private void OnClosingAction(object sender, CancelEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}

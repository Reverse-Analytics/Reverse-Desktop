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
        }

        private void OnClosingAction(object sender, CancelEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}

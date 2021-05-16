using System.Windows;
using System.Windows.Controls;

namespace Reverse.Modules.ModuleNames.Views
{
    /// <summary>
    /// Interaction logic for ActionView.xaml
    /// </summary>
    public partial class ActionView : UserControl
    {
        public ActionView()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }
    }
}

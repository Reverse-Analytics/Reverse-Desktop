using System.Windows.Controls;
using System.Windows.Media.Effects;

namespace Reverse.Modules.Forms.Views.Clients
{
    /// <summary>
    /// Interaction logic for Clients.xaml
    /// </summary>
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void addClientsButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            this.Effect = new BlurEffect();

            // Set the options for the settings (child) window
            NewClientDialog wdwSettings = new NewClientDialog()
            {
                ShowInTaskbar = false,
                Topmost = true
            };

            // Open the child window 
            wdwSettings.ShowDialog();

            //restore Opacity and remove blur after closing the child window
            this.Opacity = 1;
            this.Effect = null;
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //clientDetails.Visibility = System.Windows.Visibility.Visible;
        }
    }
}

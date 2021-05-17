using Infrastructure.Models;
using Reverse.Modules.Forms.ViewModels;
using Reverse.Modules.ModuleNames.ViewModels;
using Reverse.Modules.ModuleNames.Views;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;

namespace Reverse.Modules.Forms.Views
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
            this.Opacity = 0.5;
            this.Effect = new BlurEffect();

            // Set the options for the settings (child) window
            ClientDetails wdwSettings = new ClientDetails()
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
    }
}

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
            
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SidebarViewModel.ControlOpacity = 0.5;
            SidebarViewModel.ControlEffect = new BlurEffect();
            ClientsViewModel.ControlOpacity = 0.5;
            ClientsViewModel.ControlEffect = new BlurEffect();

            // Set the options for the settings (child) window
            ClientDetails wdwSettings = new ClientDetails()
            {
                ShowInTaskbar = false,
                Topmost = true
            };

            // Open the child window
            wdwSettings.ShowDialog();

            //restore Opacity and remove blur after closing the child window
            SidebarViewModel.ControlOpacity = 1;
            SidebarViewModel.ControlEffect = null;
            ClientsViewModel.ControlOpacity = 1;
            ClientsViewModel.ControlEffect = null;
        }
    }
}

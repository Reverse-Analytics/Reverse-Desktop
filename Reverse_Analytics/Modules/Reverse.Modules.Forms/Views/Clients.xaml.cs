using Infrastructure.Models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Reverse.Modules.Forms.Views
{
    /// <summary>
    /// Interaction logic for Clients.xaml
    /// </summary>
    public partial class Clients : UserControl
    {
        private readonly List<Supplier> suppliers;
        public Clients()
        {
            InitializeComponent();
        }
    }
}

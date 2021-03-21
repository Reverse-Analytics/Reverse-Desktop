using System.Windows;
using Infrastructure.Models;

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
            Client c = new Client();

            System.Console.WriteLine(c);
        }
    }
}

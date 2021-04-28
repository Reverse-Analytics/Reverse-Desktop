using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reverse_Analytics.Views
{
    /// <summary>
    /// Interaction logic for SidebarView.xaml
    /// </summary>
    public partial class SidebarView : UserControl
    {
        private StackPanel previousFocusedElement;
        public SidebarView()
        {
            InitializeComponent();

            Loaded += SidebarView_Loaded;
        }

        void SidebarView_Loaded(object sender, RoutedEventArgs e)
        {
            FocusManager.SetFocusedElement(firstStack, firstStack.Children[1]);
            //previousFocusedElement = firstStack;
        }

        private void StackPanel_GotFocus(object sender, RoutedEventArgs e)
        {
            if (previousFocusedElement != null)
            {
                previousFocusedElement.Children[0].Visibility = Visibility.Hidden;
                previousFocusedElement.Background = new SolidColorBrush(Color.FromRgb(54, 55, 64));
            }

            if (sender is StackPanel clickedPanel)
            {
                clickedPanel.Children[0].Visibility = Visibility.Visible;
                //(clickedPanel.Children[1] as Button).Background = new SolidColorBrush(Color.FromRgb(62, 64, 73));
                (clickedPanel as StackPanel).Background = new SolidColorBrush(Color.FromRgb(62, 64, 73));

                previousFocusedElement = clickedPanel;
            }
        }

        private void StackPanel_LostFocus(object sender, RoutedEventArgs e)
        {
            /*if (FocusManager.GetFocusedElement(this).GetType().Name.Equals("Button"))
            {
                if (sender is StackPanel clickedPanel)
                {
                    clickedPanel.Children[0].Visibility = Visibility.Hidden;
                    (clickedPanel.Children[1] as Button).Background = new SolidColorBrush(Color.FromRgb(54, 55, 64));
                }
            }*/
        }
    }
}

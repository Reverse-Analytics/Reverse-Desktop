using System.Windows;
using System.Windows.Media;

namespace Reverse.Infrastructure.CustomControls.Buttons
{
    /*
     * Sidebar navigation button
     */
    public class NavigationButton : BaseButton
    {
        public NavigationButton()
            : base()
        {
            Width = 190;
            BorderThickness = new Thickness(0,0,0,0);
            FontSize = 18;
            Foreground = new SolidColorBrush(Colors.White);
            Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#363740"));
        }
    }
}

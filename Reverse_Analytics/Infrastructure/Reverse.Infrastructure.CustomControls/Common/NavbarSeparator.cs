using System.Windows.Controls;
using System.Windows.Media;

namespace Reverse.Infrastructure.CustomControls.Common
{
    public class NavbarSeparator : Separator
    {
        public NavbarSeparator()
        {
            Height = 2;
            Width = 160;
            HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFFFF"));
        }
    }
}

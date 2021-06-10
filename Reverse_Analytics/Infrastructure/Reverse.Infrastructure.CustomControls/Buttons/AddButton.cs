using System.Windows.Media;

namespace Reverse.Infrastructure.CustomControls.Buttons
{
    public class AddButton : BaseButton
    {
        public AddButton()
        {
            Margin = new System.Windows.Thickness(25, 15, 5, 5);
            HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            Width = 110;
            Height = 35;
            FontSize = 14;
            Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#5CB85C"));
            Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFFFF"));
        }
    }
}

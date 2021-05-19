using System.Windows.Media;

namespace Reverse.Infrastructure.CustomControls.Buttons
{
    public class AddButton : BaseButton
    {
        public AddButton()
        {
            Margin = new System.Windows.Thickness(25, 15, 5, 5);
            HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            Width = 120;
            Height = 35;
            FontSize = 18;
            Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#5CB85C"));
            Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFFFF"));
        }
    }
}

using System.Windows.Controls;

namespace Reverse.Infrastructure.CustomControls.Common
{
    public class NavigationStackPanel : StackPanel
    {
        public NavigationStackPanel()
        {
            Orientation = Orientation.Horizontal;
            Margin = new System.Windows.Thickness(5, 0, 0, 10);
        }
    }
}

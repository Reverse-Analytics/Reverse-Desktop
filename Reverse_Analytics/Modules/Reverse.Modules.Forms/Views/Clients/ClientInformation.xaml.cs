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

namespace Reverse.Modules.Forms.Views.Clients
{
    /// <summary>
    /// Interaction logic for ClientInformation.xaml
    /// </summary>
    public partial class ClientInformation : UserControl
    {
        public ClientInformation()
        {
            InitializeComponent();

            Loaded += BlurOwner;
        }

        private void BlurOwner(object sender, RoutedEventArgs e)
        {
            
            //if (!(Owner?.Content is FrameworkElement content)) return;

            //_previousEffect = content.Effect;
            //content.Effect = null;
            //var blurEffect = new BlurEffect();
            //content.Effect = blurEffect;

            //var blurEffectAnimation = new DoubleAnimation
            //{
            //    From = 5,
            //    To = 0,
            //    Duration = TimeSpan.FromMilliseconds(50000)
            //};

            //Storyboard.SetTarget(blurEffectAnimation, content);
            //Storyboard.SetTargetProperty(blurEffectAnimation, new PropertyPath("Effect.Radius"));

            //var sb = new Storyboard();
            //sb.Children.Add(blurEffectAnimation);
            //sb.Begin();
        }

        private void UnblurOwner(object sender, EventArgs e)
        {
            //if (!(Owner?.Content is FrameworkElement content)) return;

            //var blurEffectAnimation = new DoubleAnimation
            //{
            //    From = 0,
            //    To = 5,
            //    Duration = TimeSpan.FromMilliseconds(50000000)
            //};

            //Storyboard.SetTarget(blurEffectAnimation, content);
            //Storyboard.SetTargetProperty(blurEffectAnimation, new PropertyPath("Effect.Radius"));

            //var sb = new Storyboard();
            //sb.Children.Add(blurEffectAnimation);
            //sb.Completed += delegate
            //{
            //    // restore previous effect
            //    Owner.Effect = _previousEffect;
            //};

            //sb.Begin();
        }
    }
}

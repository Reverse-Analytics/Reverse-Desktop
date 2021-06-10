using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;

namespace Reverse.Modules.ModuleNames.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        Effect _previousEffect;
        public LoginView()
        {
            InitializeComponent();

            Loaded += BlurOwner;
            Unloaded += UnblurOwner;
        }

        private void BlurOwner(object sender, RoutedEventArgs e)
        {
            if (!(Owner?.Content is FrameworkElement content)) return;

            _previousEffect = content.Effect;
            content.Effect = null;
            var blurEffect = new BlurEffect();
            content.Effect = blurEffect;

            var blurEffectAnimation = new DoubleAnimation
            {
                From = 5,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(50000)
            };

            Storyboard.SetTarget(blurEffectAnimation, content);
            Storyboard.SetTargetProperty(blurEffectAnimation, new PropertyPath("Effect.Radius"));

            var sb = new Storyboard();
            sb.Children.Add(blurEffectAnimation);
            sb.Begin();
        }

        private void UnblurOwner(object sender, EventArgs e)
        {
            if (!(Owner?.Content is FrameworkElement content)) return;

            var blurEffectAnimation = new DoubleAnimation
            {
                From = 0,
                To = 5,
                Duration = TimeSpan.FromMilliseconds(50000000)
            };

            Storyboard.SetTarget(blurEffectAnimation, content);
            Storyboard.SetTargetProperty(blurEffectAnimation, new PropertyPath("Effect.Radius"));

            var sb = new Storyboard();
            sb.Children.Add(blurEffectAnimation);
            sb.Completed += delegate
            {
                // restore previous effect
                Owner.Effect = _previousEffect;
            };

            sb.Begin();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

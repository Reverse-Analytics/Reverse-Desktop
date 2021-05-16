using System;
using System.Windows;
using System.Windows.Threading;

namespace Reverse.Infrastructure.CustomControls.Common
{
    public class Clock : DependencyObject
    {
        public Clock()
        {
            StartTimer();
        }

        void StartTimer()
        {
            DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(100) };
            timer.Tick += (s, e) => { DateTime = DateTime.Now; };
            timer.Start();
        }

        public DateTime DateTime
        {
            get { return (DateTime)GetValue(DateTimeProperty); }
            set { SetValue(DateTimeProperty, value); }
        }

        public static readonly DependencyProperty DateTimeProperty =
            DependencyProperty.Register(nameof(DateTime), typeof(DateTime), typeof(Clock));
    }
}

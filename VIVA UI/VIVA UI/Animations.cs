using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace VIVA_UI
{
    public class Animations
    {
        public IEasingFunction CreateBounceAnimation(int Bounces, int Bounciness)
        {
            return new BounceEase { Bounces = Bounces, Bounciness = Bounciness, EasingMode = EasingMode.EaseInOut };
        }
        public IEasingFunction CreateCircleAnimation()
        {
            return new CircleEase { EasingMode = EasingMode.EaseInOut };
        }
        public IEasingFunction CreateCubicAnimation()
        {
            return new CubicEase { EasingMode = EasingMode.EaseInOut };
        }
        public IEasingFunction CreateElasticAnimation(int Oscillations, int Springiness)
        {
            return new ElasticEase { EasingMode = EasingMode.EaseInOut, Oscillations = Oscillations, Springiness = Springiness };
        }
        public IEasingFunction CreateExponentialAnimation(int Exponent)
        {
            return new ExponentialEase { EasingMode = EasingMode.EaseInOut, Exponent = Exponent };
        }
        public IEasingFunction CreatePowerAnimation(int Power)
        {
            return new PowerEase { EasingMode = EasingMode.EaseInOut, Power = Power };
        }
        public IEasingFunction CreateQuadraticAnimation()
        {
            return new QuadraticEase { EasingMode = EasingMode.EaseInOut };
        }
        public IEasingFunction CreateQuarticAnimation()
        {
            return new QuarticEase { EasingMode = EasingMode.EaseInOut };
        }
        public IEasingFunction CreateQuinticAnimation()
        {
            return new QuinticEase { EasingMode = EasingMode.EaseInOut };
        }
        public IEasingFunction CreateSineAnimation()
        {
            return new SineEase { EasingMode = EasingMode.EaseInOut };
        }
    }
    public class Actions
    {
        public Task DoDoubleAnimation(DependencyObject Object, double From, double To, PropertyPath Property, IEasingFunction Animation, int Duration)
        {
            var sb = new Storyboard();
            var anim = new DoubleAnimation()
            {
                From = From,
                To = To,
                Duration = new Duration(TimeSpan.FromMilliseconds(Duration)),
                EasingFunction = Animation,
            };

            Storyboard.SetTarget(anim, Object);
            Storyboard.SetTargetProperty(anim, Property);
            sb.Children.Add(anim);
            sb.Begin();
            return Task.CompletedTask;
        }
        public Task DoThicknessAnimation(DependencyObject Object, Thickness From, Thickness To, PropertyPath Property, IEasingFunction Animation, int Duration)
        {
            var sb = new Storyboard();
            var anim = new ThicknessAnimation()
            {
                From = From,
                To = To,
                Duration = new Duration(TimeSpan.FromMilliseconds(Duration)),
                EasingFunction = Animation,
            };

            Storyboard.SetTarget(anim, Object);
            Storyboard.SetTargetProperty(anim, Property);
            sb.Children.Add(anim);
            sb.Begin();

            return Task.CompletedTask;
        }
        public Task DoSizeAnimation(DependencyObject Object, Size From, Size To, PropertyPath Property, IEasingFunction Animation, int Duration)
        {
            var sb = new Storyboard();
            var anim = new SizeAnimation()
            {
                From = From,
                To = To,
                Duration = new Duration(TimeSpan.FromMilliseconds(Duration)),
                EasingFunction = Animation,
            };

            Storyboard.SetTarget(anim, Object);
            Storyboard.SetTargetProperty(anim, Property);
            sb.Children.Add(anim);
            sb.Begin();

            return Task.CompletedTask;
        }
        public Task DoColorAnimation(DependencyObject Object, Color From, Color To, PropertyPath Property, IEasingFunction Animation, int Duration)
        {
            var sb = new Storyboard();
            var anim = new ColorAnimation()
            {
                From = From,
                To = To,
                Duration = new Duration(TimeSpan.FromMilliseconds(Duration)),
                EasingFunction = Animation,
            };

            Storyboard.SetTarget(anim, Object);
            Storyboard.SetTargetProperty(anim, Property);
            sb.Children.Add(anim);
            sb.Begin();

            return Task.CompletedTask;
        }
        public Task DoRectangleAnimation(DependencyObject Object, Rect From, Rect To, PropertyPath Property, IEasingFunction Animation, int Duration)
        {
            var sb = new Storyboard();
            var anim = new RectAnimation()
            {
                From = From,
                To = To,
                Duration = new Duration(TimeSpan.FromMilliseconds(Duration)),
                EasingFunction = Animation,
            };

            Storyboard.SetTarget(anim, Object);
            Storyboard.SetTargetProperty(anim, Property);
            sb.Children.Add(anim);
            sb.Begin();

            return Task.CompletedTask;
        }
    }
}

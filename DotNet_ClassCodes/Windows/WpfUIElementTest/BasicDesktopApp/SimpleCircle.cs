using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace BasicDesktopApp;

public class SimpleCircle : UIElement
{
    public double Radius { get; set; }

    public static readonly DependencyProperty TimeProperty = 
        DependencyProperty.Register("Time", typeof(string), typeof(SimpleCircle), new PropertyMetadata("Hello World!"));

    public string Time
    {
        get => (string) GetValue(TimeProperty);
        set => SetValue(TimeProperty, value);
    }

    /*
    public static readonly DependencyProperty CountProperty =
        DependencyProperty.Register("Count", typeof(int), typeof(SimpleCircle));

    public int Count
    {
        get => (int) GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }
    */

    protected override void OnRender(DrawingContext drawingContext)
    {
        var anim = new DoubleAnimation(Radius, 10, TimeSpan.FromSeconds(5))
        {
            AutoReverse = true,
            RepeatBehavior = new RepeatBehavior(1) //RepeatBehavior.Forever
        };
        var clock = anim.CreateClock();

        var center = new Point(RenderSize.Width / 2, RenderSize.Height / 2);
        drawingContext.DrawEllipse(Brushes.Blue, new Pen(Brushes.Red, 5), center, null, Radius, clock, Radius, clock);
    }

    protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
    {
        Time = DateTime.Now.ToString();
        InvalidateVisual();
    }
}

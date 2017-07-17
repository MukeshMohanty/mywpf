using System.Windows;
using System.Windows.Interactivity;

namespace ExperimentBModule
{
    public class ClickTriggerAction : TriggerAction<UIElement>
    {
        public static DependencyProperty CountProperty =
            DependencyProperty.Register(
                "Count",
                typeof (int),
                typeof (ClickTriggerAction));

        public static DependencyProperty IncrementProperty =
            DependencyProperty.Register(
                "Increment",
                typeof (int),
                typeof (ClickTriggerAction));

        public int Count
        {
            get { return (int) GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        public int Increment
        {
            get { return (int) GetValue(IncrementProperty); }
            set { SetValue(IncrementProperty, value); }
        }

        protected override void Invoke(object parameter)
        {
            Count += Increment;
        }
    }
}
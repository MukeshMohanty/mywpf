using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ExperimentBModule
{
    public class IconButton : Button
    {
        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));
        }

        public const string IconPropertyName = "Icon";

        public FrameworkElement Icon
        {
            get
            {
                return (FrameworkElement)GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }
        public readonly DependencyProperty IconProperty = DependencyProperty.Register(
            IconPropertyName,
            typeof(FrameworkElement),
            typeof(IconButton));
    }
}

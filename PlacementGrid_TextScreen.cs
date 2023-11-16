using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INOXCanvasPrototype
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:INOXCanvasPrototype"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:INOXCanvasPrototype;assembly=INOXCanvasPrototype"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:PlacementGrid_TextScreen/>
    ///
    /// </summary>
    public class PlacementGrid_TextScreen : Control
    {


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(PlacementGrid_TextScreen), new PropertyMetadata(""));



        public bool isError
        {
            get { return (bool)GetValue(isErrorProperty); }
            set { SetValue(isErrorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for isError.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty isErrorProperty =
            DependencyProperty.Register("isError", typeof(bool), typeof(PlacementGrid_TextScreen), new PropertyMetadata(false));




        public PlacementGrid caller
        {
            get { return (PlacementGrid)GetValue(callerProperty); }
            set { SetValue(callerProperty, value); }
        }

        // Using a DependencyProperty as the backing store for caller.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty callerProperty =
            DependencyProperty.Register("caller", typeof(PlacementGrid), typeof(PlacementGrid_TextScreen), new PropertyMetadata(null));




        public int TextScreenHeight
        {
            get { return (int)GetValue(TextScreenHeightProperty); }
            set { SetValue(TextScreenHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Height.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextScreenHeightProperty =
            DependencyProperty.Register("TextScreenHeight", typeof(int), typeof(PlacementGrid_TextScreen), new PropertyMetadata(0));




        public int TextScreenWidth
        {
            get { return (int)GetValue(TextScreenWidthProperty); }
            set { SetValue(TextScreenWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Width.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextScreenWidthProperty =
            DependencyProperty.Register("TextScreenWidth", typeof(int), typeof(PlacementGrid_TextScreen), new PropertyMetadata(0));



        static PlacementGrid_TextScreen()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlacementGrid_TextScreen), new FrameworkPropertyMetadata(typeof(PlacementGrid_TextScreen)));

        }
    }
}

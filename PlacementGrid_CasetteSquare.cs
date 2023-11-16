namespace INOXCanvasPrototype
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading.Tasks.Dataflow;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

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
    ///     <MyNamespace:PlacementGrid_CasetteSquare/>
    ///
    /// </summary>
    public class PlacementGrid_CasetteSquare : Control
    {


        public string CassetteLabel
        {
            get { return (string)GetValue(CassetteLabelProperty); }
            set { SetValue(CassetteLabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CassetteLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CassetteLabelProperty =
            DependencyProperty.Register("CassetteLabel", typeof(string), typeof(PlacementGrid_CasetteSquare), new PropertyMetadata(""));


        public bool isSelected
        {
            get { return (bool)GetValue(isSelectedProperty); }
            set { SetValue(isSelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for isSelected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty isSelectedProperty =
            DependencyProperty.Register("isSelected", typeof(bool), typeof(PlacementGrid_CasetteSquare), new PropertyMetadata(false));


        public Cassette CassetteObject
        {
            get { return (Cassette)GetValue(CassetteObjectProperty); }
            set { SetValue(CassetteObjectProperty, value);
                            //Set cas posisiton
            Canvas.SetLeft(this, CassetteObject.startX * UnitSize);
            Canvas.SetTop(this, CassetteObject.startY * UnitSize);
                }
        }

        // Using a DependencyProperty as the backing store for CassetteObject.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CassetteObjectProperty =
            DependencyProperty.Register("CassetteObject", typeof(Cassette), typeof(PlacementGrid_CasetteSquare), new PropertyMetadata(null, OnCassetteSizeChanged));



        private static void UpdateCassetteActualHeight(DependencyObject d)
        {
            Cassette casObj = (Cassette)d.GetValue(CassetteObjectProperty);
            if (casObj != null)
            {
                int UnitSize = (int)d.GetValue(UnitSizeProperty);
                int result = casObj.Height * UnitSize;

                d.SetValue(CalculatedHeightProperty, result);
            }
        }

        private static void OnCassetteSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UpdateCassetteActualHeight(d);
            UpdateCassetteActualWidth(d);
        }

        private static void UpdateCassetteActualWidth(DependencyObject d)
        {
            Cassette casObj = (Cassette)d.GetValue(CassetteObjectProperty);
            if(casObj != null)
            {
                int UnitSize = (int)d.GetValue(UnitSizeProperty);
                int result = casObj.Width * UnitSize;

                d.SetValue(CalculatedWidthProperty, result);
            }

        }



        public int CalculatedHeight
        {
            get { return (int)GetValue(CalculatedHeightProperty); }
            set { SetValue(CalculatedHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CalculatedHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CalculatedHeightProperty =
            DependencyProperty.Register("CalculatedHeight", typeof(int), typeof(PlacementGrid_CasetteSquare), new PropertyMetadata(0));




        public int CalculatedWidth
        {
            get { return (int)GetValue(CalculatedWidthProperty); }
            set { SetValue(CalculatedWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CalculatedWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CalculatedWidthProperty =
            DependencyProperty.Register("CalculatedWidth", typeof(int), typeof(PlacementGrid_CasetteSquare), new PropertyMetadata(0));




        public int UnitSize
        {
            get { return (int)GetValue(UnitSizeProperty); }
            set { SetValue(UnitSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UnitSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UnitSizeProperty =
            DependencyProperty.Register("UnitSize", typeof(int), typeof(PlacementGrid_CasetteSquare), new PropertyMetadata(10, OnCassetteSizeChanged));




        static PlacementGrid_CasetteSquare()
        {
            //UnitSize = unitSize;

            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlacementGrid_CasetteSquare), new FrameworkPropertyMetadata(typeof(PlacementGrid_CasetteSquare)));


        }

        public override void BeginInit()
        {
            base.BeginInit();

        }

        public override void EndInit()
        {

            base.EndInit();

        }
    }
}

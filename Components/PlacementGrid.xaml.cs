namespace INOXCanvasPrototype.Components
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
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

    using INOXCanvasPrototype.Models;

    using static System.Net.Mime.MediaTypeNames;


    /// <summary>
    /// Interaction logic for PlacementGrid.xaml
    /// </summary>
    public partial class PlacementGrid : UserControl
    {

        //=============== SIZE DEPENDENCY PROPERTIES ===============
        public int UnitSize
        {
            get { return (int)GetValue(UnitSizeProperty); }
            set { SetValue(UnitSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UnitSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UnitSizeProperty =
            DependencyProperty.Register("UnitSize", typeof(int), typeof(PlacementGrid), new FrameworkPropertyMetadata(OnUnitSizeChanged));



        public int FehrUnitSize
        {
            get { return (int)GetValue(FehrUnitSizeProperty); }
            set { SetValue(FehrUnitSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FehrUnitSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FehrUnitSizeProperty =
            DependencyProperty.Register("FehrUnitSize", typeof(int), typeof(PlacementGrid), new PropertyMetadata(1));




        public int LogimatUnitSize
        {
            get { return (int)GetValue(LogimatUnitSizeProperty); }
            set { SetValue(LogimatUnitSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LogimatUnitSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LogimatUnitSizeProperty =
            DependencyProperty.Register("LogimatUnitSize", typeof(int), typeof(PlacementGrid), new PropertyMetadata(80));




        public int HeightUnits
        {
            get { return (int)GetValue(HeightUnitsProperty); }
            set { SetValue(HeightUnitsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeightUnits.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeightUnitsProperty =
            DependencyProperty.Register("HeightUnits", typeof(int), typeof(PlacementGrid), new PropertyMetadata(OnUnitSizeChanged));



        public int WidthUnits
        {
            get { return (int)GetValue(WidthUnitsProperty); }
            set { SetValue(WidthUnitsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WidthUnits.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WidthUnitsProperty =
            DependencyProperty.Register("WidthUnits", typeof(int), typeof(PlacementGrid), new PropertyMetadata(OnUnitSizeChanged));

        private static void UpdateCanvasActualHeight(DependencyObject d)
        {
            int UnitSize = (int)d.GetValue(UnitSizeProperty);
            int HeightUnits = (int)d.GetValue(HeightUnitsProperty);
            int result = UnitSize * HeightUnits;

            d.SetValue(CanvasHeightProperty, result);
        }

        private static void OnUnitSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UpdateCanvasActualHeight(d);
            UpdateCanvasActualWidth(d);
            if(Instance.Layout != null && Instance.Layout.isNotEmpty == true)
            {
                DrawLayout(Instance.Layout);
            }
        }

        private static void UpdateCanvasActualWidth(DependencyObject d)
        {
            int UnitSize = (int)d.GetValue(UnitSizeProperty);
            int HeightUnits = (int)d.GetValue(WidthUnitsProperty);
            int result = UnitSize * HeightUnits;

            d.SetValue(CanvasWidthProperty, result);
        }



        public int CanvasHeight
        {
            get { return (int)GetValue(CanvasHeightProperty); }
            set { SetValue(CanvasHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CanvasHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CanvasHeightProperty =
            DependencyProperty.Register("CanvasHeight", typeof(int), typeof(PlacementGrid), new FrameworkPropertyMetadata(50, FrameworkPropertyMetadataOptions.AffectsMeasure));




        public int CanvasWidth
        {
            get { return (int)GetValue(CanvasWidthProperty); }
            set { SetValue(CanvasWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CanvasWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CanvasWidthProperty =
            DependencyProperty.Register("CanvasWidth", typeof(int), typeof(PlacementGrid), new FrameworkPropertyMetadata(50, FrameworkPropertyMetadataOptions.AffectsMeasure));



        public Layout Layout
        {
            get { return (Layout)GetValue(LayoutProperty); }
            set { SetValue(LayoutProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Layout.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LayoutProperty =
            DependencyProperty.Register("Cassettes", typeof(Layout), typeof(PlacementGrid), new PropertyMetadata(new Layout {isNotEmpty = false}, onCalledDrawLayout));



        public List<PlacementGrid_Cassette> SelectedCassettes
        {
            get { return (List<PlacementGrid_Cassette>)GetValue(SelectedCassettesProperty); }
            set { SetValue(SelectedCassettesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedCassettes.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedCassettesProperty =
            DependencyProperty.Register("SelectedCassettes", typeof(List<PlacementGrid_Cassette>), typeof(PlacementGrid), new PropertyMetadata(null));




        public event RoutedEventHandler OnCassetteClick;
        private void posCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OnCassetteClick != null)
            {
                if (e.Source.GetType() == typeof(PlacementGrid_CasetteSquare))
                {
                    PlacementGrid_CasetteSquare clickedCasSquare = (PlacementGrid_CasetteSquare)e.Source;

                    if (clickedCasSquare != null)
                    {
                        OnCassetteClick(sender, e);
                    }
                }
            }
        }
        public static PlacementGrid Instance { get; private set; }
        public PlacementGrid()
        {

            Instance = this;
            InitializeComponent();

            //Set default values of dependency properties to make sure callback method runs
            //Layout = new Layout(); 
            UnitSize = 40;
            HeightUnits = 8;
            WidthUnits = 8;

        }

        static void onCalledDrawLayout(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Layout Layout = (Layout)e.NewValue;
            if (Layout != null && Layout.isNotEmpty == true)
            {
                DrawLayout(Layout);
            }
            else
            {
                Instance.posCanvas.Children.Clear();

                DrawTextScreenInternal("Layout is null", true);
            }
        }

        static void DrawLayout(Layout Layout)
        {
            Instance.posCanvas.Children.Clear();

            if(Layout != null)
            {
                //Not good - Add dependency property to control fehr unitsize and logimat unitsize separetly, and maby switch between them with bool
                if(Layout.RessourceType == "Fehr")
                {
                    Instance.UnitSize = Instance.FehrUnitSize;
                } else {
                    Instance.UnitSize = Instance.LogimatUnitSize;
                }

                
                Instance.HeightUnits = Layout.LengthUnits;
                Instance.WidthUnits = Layout.WidthUnits;

                foreach (PlacementGrid_Cassette CurCas in Layout.Cassettes)
                {
                    PlacementGrid_CasetteSquare casSq = new PlacementGrid_CasetteSquare();
                    casSq.UnitSize = Instance.UnitSize;
                    casSq.isSelected = false;
                    casSq.CassetteObject = CurCas;
                    // Add it all together
                    Instance.posCanvas.Children.Add(casSq);
                }
            }

        }

        public void DrawTextScreen(string text, bool isError = false)
        {
            Instance.Layout = null;

            Instance.posCanvas.Children.Clear();
            PlacementGrid_TextScreen pg_textscreen = new PlacementGrid_TextScreen();
            pg_textscreen.caller = Instance;
            pg_textscreen.Text = text;
            pg_textscreen.isError = isError;

            Instance.posCanvas.Children.Add(pg_textscreen);
        }

        static internal void DrawTextScreenInternal(string text, bool isError = false)
        {
            Instance.Layout = null;

            Instance.posCanvas.Children.Clear();
            PlacementGrid_TextScreen pg_textscreen = new PlacementGrid_TextScreen();
            pg_textscreen.caller = Instance;
            pg_textscreen.Text = text;
            pg_textscreen.isError = isError;

            Instance.posCanvas.Children.Add(pg_textscreen);
        }

        public void ClearSelection()
        {
            if(Instance.posCanvas.Children != null)
            {
                foreach (var child in Instance.posCanvas.Children)
                {
                    if(child.GetType() == typeof(PlacementGrid_CasetteSquare))
                    {

                        PlacementGrid_CasetteSquare cassette = (PlacementGrid_CasetteSquare)child;

                        SetSelectStateOfCassette(cassette.CassetteObject.ID, false);

                    }

                }
            }
           
        }

        public void SelectCassetteByID(int ID)
        {
            SetSelectStateOfCassette(ID, true);

        }

        public void UnSelectCassetteByID(int ID)
        {
           SetSelectStateOfCassette(ID, false);
        }

        internal void SetSelectStateOfCassette(int ID, bool SetIsSelectedTo)
        {
            if (Instance.posCanvas.Children != null)
            {
                foreach (var child in Instance.posCanvas.Children)
                {
                    if (child.GetType() == typeof(PlacementGrid_CasetteSquare))
                    {
                        PlacementGrid_CasetteSquare cassette = (PlacementGrid_CasetteSquare)child;

                        if (cassette.CassetteObject.ID == ID)
                        {
                            if(SetIsSelectedTo)
                            {
                                cassette.isSelected = true;

                                //Update Selected Items Dependency property
                                SelectedCassettes = GetCurrentSelectedCassettes();
                            } else
                            {
                                cassette.isSelected = false;

                                //Update Selected Items Dependency property
                                SelectedCassettes = GetCurrentSelectedCassettes();
                            }
                        }
                    }

                }
            }
        }

        public List<PlacementGrid_Cassette> GetCurrentSelectedCassettes()
        {
            List<PlacementGrid_Cassette> selectedCassettes = new List<PlacementGrid_Cassette>();


            if (Instance.posCanvas.Children != null)
            {
                foreach (var child in Instance.posCanvas.Children)
                {
                    if (child.GetType() == typeof(PlacementGrid_CasetteSquare))
                    {
                        PlacementGrid_CasetteSquare cassette = (PlacementGrid_CasetteSquare)child;

                        if (cassette.isSelected == true)
                        {
                            if(!selectedCassettes.Contains(cassette.CassetteObject))
                            {
                                selectedCassettes.Add(cassette.CassetteObject);
                            }
                        }
                    }
                }
            }

            return selectedCassettes;
        }

    }
}

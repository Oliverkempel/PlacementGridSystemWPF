namespace INOXCanvasPrototype
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows;
    using System.Windows.Shapes;


    public class PlacementGridHandler
    {
        List<Layout> layouts = new List<Layout>();

        public Layout selectedLayout;

        // DEFINE STYLING OF GRIDSYSTEM 
        public int SizeFactor = 4;

        public double borderThickness = 1.2;
        public double borderThickness_Selected = 1.2;

        public Color borderColor = (Color)ColorConverter.ConvertFromString("#000000");
        public Color borderColor_Selected = (Color)ColorConverter.ConvertFromString("#000000");

        public Color backgroundColor = (Color)ColorConverter.ConvertFromString("#e1e8e2");
        public Color backgroundColor_Selected = (Color)ColorConverter.ConvertFromString("#50d962");

        public Color textColor = (Color)ColorConverter.ConvertFromString("#858f86");
        public Color textColor_Selected = (Color)ColorConverter.ConvertFromString("#ffffff");

        public FontWeight textWeight = FontWeights.Regular;
        public FontWeight textWeight_Selected = FontWeights.Bold;



        public Canvas posCanvas { get; set; }
        public Border posCanvasBorder { get; set; }
        public PlacementGridHandler(Canvas PosCanvas, Border PosCanvasBorder)
        {
            posCanvas = PosCanvas;
            posCanvasBorder = PosCanvasBorder;

            LoadLayoutsConfig();
            initLayout();

        }

        public void initLayout()
        {
            posCanvasBorder.BorderThickness = new Thickness(borderThickness);
            //Canvas Size
            if (selectedLayout != null)
            {
                posCanvas.Width = (selectedLayout.WidthUnits * 10) * (double)SizeFactor;
                posCanvas.Height = (selectedLayout.LengthUnits * 10) * (double)SizeFactor;
            }
            else
            {
                posCanvas.Width = 280 * (double)SizeFactor;
                posCanvas.Height = 80 * (double)SizeFactor;
                DrawNotFound();
            }

        }

        public void UpdateCanvasSize()
        {
            posCanvasBorder.BorderThickness = new Thickness(borderThickness);

            if (selectedLayout != null)
            {
                posCanvas.Width = (selectedLayout.WidthUnits * 10) * (double)SizeFactor;
                posCanvas.Height = (selectedLayout.LengthUnits * 10) * (double)SizeFactor;
            }
            else
            {
                posCanvas.Width = 280 * (double)SizeFactor;
                posCanvas.Height = 80 * (double)SizeFactor;
            }
        }

        public void DrawNotFound(int id = 0)
        {

            if (id == 0)
            {
                //object resource = Application.Current.TryFindResource("menu_Overview");
                //drawTextScreen(resource.ToString());
                drawTextScreen(@$"No selection!");

            }
            else
            {
                drawTextScreen($@"NO LAYOUT FOUND IN Layout_Config.json That corresponds to layout ID: {id}");
            }

        }

        public void DrawMultipleSelection()
        {
            drawTextScreen(@$"Multiple lines are currently selected!");
        }

        public void drawTextScreen(string text)
        {
            //UpdateCanvasSize();
            //initLayout();
            posCanvas.Width = 280 * (double)SizeFactor;
            posCanvas.Height = 80 * (double)SizeFactor;

            Rectangle rectangle = new Rectangle();
            rectangle.StrokeThickness = borderThickness;
            rectangle.Stroke = new SolidColorBrush(borderColor);
            rectangle.Width = 280 * (double)SizeFactor;
            rectangle.Height = 80 * (double)SizeFactor;

            //Grid
            Grid grid = new Grid();
            grid.Background = new SolidColorBrush(backgroundColor);

            //Textblock
            TextBlock textblock = new TextBlock();
            textblock.FontSize = 18;

            textblock.Text = text;

            textblock.Foreground = new SolidColorBrush(textColor);
            textblock.FontWeight = FontWeights.Bold;
            textblock.VerticalAlignment = VerticalAlignment.Center;
            textblock.HorizontalAlignment = HorizontalAlignment.Center;

            //Set grid posisiton
            Canvas.SetLeft(grid, 0);
            Canvas.SetTop(grid, 0);

            // Add it all together
            grid.Children.Add(rectangle);
            grid.Children.Add(textblock);
            posCanvas.Children.Add(grid);
        }

        public void DrawLayout(int LayoutID)
        {
            posCanvas.Children.Clear();
            selectedLayout = null;
            Layout layout = layouts.FirstOrDefault(x => x.LayoutID == LayoutID);
            if (layout == null)
            {
                DrawNotFound(LayoutID);
            }
            else
            {
                selectedLayout = layout;

                initLayout();
                foreach (Cassette cas in selectedLayout.Cassettes)
                {
                    drawCasette(cas);
                }
            }
        }

        public void highlightCasette(int CasId)
        {
            if (selectedLayout != null)
            {
                Cassette cassete = selectedLayout.Cassettes.Where(x => x.ID == CasId).FirstOrDefault();
                if (CasId > 0 && CasId <= selectedLayout.getMaxID())
                {
                    drawCasette(cassete, true);
                }
            }
        }

        public void unhighlightCasette(int CasId)
        {
            Cassette cassete = selectedLayout.Cassettes.Where(x => x.ID == CasId).FirstOrDefault();

            drawCasette(cassete, false);
        }

        public void drawCasette(Cassette cas, bool isHighlighted = false)
        {
            double StrokeThickness;
            FontWeight fontWeight;
            Color StrokeColor;
            Color BackgroundColor;
            Color TextColor;

            if (isHighlighted)
            {
                fontWeight = textWeight_Selected;
                StrokeThickness = borderThickness_Selected;
                StrokeColor = borderColor_Selected;
                BackgroundColor = backgroundColor_Selected;
                TextColor = textColor_Selected;
            }
            else
            {
                fontWeight = textWeight;
                StrokeThickness = borderThickness;
                StrokeColor = borderColor;
                BackgroundColor = backgroundColor;
                TextColor = textColor;
            }

            // Rectangle 
            Rectangle rectangle = new Rectangle();
            rectangle.StrokeThickness = StrokeThickness;
            rectangle.Stroke = new SolidColorBrush(StrokeColor);
            //rectangle.Fill = new SolidColorBrush(Colors.Black);
            rectangle.Width = cas.Width * (SizeFactor * 10);
            rectangle.Height = cas.Height * (SizeFactor * 10);

            //Grid
            Grid grid = new Grid();
            grid.Background = new SolidColorBrush(BackgroundColor);

            //Textblock
            TextBlock textblock = new TextBlock();
            textblock.Text = cas.ID.ToString();
            textblock.Foreground = new SolidColorBrush(TextColor);
            textblock.FontWeight = fontWeight;
            textblock.VerticalAlignment = VerticalAlignment.Center;
            textblock.HorizontalAlignment = HorizontalAlignment.Center;

            //Set grid posisiton
            Canvas.SetLeft(grid, cas.startX * (SizeFactor * 10));
            Canvas.SetTop(grid, cas.startY * (SizeFactor * 10));

            // Add it all together
            grid.Children.Add(rectangle);
            grid.Children.Add(textblock);
            posCanvas.Children.Add(grid);
        }

        public void SerializeJson(List<Object> list)
        {
            //var opt = new JsonSerializerOptions() { WriteIndented = true };
            //byte[] utf8bytesJson = JsonSerializer.SerializeToUtf8Bytes(layouts);
            //string strJson = System.Text.Encoding.UTF8.GetString(utf8bytesJson);
            //string jsonString = JsonSerializer.Serialize(list, opt);
        }

        public void LoadLayoutsConfig()
        {
            using (StreamReader r = new StreamReader("Layouts_Config.json"))
            {
                string json = r.ReadToEnd();

                //layouts = LayoutsConfigJsonConverter.FromJson(json);
            }

        }
    }
    
}


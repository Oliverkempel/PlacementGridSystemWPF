namespace INOXCanvasPrototype
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
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
    using INOXCanvasPrototype.Components;
    using INOXCanvasPrototype.Converters;


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Layout LayoutOne = new Layout
        {
            LayoutID = 1,
            LengthUnits = 8,
            WidthUnits = 28,
            Height = 15,
            Cassettes =

                new List<PlacementGrid_Cassette>{
                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 0, startY = 0, ID = 1 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 2, startY = 0, ID = 2 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 2, startY = 1, ID = 3 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 3, startY = 0, ID = 4 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 3, startY = 1, ID = 5 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 4, startY = 0, ID = 6 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 6, startY = 0, ID = 7 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 6, startY = 1, ID = 8 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 7, startY = 0, ID = 9 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 7, startY = 1, ID = 10 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 8, startY = 0, ID = 11 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 10, startY = 0, ID = 12 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 10, startY = 1, ID = 13 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 11, startY = 0, ID = 14 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 11, startY = 1, ID = 15 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 12, startY = 0, ID = 16 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 14, startY = 0, ID = 17 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 14, startY = 1, ID = 18 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 15, startY = 0, ID = 19 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 15, startY = 1, ID = 20 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 16, startY = 0, ID = 21 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 18, startY = 0, ID = 22 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 18, startY = 1, ID = 23 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 19, startY = 0, ID = 24 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 19, startY = 1, ID = 25 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 20, startY = 0, ID = 26 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 22, startY = 0, ID = 27 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 22, startY = 1, ID = 28 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 23, startY = 0, ID = 29 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 23, startY = 1, ID = 30 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 24, startY = 0, ID = 31 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 26, startY = 0, ID = 32 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 26, startY = 1, ID = 33 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 27, startY = 0, ID = 34 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 27, startY = 1, ID = 35 },



                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 2, startY = 2, ID = 36 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 0, startY = 2, ID = 37 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 0, startY = 3, ID = 38 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 1, startY = 2, ID = 39 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 1, startY = 3, ID = 40 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 6,  startY = 2, ID = 41 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 4, startY = 2, ID = 42 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 4, startY = 3, ID = 43 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 5, startY = 2, ID = 44 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 5, startY = 3, ID = 45 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 10, startY = 2, ID = 46 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 8, startY = 2, ID = 47 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 8, startY = 3, ID = 48 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 9, startY = 2, ID = 49 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 9, startY = 3, ID = 50 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 14, startY = 2, ID = 51 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 12, startY = 2, ID = 52 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 12, startY = 3, ID = 53 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 13, startY = 2, ID = 54 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 13, startY = 3, ID = 55 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 18, startY = 2, ID = 56 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 16, startY = 2, ID = 57 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 16,startY = 3, ID = 58 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 17,startY = 2, ID = 59 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 17,startY = 3, ID = 60 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 22,startY = 2, ID = 61 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 20,startY = 2, ID = 62 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 20,startY = 3, ID = 63 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 21,startY = 2, ID = 64 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 21,startY = 3, ID = 67 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 26,startY = 2, ID = 68 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 24,startY = 2, ID = 69 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 24,startY = 3, ID = 70 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 25,startY = 2, ID = 71 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 25,startY = 3, ID = 72 },


                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 0, startY = 4, ID = 73 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 2, startY = 4, ID = 74 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 2, startY = 5, ID = 75 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 3, startY = 4, ID = 76 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 3, startY = 5, ID = 77 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 4, startY = 4, ID = 78 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 6, startY = 4, ID = 79 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 6, startY = 5, ID = 80 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 7, startY = 4, ID = 81 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 7, startY = 5, ID = 82 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 8, startY = 4, ID = 83 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 10, startY = 4, ID = 84 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 10, startY = 5, ID = 85 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 11, startY = 4, ID = 86 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 11, startY = 5, ID = 87 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 12, startY = 4, ID = 88 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 14, startY = 4, ID = 89 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 14, startY = 5, ID = 90 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 15, startY = 4, ID = 91 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 15, startY = 5, ID = 92 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 16, startY = 4, ID = 93 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 18, startY = 4, ID = 94 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 18, startY = 5, ID = 95 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 19, startY = 4, ID = 96 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 19, startY = 5, ID = 97 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 20, startY = 4, ID = 98 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 22, startY = 4, ID = 99 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 22, startY = 5, ID = 100 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 23, startY = 4, ID = 101 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 23, startY = 5, ID = 102 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 24, startY = 4, ID = 103 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 26, startY = 4, ID = 104 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 26, startY = 5, ID = 105 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 27, startY = 4, ID = 106 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 27, startY = 5, ID = 107 },




                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 2, startY = 6, ID = 108 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 0, startY = 6, ID = 109 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 0, startY = 7, ID = 110 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 1, startY = 6, ID = 111},
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 1, startY = 7, ID = 112 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 6,  startY = 6, ID = 113 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 4, startY = 6, ID = 114 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 4, startY = 7, ID = 115 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 5, startY = 6, ID = 116 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 5, startY = 7, ID = 117 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 10, startY = 6, ID = 118 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 8, startY = 6, ID = 119 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 8, startY = 7, ID = 120 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 9, startY = 6, ID = 121 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 9, startY = 7, ID = 122 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 14, startY = 6, ID = 123 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 12, startY = 6, ID = 124},
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 12, startY = 7, ID = 125 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 13, startY = 6, ID = 126 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 13, startY = 7, ID = 127 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 18, startY = 6, ID = 128 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 16, startY = 6, ID = 129 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 16,startY = 7, ID = 130 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 17,startY = 6, ID = 131 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 17,startY = 7, ID = 132 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 22,startY = 6, ID = 133 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 20,startY = 6, ID = 134 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 20,startY = 7, ID = 135 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 21,startY = 6, ID = 136 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 21,startY = 7, ID = 137 },

                new PlacementGrid_Cassette { Height = 2, Width = 2, startX = 26,startY = 6, ID = 138 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 24,startY = 6, ID = 139 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 24,startY = 7, ID = 140 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 25,startY = 6, ID = 141 },
                new PlacementGrid_Cassette { Height = 1, Width = 1, startX = 25,startY = 7, ID = 142 },

                }
        };

        public Layout LayoutTwo = new Layout
        {
            LayoutID = 2,
            LengthUnits = 8,
            WidthUnits = 28,
            Height = 25,
            Cassettes = new List<PlacementGrid_Cassette>
            {
                new PlacementGrid_Cassette {startX = 0, startY = 0, Height = 4, Width = 2, ID = 1},
                new PlacementGrid_Cassette {startX = 2, startY = 0, Height = 4, Width = 1, ID = 2},
                new PlacementGrid_Cassette {startX = 3, startY = 0, Height = 4, Width = 1, ID = 3},

                new PlacementGrid_Cassette {startX = 4, startY = 0, Height = 4, Width = 2, ID = 4},
                new PlacementGrid_Cassette {startX = 6, startY = 0, Height = 4, Width = 1, ID = 5},
                new PlacementGrid_Cassette {startX = 7, startY = 0, Height = 4, Width = 1, ID = 6},

                new PlacementGrid_Cassette {startX = 8, startY = 0, Height = 4, Width = 2, ID = 7},
                new PlacementGrid_Cassette {startX = 10, startY = 0, Height = 4, Width = 1, ID = 8},
                new PlacementGrid_Cassette {startX = 11, startY = 0, Height = 4, Width = 1, ID = 9},

                new PlacementGrid_Cassette {startX = 12, startY = 0, Height = 4, Width = 2, ID = 10},
                new PlacementGrid_Cassette {startX = 14, startY = 0, Height = 4, Width = 1, ID = 11},
                new PlacementGrid_Cassette {startX = 15, startY = 0, Height = 4, Width = 1, ID = 12},

                new PlacementGrid_Cassette {startX = 16, startY = 0, Height = 4, Width = 2, ID = 13},
                new PlacementGrid_Cassette {startX = 18, startY = 0, Height = 4, Width = 1, ID = 14},
                new PlacementGrid_Cassette {startX = 19, startY = 0, Height = 4, Width = 1, ID = 15},

                new PlacementGrid_Cassette {startX = 20, startY = 0, Height = 4, Width = 2, ID = 16},
                new PlacementGrid_Cassette {startX = 22, startY = 0, Height = 4, Width = 1, ID = 17},
                new PlacementGrid_Cassette {startX = 23, startY = 0, Height = 4, Width = 1, ID = 18},

                new PlacementGrid_Cassette {startX = 24, startY = 0, Height = 4, Width = 2, ID = 19},
                new PlacementGrid_Cassette {startX = 26, startY = 0, Height = 4, Width = 1, ID = 20},
                new PlacementGrid_Cassette {startX = 27, startY = 0, Height = 4, Width = 1, ID = 21},



                new PlacementGrid_Cassette {startX = 0, startY = 4, Height = 4, Width = 1, ID = 22},
                new PlacementGrid_Cassette {startX = 1, startY = 4, Height = 4, Width = 1, ID = 23},
                new PlacementGrid_Cassette {startX = 2, startY = 4, Height = 4, Width = 2, ID = 24},

                new PlacementGrid_Cassette {startX = 4, startY = 4, Height = 4, Width = 1, ID = 26},
                new PlacementGrid_Cassette {startX = 5, startY = 4, Height = 4, Width = 1, ID = 26},
                new PlacementGrid_Cassette {startX = 6, startY = 4, Height = 4, Width = 2, ID = 27},

                new PlacementGrid_Cassette {startX = 8, startY = 4, Height = 4, Width = 1, ID = 28},
                new PlacementGrid_Cassette {startX = 9, startY = 4, Height = 4, Width = 1, ID = 29},
                new PlacementGrid_Cassette {startX = 10, startY = 4, Height = 4, Width = 2, ID = 20},

                new PlacementGrid_Cassette {startX = 12, startY = 4, Height = 4, Width = 1, ID = 31},
                new PlacementGrid_Cassette {startX = 13, startY = 4, Height = 4, Width = 1, ID = 32},
                new PlacementGrid_Cassette {startX = 14, startY = 4, Height = 4, Width = 2, ID = 33},

                new PlacementGrid_Cassette {startX = 16, startY = 4, Height = 4, Width = 1, ID = 34},
                new PlacementGrid_Cassette {startX = 17, startY = 4, Height = 4, Width = 1, ID = 35},
                new PlacementGrid_Cassette {startX = 18, startY = 4, Height = 4, Width = 2, ID = 36},

                new PlacementGrid_Cassette {startX = 20, startY = 4, Height = 4, Width = 1, ID = 37},
                new PlacementGrid_Cassette {startX = 21, startY = 4, Height = 4, Width = 1, ID = 38},
                new PlacementGrid_Cassette {startX = 22, startY = 4, Height = 4, Width = 2, ID = 39},

                new PlacementGrid_Cassette {startX = 24, startY = 4, Height = 4, Width = 1, ID = 40},
                new PlacementGrid_Cassette {startX = 25, startY = 4, Height = 4, Width = 1, ID = 41},
                new PlacementGrid_Cassette {startX = 26, startY = 4, Height = 4, Width = 2, ID = 42},
            }
        };

        public Layout LayoutThree = new Layout
        {
            LayoutID = 3,
            LengthUnits = 8,
            WidthUnits = 28,
            Height = 25,
            Cassettes = new List<PlacementGrid_Cassette>
            {
                new PlacementGrid_Cassette {startX = 0, startY = 0, Width = 7, Height = 7, ID = 1},

                new PlacementGrid_Cassette {startX = 0, startY = 7, Width = 1, Height = 1, ID = 2},
                new PlacementGrid_Cassette {startX = 1, startY = 7, Width = 1, Height = 1, ID = 3},
                new PlacementGrid_Cassette {startX = 2, startY = 7, Width = 1, Height = 1, ID = 4},
                new PlacementGrid_Cassette {startX = 3, startY = 7, Width = 1, Height = 1, ID = 5},
                new PlacementGrid_Cassette {startX = 4, startY = 7, Width = 1, Height = 1, ID = 6},
                new PlacementGrid_Cassette {startX = 5, startY = 7, Width = 1, Height = 1, ID = 7},
                new PlacementGrid_Cassette {startX = 6, startY = 7, Width = 1, Height = 1, ID = 8},

                new PlacementGrid_Cassette {startX = 7, startY = 0, Width = 1, Height = 2, ID = 9},
                new PlacementGrid_Cassette {startX = 7, startY = 2, Width = 1, Height = 2, ID = 10},
                new PlacementGrid_Cassette {startX = 7, startY = 4, Width = 1, Height = 2, ID = 11},
                new PlacementGrid_Cassette {startX = 7, startY = 6, Width = 1, Height = 2, ID = 12},

                new PlacementGrid_Cassette {startX = 8, startY = 0, Width = 7, Height = 7, ID = 13},

                new PlacementGrid_Cassette {startX = 8, startY = 7, Width = 1, Height = 1, ID = 14},
                new PlacementGrid_Cassette {startX = 9, startY = 7, Width = 1, Height = 1, ID = 15},
                new PlacementGrid_Cassette {startX = 10, startY = 7, Width = 1, Height = 1, ID = 16},
                new PlacementGrid_Cassette {startX = 11, startY = 7, Width = 1, Height = 1, ID = 17},
                new PlacementGrid_Cassette {startX = 12, startY = 7, Width = 1, Height = 1, ID = 18},
                new PlacementGrid_Cassette {startX = 13, startY = 7, Width = 1, Height = 1, ID = 19},
                new PlacementGrid_Cassette {startX = 14, startY = 7, Width = 1, Height = 1, ID = 20},

                new PlacementGrid_Cassette {startX = 15, startY = 0, Width = 1, Height = 2, ID = 21},
                new PlacementGrid_Cassette {startX = 15, startY = 2, Width = 1, Height = 2, ID = 22},
                new PlacementGrid_Cassette {startX = 15, startY = 4, Width = 1, Height = 2, ID = 23},
                new PlacementGrid_Cassette {startX = 15, startY = 6, Width = 1, Height = 2, ID = 24},

                new PlacementGrid_Cassette {startX = 16, startY = 0, Width = 7, Height = 7, ID = 25},

                new PlacementGrid_Cassette {startX = 16, startY = 7, Width = 1, Height = 1, ID = 26},
                new PlacementGrid_Cassette {startX = 17, startY = 7, Width = 1, Height = 1, ID = 27},
                new PlacementGrid_Cassette {startX = 18, startY = 7, Width = 1, Height = 1, ID = 28},
                new PlacementGrid_Cassette {startX = 19, startY = 7, Width = 1, Height = 1, ID = 29},
                new PlacementGrid_Cassette {startX = 20, startY = 7, Width = 1, Height = 1, ID = 30},
                new PlacementGrid_Cassette {startX = 21, startY = 7, Width = 1, Height = 1, ID = 31},
                new PlacementGrid_Cassette {startX = 22, startY = 7, Width = 1, Height = 1, ID = 32},


                new PlacementGrid_Cassette {startX = 23, startY = 0, Width = 2, Height = 2, ID = 33},
                new PlacementGrid_Cassette {startX = 25, startY = 0, Width = 2, Height = 2, ID = 34},
                new PlacementGrid_Cassette {startX = 27, startY = 0, Width = 1, Height = 1, ID = 35},
                new PlacementGrid_Cassette {startX = 27, startY = 1, Width = 1, Height = 1, ID = 36},

                new PlacementGrid_Cassette {startX = 23, startY = 2, Width = 1, Height = 1, ID = 37},
                new PlacementGrid_Cassette {startX = 23, startY = 3, Width = 1, Height = 1, ID = 38},
                new PlacementGrid_Cassette {startX = 24, startY = 2, Width = 2, Height = 2, ID = 39},
                new PlacementGrid_Cassette {startX = 26, startY = 2, Width = 2, Height = 2, ID = 40},

                new PlacementGrid_Cassette {startX = 23, startY = 4, Width = 2, Height = 2, ID = 41},
                new PlacementGrid_Cassette {startX = 25, startY = 4, Width = 2, Height = 2, ID = 42},
                new PlacementGrid_Cassette {startX = 27, startY = 4, Width = 1, Height = 1, ID = 43},
                new PlacementGrid_Cassette {startX = 27, startY = 5, Width = 1, Height = 1, ID = 44},

                new PlacementGrid_Cassette {startX = 23, startY = 6, Width = 1, Height = 1, ID = 45},
                new PlacementGrid_Cassette {startX = 23, startY = 7, Width = 1, Height = 1, ID = 46},
                new PlacementGrid_Cassette {startX = 24, startY = 6, Width = 2, Height = 2, ID = 47},
                new PlacementGrid_Cassette {startX = 26, startY = 6, Width = 2, Height = 2, ID = 48},



            }
        };

        public Layout LayoutFour = new Layout
        {
            LayoutID = 4,
            LengthUnits = 8,
            WidthUnits = 28,
            Height = 25,
            Cassettes = new List<PlacementGrid_Cassette>
            {
                new PlacementGrid_Cassette {startX = 0, startY = 0, Width = 4, Height = 4, ID = 1},
                new PlacementGrid_Cassette {startX = 4, startY = 0, Width = 2, Height = 4, ID = 2},
                new PlacementGrid_Cassette {startX = 6, startY = 0, Width = 2, Height = 4, ID = 3},

                new PlacementGrid_Cassette {startX = 8, startY = 0, Width = 4, Height = 4, ID = 4},
                new PlacementGrid_Cassette {startX = 12, startY = 0, Width = 2, Height = 4, ID = 5},
                new PlacementGrid_Cassette {startX = 14, startY = 0, Width = 2, Height = 4, ID = 6},

                new PlacementGrid_Cassette {startX = 16, startY = 0, Width = 4, Height = 4, ID = 7},
                new PlacementGrid_Cassette {startX = 20, startY = 0, Width = 2, Height = 4, ID = 8},
                new PlacementGrid_Cassette {startX = 22, startY = 0, Width = 2, Height = 4, ID = 9},

                new PlacementGrid_Cassette {startX = 24, startY = 0, Width = 4, Height = 4, ID = 10},



                new PlacementGrid_Cassette {startX = 0, startY = 4, Width = 1, Height = 4, ID = 11},
                new PlacementGrid_Cassette {startX = 1, startY = 4, Width = 1, Height = 4, ID = 12},
                new PlacementGrid_Cassette {startX = 2, startY = 4, Width = 1, Height = 4, ID = 13},
                new PlacementGrid_Cassette {startX = 3, startY = 4, Width = 1, Height = 4, ID = 14},

                new PlacementGrid_Cassette {startX = 4, startY = 4, Width = 4, Height = 4, ID = 15},

                new PlacementGrid_Cassette {startX = 8, startY = 4, Width = 1, Height = 4, ID = 16},
                new PlacementGrid_Cassette {startX = 9, startY = 4, Width = 1, Height = 4, ID = 17},
                new PlacementGrid_Cassette {startX = 10, startY = 4, Width = 1, Height = 4, ID = 18},
                new PlacementGrid_Cassette {startX = 11, startY = 4, Width = 1, Height = 4, ID = 19},

                new PlacementGrid_Cassette {startX = 12, startY = 4, Width = 4, Height = 4, ID = 20},

                new PlacementGrid_Cassette {startX = 16, startY = 4, Width = 1, Height = 4, ID = 21},
                new PlacementGrid_Cassette {startX = 17, startY = 4, Width = 1, Height = 4, ID = 22},
                new PlacementGrid_Cassette {startX = 18, startY = 4, Width = 1, Height = 4, ID = 23},
                new PlacementGrid_Cassette {startX = 19, startY = 4, Width = 1, Height = 4, ID = 24},

                new PlacementGrid_Cassette {startX = 20, startY = 4, Width = 4, Height = 4, ID = 25},

                new PlacementGrid_Cassette {startX = 24, startY = 4, Width = 1, Height = 4, ID = 26},
                new PlacementGrid_Cassette {startX = 25, startY = 4, Width = 1, Height = 4, ID = 27},
                new PlacementGrid_Cassette {startX = 26, startY = 4, Width = 1, Height = 4, ID = 28},
                new PlacementGrid_Cassette {startX = 27, startY = 4, Width = 1, Height = 4, ID = 29},

            }
        };

        public Layout LayoutFive = new Layout
        {
            LayoutID = 5,
            LengthUnits = 8,
            WidthUnits = 28,
            Height = 25,
            Cassettes = new List<PlacementGrid_Cassette>
            {
                new PlacementGrid_Cassette {startX = 0, startY = 0, Width = 6, Height = 6, ID = 1},


                new PlacementGrid_Cassette {startX = 6, startY = 0, Width = 1, Height = 2, ID = 2},
                new PlacementGrid_Cassette {startX = 6, startY = 2, Width = 1, Height = 2, ID = 3},
                new PlacementGrid_Cassette {startX = 6, startY = 4, Width = 1, Height = 2, ID = 4},

                new PlacementGrid_Cassette {startX = 7, startY = 0, Width = 6, Height = 6, ID = 5},

                new PlacementGrid_Cassette {startX = 13, startY = 0, Width = 1, Height = 2, ID = 6},
                new PlacementGrid_Cassette {startX = 13, startY = 2, Width = 1, Height = 2, ID = 7},
                new PlacementGrid_Cassette {startX = 13, startY = 4, Width = 1, Height = 2, ID = 8},

                new PlacementGrid_Cassette {startX = 14, startY = 0, Width = 6, Height = 6, ID = 9},

                new PlacementGrid_Cassette {startX = 20, startY = 0, Width = 1, Height = 2, ID = 10},
                new PlacementGrid_Cassette {startX = 20, startY = 2, Width = 1, Height = 2, ID = 11},
                new PlacementGrid_Cassette {startX = 20, startY = 4, Width = 1, Height = 2, ID = 12},

                new PlacementGrid_Cassette {startX = 21, startY = 0, Width = 6, Height = 6, ID = 13},

                new PlacementGrid_Cassette {startX = 27, startY = 0, Width = 1, Height = 2, ID = 14},
                new PlacementGrid_Cassette {startX = 27, startY = 2, Width = 1, Height = 2, ID = 15},
                new PlacementGrid_Cassette {startX = 27, startY = 4, Width = 1, Height = 2, ID = 16},

                new PlacementGrid_Cassette {startX = 0, startY = 6, Width = 2, Height = 2, ID = 17},
                new PlacementGrid_Cassette {startX = 2, startY = 6, Width = 2, Height = 2, ID = 18},
                new PlacementGrid_Cassette {startX = 4, startY = 6, Width = 2, Height = 2, ID = 19},
                new PlacementGrid_Cassette {startX = 6, startY = 6, Width = 2, Height = 2, ID = 20},
                new PlacementGrid_Cassette {startX = 8, startY = 6, Width = 2, Height = 2, ID = 21},
                new PlacementGrid_Cassette {startX = 10, startY = 6, Width = 2, Height = 2, ID = 22},
                new PlacementGrid_Cassette {startX = 12, startY = 6, Width = 2, Height = 2, ID = 23},
                new PlacementGrid_Cassette {startX = 14, startY = 6, Width = 2, Height = 2, ID = 24},
                new PlacementGrid_Cassette {startX = 16, startY = 6, Width = 2, Height = 2, ID = 25},
                new PlacementGrid_Cassette {startX = 18, startY = 6, Width = 2, Height = 2, ID = 26},
                new PlacementGrid_Cassette {startX = 20, startY = 6, Width = 2, Height = 2, ID = 27},
                new PlacementGrid_Cassette {startX = 22, startY = 6, Width = 2, Height = 2, ID = 28},
                new PlacementGrid_Cassette {startX = 24, startY = 6, Width = 2, Height = 2, ID = 29},
                new PlacementGrid_Cassette {startX = 26, startY = 6, Width = 2, Height = 2, ID = 30},





            }
        };

        public Layout LayoutTwelve = new Layout
        {
            LayoutID = 12,
            LengthUnits = 8,
            WidthUnits = 24,
            Height = 35,
            Cassettes = new List<PlacementGrid_Cassette>
            {
                new PlacementGrid_Cassette {startX = 0, startY = 0, Width = 4, Height = 4, ID = 1},
                new PlacementGrid_Cassette {startX = 4, startY = 0, Width = 2, Height = 4, ID = 2},
                new PlacementGrid_Cassette {startX = 6, startY = 0, Width = 4, Height = 4, ID = 3},
                new PlacementGrid_Cassette {startX = 10, startY = 0, Width = 2, Height = 4, ID = 4},
                new PlacementGrid_Cassette {startX = 12, startY = 0, Width = 4, Height = 4, ID = 5},
                new PlacementGrid_Cassette {startX = 16, startY = 0, Width = 2, Height = 4, ID = 6},
                new PlacementGrid_Cassette {startX = 18, startY = 0, Width = 4, Height = 4, ID = 7},
                new PlacementGrid_Cassette {startX = 22, startY = 0, Width = 2, Height = 4, ID = 8},

                new PlacementGrid_Cassette {startX = 0, startY = 4, Width = 2, Height = 4, ID = 9},
                new PlacementGrid_Cassette {startX = 2, startY = 4, Width = 4, Height = 4, ID = 10},
                new PlacementGrid_Cassette {startX = 6, startY = 4, Width = 2, Height = 4, ID = 11},
                new PlacementGrid_Cassette {startX = 8, startY = 4, Width = 4, Height = 4, ID = 12},
                new PlacementGrid_Cassette {startX = 12, startY = 4, Width = 2, Height = 4, ID = 13},
                new PlacementGrid_Cassette {startX = 14, startY = 4, Width = 4, Height = 4, ID = 14},
                new PlacementGrid_Cassette {startX = 18, startY = 4, Width = 2, Height = 4, ID = 15},
                new PlacementGrid_Cassette {startX = 20, startY = 4, Width = 4, Height = 4, ID = 16},

            }
        };

        public PlacementGridHandler phandler;

        List<Layout> Layouts = new List<Layout>();

        List<PlacementGrid_LayoutsSets> LayoutsSets = new List<PlacementGrid_LayoutsSets>();



        public MainWindow()
        {
            InitializeComponent();
            LoadLayoutsConfig();
        }

       


        private void button_ChangeLayout(object sender, RoutedEventArgs e)
        {
            string output = inputBox2.Text;
            string resource = RessourceType.Text;

            int int_output = 0;

            Int32.TryParse(output, out int_output);

            Layout selectedLayout = null;

            try
            {
               selectedLayout = LayoutsSets.FirstOrDefault(x => x.Ressource == RessourceType.Text).Layouts.FirstOrDefault(x => x.LayoutID == int_output);

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            placementGrid.Layout = selectedLayout;
        }        
        
        private void button_SetToTextScreen(object sender, RoutedEventArgs e)
        {
            placementGrid.DrawTextScreen("No Lines selected!");

            //placementGrid.DrawTextScreen("No Lines selected!");


            

        }

        private void placementGrid_OnCassetteClick(object sender, RoutedEventArgs e)
        {
            //placementGrid.ClearSelection();

            PlacementGrid_CasetteSquare clickedCasSquare = (PlacementGrid_CasetteSquare)e.Source;
            PlacementGrid_Cassette cas = clickedCasSquare.CassetteObject;

            if (clickedCasSquare.isSelected == false)
            {
                placementGrid.SelectCassetteByID(cas.ID);

            }
            else
            {
                placementGrid.UnSelectCassetteByID(cas.ID);

            }

            //MessageBox.Show($"Clicked PlacementGrid_Cassette ID: {cas.ID}");

        }
        
        private void button_SetSelectID(object sender, RoutedEventArgs e)
        {
            int id;

            if(Int32.TryParse(SelectID.Text, out id)) 
            {
                //placementGrid.ClearSelection();
                placementGrid.SelectCassetteByID(id);

                var selectedcasss = placementGrid.SelectedCassettes;
            }

        }

        public void LoadLayoutsConfig()
        {
            using (StreamReader r = new StreamReader("Layouts_Config.json"))
            {
                string json = r.ReadToEnd();

                LayoutsSets = LayoutsConfigJsonConverter.FromJson(json);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                for (int i = 1; i < 139; i++)
                {
                    Thread.Sleep(200);
                    Application.Current.Dispatcher.Invoke(new Action(() => {
                        placementGrid.SelectCassetteByID(i);
                        placementGrid.UnSelectCassetteByID(i - 5);
                    }));
                }
            }); 
        }
    }
}


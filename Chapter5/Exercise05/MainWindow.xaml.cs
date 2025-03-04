using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Exercise05
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush blackBrush = new SolidColorBrush(Colors.Black);

            DrawLogo(paperCanvas, blackBrush, 10, 20);
            DrawLogo(paperCanvas, blackBrush, 100, 100);
            DrawTriangle2(paperCanvas, blackBrush, 100, 10, 40, 40);
            DrawTriangle2(paperCanvas, blackBrush, 10, 100, 20, 60);

        }

        private void DrawTriangle(Canvas drawingArea,
                                  SolidColorBrush brushToUse,
                                  double topX,
                                  double topY,
                                  double width,
                                  double height)
        {
            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX, topY + height);
            DrawLine(drawingArea, brushToUse, topX,
                     topY + height,
                     topX + width, topY + height);
            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX + width, topY + height);
        }

        private void DrawTriangle2(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double topX,
                                   double topY,
                                   double width,
                                   double height)
        {
            // Bereken de coördinaten van de drie hoekpunten
            PointCollection trianglePoints = new PointCollection
    {
        new Point(topX, topY), // Bovenste hoek
        new Point(topX, topY + height), // Linker onderste hoek
        new Point(topX + width, topY + height) // Rechter onderste hoek
    };

            // Maak een Polygon aan
            Polygon triangle = new Polygon
            {
                Points = trianglePoints,
                Stroke = brushToUse,
                Fill = Brushes.Transparent, // Optioneel: aanpassen voor gevulde driehoek
                StrokeThickness = 1
            };
            // Voeg de driehoek toe aan het canvas
            drawingArea.Children.Add(triangle);
        }

        // illustratie optionele parameters
        private void DrawTriangle3(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double topX = 0,
                                   double topY = 0,
                                   double width = 30,
                                   double height = 30)
        {
            double rightCornerX, rightCornerY;
            rightCornerX = topX + width;
            rightCornerY = topY + height;

            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX, rightCornerY);
            DrawLine(drawingArea, brushToUse, topX,
                     rightCornerY, rightCornerX, rightCornerY);
            DrawLine(drawingArea, brushToUse, topX, topY,
                     rightCornerX, rightCornerY);
        }

        private void DrawLine(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double startX, double startY,
                              double endX, double endY)
        {
            Line theLine = new Line();
            theLine.X1 = startX; theLine.X2 = endX;
            theLine.Y1 = startY; theLine.Y2 = endY;
            theLine.Stroke = brushToUse;
            theLine.StrokeThickness = 1;
            drawingArea.Children.Add(theLine);
        }

        private void DrawLogo(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double xPosition,
                              double yPosition)
        {
            DrawRectangle(drawingArea, brushToUse, xPosition, yPosition, 20);
            DrawRectangle(drawingArea, brushToUse, xPosition, yPosition, 40);
            DrawRectangle(drawingArea, brushToUse, xPosition, yPosition, 60);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPosition,
                                   double yPosition,
                                   double size)
        {
            Rectangle theRectangle = new Rectangle();
            theRectangle.Width = size;
            theRectangle.Height = size;
            theRectangle.Margin = new Thickness(xPosition, yPosition, 0, 0);
            theRectangle.Stroke = brushToUse;
            drawingArea.Children.Add(theRectangle);
        }
    }
}

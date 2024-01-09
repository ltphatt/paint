using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using Contract;

namespace Line2D
{
    public class Line2D : IShape
    {
        private Point2D _start = new Point2D();
        private Point2D _end = new Point2D();
        public string Name => "Line";
        public string Icon => "/Images/line.png";
        public IShape Clone()
        {
            return new Line2D();
        }
        public UIElement Draw(SolidColorBrush brush, int thickness)
        {
            Line l = new Line()
            {
                X1 = _start.X,
                Y1 = _start.Y,
                X2 = _end.X,
                Y2 = _end.Y,
                StrokeThickness = thickness,
                Stroke = brush,
            };
            return l;
        }


        public void HandleEnd(double x, double y)
        {
            _end = new Point2D()
            {
                X = x,
                Y = y
            };
        }

        public void HandleStart(double x, double y)
        {
            _start = new Point2D()
            {
                X = x,
                Y = y
            };
        }
    }

}

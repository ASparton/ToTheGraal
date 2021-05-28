using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BaseSim2021
{
    class LinkLine
    {
        public Point Origin { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; } = Color.Black;
        public int Thickness { get; set; } = 3;

        #region Constructors

        public LinkLine(Point origin, Point endPoint)
        {
            Origin = origin;
            EndPoint = endPoint;
        }

        public LinkLine(Point origin, Point endPoint, Color color)
        {
            Origin = origin;
            EndPoint = endPoint;
            Color = color;
        }

        public LinkLine(Point origin, Point endPoint, Color color, int thickness)
        {
            Origin = origin;
            EndPoint = endPoint;
            Color = color;
            Thickness = thickness;
        }

        #endregion

        public void Display(Graphics graphics) => graphics.DrawLine(new Pen(Color, Thickness), Origin, EndPoint);
    }
}

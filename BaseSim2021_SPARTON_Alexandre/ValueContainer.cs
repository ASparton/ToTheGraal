using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BaseSim2021
{
    public class ValueContainer
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public int Thickness { get; set; } = 2;
        private Color BorderColor { get; set; } = Color.Black;
        public Color BackColor { get; set; } = Color.Transparent;
        public string Title { get; set; } = null;

        public ValueContainer(Point location, Size size, Color backColor, string title)
        {
            Location = location;
            Size = size;
            BackColor = backColor;
            Title = title;
        }

        public void Display(Graphics graphics)
        {
            // Draw the rectangle
            Rectangle containerRectangle = new Rectangle(Location, Size);
            Pen containerPen = new Pen(BorderColor, Thickness);
            graphics.DrawRectangle(containerPen, containerRectangle);
            graphics.FillRectangle(new SolidBrush(BackColor), containerRectangle);

            // Draw the title
            if (Title != null)
                graphics.DrawString(Title
                    , new Font("Comic Sans MS", 10)
                    , new SolidBrush(BorderColor)
                    , new Point(containerRectangle.X, containerRectangle.Y));
        }
    }
}

using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BaseSim2021
{
    public class IndexedValueView
    {
        public IndexedValue Value { get; set; }

        public Point Position { get; set; }
        public static Size BoxSize { get; set; } = new Size(175, 75);
        public int Thickness { get; set; } = 2;
        public Color BorderColor { get; set; } = Color.Black;
        public Color BackColor { get; set; } = Color.Transparent;
        public int Opacity { get; set; } = 255;
        public bool Active { get; set; } = true;
        public ValueContainer Container { get; set; }
        public List<KeyValuePair<int, int>> ValueHistory { get; set; } = new List<KeyValuePair<int, int>>();

        public IndexedValueView(IndexedValue indexedValue, ValueContainer container, Point position, 
            Color boxBorderColor, Color backColor)
        {
            Value = indexedValue;
            ValueHistory.Add(new KeyValuePair<int, int>(1, Value.Value));
            Container = container;
            Position = position;
            BorderColor = boxBorderColor;
            BackColor = backColor;
        }

        #region Display managment

        /// <summary>
        /// Method called to display the indexed value inside a frame on the given window.
        /// </summary>
        /// <param name="graphics">The graphics to draw on.</param>
        public void Display(Graphics graphics)
        {
            Color boxColor = Color.FromArgb(Opacity, BorderColor);
            Pen pen = new Pen(boxColor, Thickness);
            if (!Active)
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            if (Value.Type != IndexedValue.ValueType.Policy)
            {
                Rectangle box = new Rectangle(Position, BoxSize);
                graphics.DrawRectangle(pen, box);
                graphics.FillRectangle(new SolidBrush(BackColor), box);
                DisplayValuesInformations(graphics, box);
            }
            else
            {
                Rectangle box = new Rectangle(
                    new Point(Position.X - 10, Position.Y - 10),
                    new Size(BoxSize.Width + 10, BoxSize.Height + 10));

                graphics.DrawEllipse(pen, box);
                graphics.FillEllipse(new SolidBrush(BackColor), box);

                DisplayValuesInformations(graphics,
                    new Rectangle(new Point(Position.X + 5, Position.Y),
                    new Size(BoxSize.Width - 20, BoxSize.Height - 20)));
            }
        }

        /// <summary>
        /// Display the informations about the value inside its rectangle
        /// </summary>
        /// <param name="grpahics">the graphics to draw on</param>
        /// <param name="box">the rectangle</param>
        private void DisplayValuesInformations(Graphics grpahics, Rectangle box)
        {
            StringFormat centeredFromat = new StringFormat();

            // Type and name
            centeredFromat.Alignment = StringAlignment.Center;
            grpahics.DrawString(Value.Name.ToString(), new Font("Comic Sans MS", 10, FontStyle.Bold),
                new SolidBrush(Color.FromArgb(Opacity, Color.Black)), box, centeredFromat);

            // Min current and max values
            centeredFromat.LineAlignment = StringAlignment.Far;

            centeredFromat.Alignment = StringAlignment.Near;
            grpahics.DrawString("Min: " + Value.MinValue.ToString(), new Font("Comic Sans MS", 10),
                new SolidBrush(Color.FromArgb(Opacity, Color.Red)), box, centeredFromat);

            centeredFromat.Alignment = StringAlignment.Far;
            grpahics.DrawString("Max: " + Value.MaxValue.ToString(), new Font("Comic Sans MS", 10),
                new SolidBrush(Color.FromArgb(Opacity, Color.Blue)), box, centeredFromat);

            centeredFromat.LineAlignment = StringAlignment.Center;
            centeredFromat.Alignment = StringAlignment.Center;
            grpahics.DrawString(Value.Value.ToString(), new Font("Comic Sans MS", 10),
                new SolidBrush(Color.FromArgb(Opacity, Color.Black)), box, centeredFromat);
        }

        #endregion Display managment

        #region utils

        public bool Contains(Point point) => new Rectangle(Position, BoxSize).Contains(point);

        public Point GetCenter()
        {
            return new Point(Position.X + (BoxSize.Width / 2), Position.Y + (BoxSize.Height / 2));
        }

        #endregion utils
    }
}
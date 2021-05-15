using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BaseSim2021
{
    class IndexedValueView
    {
        private IndexedValue Value { get; set; }

        public Point Position { get; set; }
        public static Size BoxSize { get; set; } = new Size(175, 75);
        public int Thickness { get; set; } = 2;
        public Color BoxBorderColor { get; set; } = Color.Black;

        public GroupBox Container { get; set; }

        #region Constructors
        public IndexedValueView(IndexedValue indexedValue, GroupBox container, Point position)
        {
            Value = indexedValue;
            Container = container;
            Position = position;
        }

        public IndexedValueView(IndexedValue indexedValue, GroupBox container, Point position, Color boxBorderColor)
        {
            Value = indexedValue;
            Container = container;
            Position = position;
            BoxBorderColor = boxBorderColor;
        }

        public IndexedValueView(IndexedValue indexedValue, GroupBox container, Point position, Color boxBorderColor, int thickness)
        {
            Value = indexedValue;
            Container = container;
            Position = position;
            Thickness = thickness;
            BoxBorderColor = boxBorderColor;
        }
        #endregion

        #region Display managment
        /// <summary>
        /// Method called to display the indexed value inside a frame on the given window.
        /// </summary>
        /// <param name="graphics">The graphics to draw on.</param>
        public void Display(Graphics graphics)
        {
            Rectangle box = new Rectangle(Position, BoxSize);
            graphics.DrawRectangle(new Pen(BoxBorderColor, Thickness), box);

            DisplayValuesInformations(graphics, box);
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
            grpahics.DrawString(Value.Type.ToString(), new Font("Comic Sans MS", 10), new SolidBrush(Color.Black), box, centeredFromat);

            centeredFromat.LineAlignment = StringAlignment.Center;
            grpahics.DrawString(Value.Name.ToString(), new Font("Comic Sans MS", 10, FontStyle.Bold), new SolidBrush(Color.Black), box, centeredFromat);


            // Min current and max values
            centeredFromat.LineAlignment = StringAlignment.Far;
            
            centeredFromat.Alignment = StringAlignment.Near;
            grpahics.DrawString(Value.MinValue.ToString(), new Font("Comic Sans MS", 10), new SolidBrush(Color.Black), box, centeredFromat);

            centeredFromat.Alignment = StringAlignment.Center;
            grpahics.DrawString(Value.Value.ToString(), new Font("Comic Sans MS", 10), new SolidBrush(Color.Black), box, centeredFromat);

            centeredFromat.Alignment = StringAlignment.Far;
            grpahics.DrawString(Value.MaxValue.ToString(), new Font("Comic Sans MS", 10), new SolidBrush(Color.Black), box, centeredFromat);
        }
        #endregion
    }
}

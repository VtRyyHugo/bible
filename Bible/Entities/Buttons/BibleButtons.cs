using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bible.Properties;

namespace Entities.Buttons
{
     public class BibleButtons : Button
    {
        private int XPosition { get; set; }
        private int YPosition { get; set; }
        public int XPositionWidth { get; private set; }
        public  int YPositionHeight { get; private set; }

        public BibleButtons(int xPosition, int yPosition, int width, int height)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            Width = width;
            Height = height;
            Location = new Point(xPosition, yPosition);
            XPositionWidth = Location.X + Width;
            YPositionHeight = Location.Y + Height;
            StyleConfigs();
        }

        private void StyleConfigs()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 74, 93);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 66, 82);
            BackColor = Color.FromArgb(49, 66, 82);
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Impact", 20);
            Image = Resources.triangleUp;
            ImageAlign = ContentAlignment.MiddleRight;
            ForeColor = Color.Black;
            Cursor = Cursors.Hand;
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        }

    }
}

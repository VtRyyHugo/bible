using System;
using System.Drawing;
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
            EventConfigs();
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
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackgroundImage = Resources.darkBlueButton;
        }

        private void EventConfigs()
        {
            MouseEnter += btn_MouseEnter;
            MouseLeave += btn_MouseLeave;
        }

        public void btn_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = Color.White;
        }

        public void btn_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

    }
}

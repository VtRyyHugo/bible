using System.Windows.Forms;

namespace Entities.Display
{
    class DisplayController
    {
        private Screen ScreenDisplay { get; set; }

        public DisplayController()
        {

        }

        public bool HasMoreThanOneScreen()
        {
            return Screen.AllScreens.Length > 1;
        }

        public int GetScreensNumber()
        {
            return Screen.AllScreens.Length;
        }

        public int GetScreenWidth()
        {
            if (HasMoreThanOneScreen())
            {
                return Screen.AllScreens[1].Bounds.Width;
            }

            return Screen.PrimaryScreen.Bounds.Width;
        }

        public int GetScreenHeight()
        {
            if (HasMoreThanOneScreen())
            {
                return Screen.AllScreens[1].Bounds.Height;
            }

            return Screen.PrimaryScreen.Bounds.Height;
        }

        public void PassToScreen(int index, Form form)
        {
            if (HasMoreThanOneScreen())
            {
                form.Location = Screen.AllScreens[index].WorkingArea.Location;
            }
        }
    }
}

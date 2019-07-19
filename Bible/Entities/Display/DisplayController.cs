using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities.Display
{
    class DisplayController
    {
        private Screen DisplayScreen { get; set; }

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

        public void PassToScreen(int index, Form form)
        {
            if (HasMoreThanOneScreen())
            {
                form.Location = Screen.AllScreens[index].WorkingArea.Location;
            }
        }
    }
}

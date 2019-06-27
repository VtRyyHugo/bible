using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bible.Entities.UserControls
{
    public partial class BibleControls : UserControl
    {
        public bool ButtonIcon { get; private set; }
        public Button Button { get; set; }

        public BibleControls()
        {
            Button = new Button();
            ButtonIcon = true;
            InitializeComponent();
        }

        public void ChangeVisibility(bool status, Panel container)
        {
            ButtonIcon = status;

            if (!container.Controls.Contains(this))
            {
                Dock = DockStyle.Fill;
                container.Controls.Add(this);
            }

            if (ButtonIcon)
            {
                Button.Image = Properties.Resources.trianlgeDawn;
                Show();
                ButtonIcon = false;
            }
            else
            {
                Button.Image = Properties.Resources.triangleUp;
                Hide();
                ButtonIcon = true;
            }
        }

        public void SetButtonIcon(bool status)
        {
            ButtonIcon = status;
        }

        public void SetButton(Button btn)
        {
            Button = btn;
        }
    }
}

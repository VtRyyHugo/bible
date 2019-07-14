using System.Windows.Forms;

namespace Bible.Entities.UserControls
{
    public partial class BibleControls : UserControl
    {
        public bool ButtonClickStatus { get; private set; }
        public Button Button { get; set; }

        public BibleControls()
        {
            Button = new Button();
            ButtonClickStatus = true;
            InitializeComponent();
        }

        public void ChangeVisibility(bool status)
        {
            ButtonClickStatus = status;

            if (ButtonClickStatus)
            {
                Button.Image = Properties.Resources.trianlgeDawn;
                Show();
                ButtonClickStatus = false;
            }
            else
            {
                Button.Image = Properties.Resources.triangleUp;
                Hide();
                ButtonClickStatus = true;
            }
        }

        public void ChangeVisibility(bool status, Panel container)
        {
            ButtonClickStatus = status;

            if (!container.Controls.Contains(this) && ButtonClickStatus)
            {
                Dock = DockStyle.Fill;
                container.Controls.Add(this);
            }

            if (ButtonClickStatus)
            {
                Button.Image = Properties.Resources.trianlgeDawn;
                Show();
                ButtonClickStatus = false;
            }
            else
            {
                Button.Image = Properties.Resources.triangleUp;
                Hide();
                ButtonClickStatus = true;
            }
        }

        public void SetButtonClickStatus(bool status)
        {
            ButtonClickStatus = status;
        }

        public void SetButton(Button btn)
        {
            Button = btn;
        }
    }
}

using Bible.Entities.UserControls;
using Entities.Display;
using System;
using System.Windows.Forms;

namespace Bible
{
    public partial class FormFullScreenText : Form
    {
        public UCFullScreenText UcFullScreenTxt { get; set; }
        public int TextVerseNumber;

        public FormFullScreenText(int verse)
        {
            TextVerseNumber = verse;
            UcFullScreenTxt = new UCFullScreenText();
            InitializeComponent();
        }

        public Panel PanelFullScreenTxtContainer
        {
            get { return panelFullScreenTxtContainer; }
            set { panelFullScreenTxtContainer = value; }
        }

        private void WindowConfigs()
        {
            DisplayController controller = new DisplayController();
            StartPosition = FormStartPosition.Manual;
            controller.PassToScreen(1, this);
            WindowState = FormWindowState.Maximized;
        }

        private void FormFullScreenText_Load(object sender, EventArgs e)
        {
            WindowConfigs();
            UcFullScreenTxt.SetForm(this);
            UcFullScreenTxt.Dock = DockStyle.Fill;
            UcFullScreenTxt.CreateVersesReader(TextVerseNumber);
            PanelFullScreenTxtContainer.Controls.Add(UcFullScreenTxt);
        }


    }
}

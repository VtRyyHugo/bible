using Bible.Entities.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

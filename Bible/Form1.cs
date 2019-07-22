using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Bible
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        UCBible ub;
        public  EventHandler PassKeyEvents;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button BibleButton
        {
            get { return btnBiblia; }
            set { btnBiblia = value; }
        }

        public Form1()
        {
            ub = new UCBible();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestaure.Visible = true;
        }

        private void btnRestaure_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaure.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panelSubOptions.Visible = true;
        }

        private void btnAdjusts_Click(object sender, EventArgs e)
        {
            panelSubOptions.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            panelSubOptions.Visible = false;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            panelSubOptions.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCHome uc = new UCHome();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void pictboxHome_Click(object sender, EventArgs e)
        {
            ub.Hide();
            PnlContainer.Controls["UCHome"].Show();
        }

        private void btnBiblia_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCHome"].Hide();
            ub.Show();
            ub.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(ub);
        }
    }
}

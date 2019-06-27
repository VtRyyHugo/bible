using System;
using Entities;
using System.Windows.Forms;

namespace Bible
{
    public partial class UCBibleChapters : UserControl
    {
        private DynamicMenu Menu;
        public Panel PanelContainer
        {
            get { return panelChaptersContainer; }
            set { panelChaptersContainer = value; }
        }
        public UCBibleChapters()
        {
            Menu = new DynamicMenu(5, 5);
            InitializeComponent();
        }

        private void UCBibleChapters_Load(object sender, EventArgs e)
        {
            TableLayoutPanel tablePanel = Menu.GenerateMenu();
            tablePanel.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(tablePanel);
        }
    }
}

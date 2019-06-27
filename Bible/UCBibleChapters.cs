using System;
using Entities;
using System.Windows.Forms;
using Bible.Entities.UserControls;

namespace Bible
{
    public partial class UCBibleChapters : BibleControls
    {
        private DynamicMenu Menu;
        public Panel PanelContainer
        {
            get { return panelChaptersContainer; }
            set { panelChaptersContainer = value; }
        }
        public UCBibleChapters()
        {
            Menu = new DynamicMenu();
            InitializeComponent();
        }

        private void UCBibleChapters_Load(object sender, EventArgs e)
        {
            FlowLayoutPanel flowPanel = Menu.GenerateMenu(4);
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(flowPanel);
        }
    }
}

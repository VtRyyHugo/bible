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

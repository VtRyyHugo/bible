using System;
using Entities;
using System.Windows.Forms;
using Bible.Entities.UserControls;

namespace Bible
{
    public partial class UCBibleChapters : BibleControls
    {
        private DynamicMenu Menu;
        private int NumberChapters {get; set;}
        private Panel BibleContainer { get; set; }

        public Panel PanelContainer
        {
            get { return panelChaptersContainer; }
            set { panelChaptersContainer = value; }
        }
        public UCBibleChapters()
        {
            Menu = new DynamicMenu();
            BibleContainer = new Panel();
            InitializeComponent();
        }

        private void CreateMenu(int numberChapters)
        {
            FlowLayoutPanel flowPanel = Menu.GenerateMenu(numberChapters);
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;

            if (!PanelContainer.Controls.Contains(flowPanel))
            {
                PanelContainer.Controls.Add(flowPanel);
            }
            else
            {
                PanelContainer.Controls.Remove(flowPanel);
                PanelContainer.Controls.Add(flowPanel);
            }
        }

        public void ObjectReceiver(object sender, EventArgs e)
        {
            UCBibleBooks ucbiblebooks = sender as UCBibleBooks;
            NumberChapters = ucbiblebooks.GetNumberFiles;
            CreateMenu(NumberChapters);
            ChangeVisibility(true, BibleContainer);
        }

        public void ContainerReceiver(Panel panel)
        {
            BibleContainer = panel;
        }

        
        
    }
}

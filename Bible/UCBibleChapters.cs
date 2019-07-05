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
        public  delegate void PassVersesQuantity(int quantity);
        public static event PassVersesQuantity PassVerses;

        public Panel PanelContainer
        {
            get { return panelChaptersContainer; }
            set { panelChaptersContainer = value; }
        }

        public UCBibleChapters()
        {
            Menu = new DynamicMenu();
            UCBible.PassUcChaptersMenu += Menu.UcChaptersReceiver;
            BibleContainer = new Panel();
            PassVerses += UCBibleVerses.ReceiveVersesQuantity;
            InitializeComponent();
        }

        private void CreateMenu(int numberChapters)
        {
            FlowLayoutPanel flowPanel = Menu.GenerateMenu(numberChapters, "UCBibleChapters");
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

        public  void btnChapterNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            FileManager.BibleChapterName = FileManager.BibleBookName + btn.Name;
            int versesQuantity = FileManager.CountVerses();
            PassVerses(versesQuantity);
            ChangeVisibility(false);
            UCBible.SvMenu(this, EventArgs.Empty);
            
        }


        
        
    }
}

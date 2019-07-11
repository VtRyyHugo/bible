using System;
using System.Windows.Forms;
using Bible.Entities.UserControls;
using Entities;

namespace Bible
{
    public partial class UCBibleVerses : BibleControls
    {
        private string Path { get; set; }
        private DynamicMenu Menu;
        private static int VersesQuantity { get; set; }
        private FlowLayoutPanel FlowPanel;
        private Panel BibleContainer;
        private UCBibleText UcText;

        public UCBibleVerses()
        {
            Menu = new DynamicMenu();
            UCBible.PassUcVersesMenu += Menu.ObjectsReceiver;
            BibleContainer = new Panel();
            FlowPanel = new FlowLayoutPanel();
            UcText = new UCBibleText();
            InitializeComponent();
        }

        public Panel PanelVersesContainer
        {
            get { return panelVersesContainer; }
            set { panelVersesContainer = value; }
        }

        public static void ReceiveVersesQuantity(int quantity)
        {
            VersesQuantity = quantity;
        }

        private void CreateMenu(int numberVerses)
        {
            FlowPanel = Menu.GenerateMenu(numberVerses, "UCBibleVerses");
            FlowPanel.AutoScroll = true;
            FlowPanel.Dock = DockStyle.Fill;

            if (!PanelVersesContainer.Controls.Contains(FlowPanel))
            {
                PanelVersesContainer.Controls.Add(FlowPanel);
            }
            else
            {
                PanelVersesContainer.Controls.Remove(FlowPanel);
                PanelVersesContainer.Controls.Add(FlowPanel);
            }
        }

        public void ContainerReceiver(Panel panel)
        {
            BibleContainer = panel;
        }

        public void ShowMenu(object sender, EventArgs e)
        {
            CreateMenu(VersesQuantity);
            ChangeVisibility(true, BibleContainer);
        }

        public  void btnVersesNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int verses = Convert.ToInt32(btn.Tag);
            ChangeVisibility(false);
            UcText.CreateTextLabel(verses);
            UcText.Focus();

            if (!BibleContainer.Controls.Contains(UcText))
            {
                BibleContainer.Controls.Add(UcText);
            }
            else
            {
                UcText.Show();
            }
        }
    }
}

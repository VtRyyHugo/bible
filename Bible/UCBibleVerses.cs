using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void UCBibleVerses_Load(object sender, EventArgs e)
        {
            
            
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
            CreateTextLabel(verses);
            BibleContainer.Controls.Add(UcText);
        }

        public void CreateTextLabel(int verse)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;
            label.BackColor = Color.Black;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.White;
            label.Font = new Font("Verdana", 22 , FontStyle.Bold);
            label.Text = FileManager.GetBibleVerse(verse);
            UcText.PanelTextContainer.Controls.Clear();
            UcText.PanelTextContainer.Controls.Add(label);
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Entities;

namespace Bible.Entities.UserControls
{
    public partial class UCBibleText : UserControl
    {
        private Label TextLabel;
        private int Verse;
        private FileManager Manager;
        public  static bool NextText, PreviousText;

        public UCBibleText()
        {
            TextLabel = new Label();
            Manager = new FileManager();
            PreviousText = true;
            NextText = true;
            InitializeComponent();
        }

        public Panel PanelTextContainer
        {
            get { return panelTextContainer; }
            set { panelTextContainer = value; }
        }

        public void CreateTextLabel(int verse)
        {
            Verse = verse;
            TextLabel.AutoSize = false;
            TextLabel.Dock = DockStyle.Fill;
            TextLabel.BackColor = Color.Black;
            TextLabel.TextAlign = ContentAlignment.TopLeft;
            TextLabel.ForeColor = Color.White;
            TextLabel.Font = new Font("Verdana", 22, FontStyle.Bold);
            TextLabel.Text = Manager.GetBibleVerse(verse);
            PanelTextContainer.Controls.Clear();
            PanelTextContainer.Controls.Add(TextLabel);
        }

        private void UCBibleText_Load(object sender, EventArgs e)
        {
            Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Down:

                    break;

                case Keys.Up:

                    break;

                case Keys.Right:
                    if (NextText)
                    {
                        ChangeVerse("next");
                    }
                    
                    break;

                case Keys.Left:
                    if (PreviousText)
                    {
                        ChangeVerse("previous");
                    }
                    
                    break;
            }
            Focus();
            return true;
        }
        private void ChangeVerse(string position)
        {
            if(position == "next")
            {
                Verse++;
                PanelTextContainer.Controls.Clear();
                TextLabel.Text = Manager.GetBibleVerse(Verse);
                PanelTextContainer.Controls.Add(TextLabel);
            }

            if (position == "previous")
            {
                Verse--;
                PanelTextContainer.Controls.Clear();
                TextLabel.Text = Manager.GetBibleVerse(Verse);
                PanelTextContainer.Controls.Add(TextLabel);
            }
        }
    }
}

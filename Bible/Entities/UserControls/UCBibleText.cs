using System.Drawing;
using System.Windows.Forms;
using Entities;

namespace Bible.Entities.UserControls
{
    public partial class UCBibleText : UserControl
    {
        private Label TextLabel;

        public UCBibleText()
        {
            TextLabel = new Label();
            InitializeComponent();
        }

        public Panel PanelTextContainer
        {
            get { return panelTextContainer; }
            set { panelTextContainer = value; }
        }

        public void CreateTextLabel(int verse)
        {
            TextLabel.AutoSize = false;
            TextLabel.Dock = DockStyle.Fill;
            TextLabel.BackColor = Color.Black;
            TextLabel.TextAlign = ContentAlignment.MiddleLeft;
            TextLabel.ForeColor = Color.White;
            TextLabel.Font = new Font("Verdana", 22, FontStyle.Bold);
            TextLabel.Text = FileManager.GetBibleVerse(verse);
            PanelTextContainer.Controls.Clear();
            PanelTextContainer.Controls.Add(TextLabel);
        }
    }
}

using System.Drawing;
using System.Windows.Forms;
using Entities;

namespace Bible.Entities.UserControls
{
    public partial class UCBibleText : UserControl
    {
        public UCBibleText()
        {
            InitializeComponent();
        }

        public Panel PanelTextContainer
        {
            get { return panelTextContainer; }
            set { panelTextContainer = value; }
        }

        public void CreateTextLabel(int verse)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;
            label.BackColor = Color.Black;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.White;
            label.Font = new Font("Verdana", 22, FontStyle.Bold);
            label.Text = FileManager.GetBibleVerse(verse);
            PanelTextContainer.Controls.Clear();
            PanelTextContainer.Controls.Add(label);
        }
    }
}

using System.Drawing;
using System.Windows.Forms;
using Entities;
using Entities.Display;

namespace Bible.Entities.UserControls
{
    public partial class UCFullScreenText : UserControl
    {
        private Label TextLabel { get; set; }
        private TextManager TxtManager { get; set; }
        private Form FormContainer { get; set; }
        private DisplayController DisplayCtrl { get; set; }

        public UCFullScreenText()
        {
            TextLabel = new Label();
            DisplayCtrl = new DisplayController();
            InitializeComponent();
        }

        public Panel PanelTextContainer
        {
            get { return panelTextContainer; }
            set { panelTextContainer = value; }
        }

        public Panel PanelPathMapperContainer
        {
            get { return panelPathMapperContainer; }
            set { panelPathMapperContainer = value; }
        }

        public Label LabelPathMapper
        {
            get { return labelPathMapper; }
            set { labelPathMapper = value; }
        }

        public Panel PanelTxtVersesContainer
        {
            get { return panelTextVersesContainer; }
            set { panelTextVersesContainer = value; }
        }

        public void CreateVersesReader(int verse)
        {
            TxtManager = new TextManager(this, PanelTxtVersesContainer, TextLabel,
                PanelPathMapperContainer, LabelPathMapper, verse);
            TxtManager.InitializeConfigs();
            EditStyles();
        }

        private void EditStyles()
        {
            int screenWidth = DisplayCtrl.GetScreenWidth();
            LabelPathMapper.Font = new Font("Arial", 50, FontStyle.Bold | FontStyle.Underline);
            LabelPathMapper.Location = new Point(screenWidth / 2 - LabelPathMapper.Width / 2,
                PanelPathMapperContainer.Height / 2 - LabelPathMapper.Height / 2 + 12);
            TextLabel.Font = new Font("Arial", 40, FontStyle.Bold);
        }

        public void SetForm(Form form)
        {
            FormContainer = form;
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
                    if (TextManager.NextText)
                    {
                        TxtManager.UpdateTextVerse("next");
                        TxtManager.UpdatePathMapper();
                    }

                    break;

                case Keys.Left:
                    if (TextManager.PreviousText)
                    {
                        TxtManager.UpdateTextVerse("previous");
                        TxtManager.UpdatePathMapper();
                    }

                    break;

                case Keys.Escape:
                    FormContainer.Close();

                    break;
            }
            Focus();
            return true;
        }
    }
}

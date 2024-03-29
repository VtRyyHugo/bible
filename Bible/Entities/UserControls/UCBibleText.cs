﻿using System.Linq;
using System.Windows.Forms;
using Entities;

namespace Bible.Entities.UserControls
{
    public partial class UCBibleText : UserControl
    {
        private Label TextLabel;
        private TextManager TxtManager { get; set; }
        private FormFullScreenText FullScreenTxt { get; set; }
       

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
            }
            Focus();
            return true;
        }

        private void expandScreenIcon_Click(object sender, System.EventArgs e)
        {
            if (Application.OpenForms.OfType<FormFullScreenText>().Count() > 0)
            {
                FullScreenTxt.Close();
            }

            int verseNumber = TxtManager.GetVerseNumber();
            FullScreenTxt = new FormFullScreenText(verseNumber);
            FullScreenTxt.Show();
        }
    }
}

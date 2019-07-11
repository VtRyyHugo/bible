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
        private int VerseNumber;
       

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
            Verse = verse;
            PathMapperConfigs();
            TextLabelConfigs(verse);
            
        }

        private void TextLabelConfigs(int verse)
        {
            TextLabel.AutoSize = false;
            TextLabel.Dock = DockStyle.Fill;
            TextLabel.BackColor = Color.Black;
            TextLabel.TextAlign = ContentAlignment.TopLeft;
            TextLabel.ForeColor = Color.White;
            TextLabel.Font = new Font("Verdana", 22, FontStyle.Bold);
            TextLabel.Text = Manager.GetBibleVerse(verse);
            PanelTxtVersesContainer.Controls.Clear();
            PanelTxtVersesContainer.Controls.Add(TextLabel);
        }

        private void PathMapperConfigs()
        {
            LabelPathMapper.Controls.Clear();
            string bibleBook = FileManager.BibleBookNameUTF8;
            string bibleChapter = FileManager.BibleChapterNumber;
            VerseNumber = FileManager.BibleVerseNumber;
            LabelPathMapper.Text = $"{bibleBook} {bibleChapter} : {VerseNumber}";
        }

        private void PathMapperConfigs(string position)
        {
            string bibleBook = FileManager.BibleBookNameUTF8;
            string bibleChapter = FileManager.BibleChapterNumber;
            
            if (position == "next")
            {
                VerseNumber++;
            }

            if (position == "previous")
            {
                VerseNumber--;
            }

            LabelPathMapper.Text = $"{bibleBook} {bibleChapter} : {VerseNumber}";
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
                        PathMapperConfigs("next");
                    }
                    
                    break;

                case Keys.Left:
                    if (PreviousText)
                    {
                        ChangeVerse("previous");
                        PathMapperConfigs("previous");
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
                PanelTxtVersesContainer.Controls.Clear();
                TextLabel.Text = Manager.GetBibleVerse(Verse);
                PanelTxtVersesContainer.Controls.Add(TextLabel);
            }

            if (position == "previous")
            {
                Verse--;
                PanelTxtVersesContainer.Controls.Clear();
                TextLabel.Text = Manager.GetBibleVerse(Verse);
                PanelTxtVersesContainer.Controls.Add(TextLabel);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    class TextManager
    {
        private UserControl Control { get; set; }
        private Panel TextVersesContainer { get; set; }
        private Label TextLabel { get; set; }
        private Panel PathMapperContainer { get; set; }
        private Label LabelPathMapper { get; set; }
        private FileManager Manager { get; set; }
        private int PathMapperVerseNumber { get; set; }
        private int VerseNumber { get; set; }
        public static bool NextText, PreviousText;

        public TextManager(UserControl control, Panel textContainer, Label textLabel, 
            Panel pathMapperContainer, Label labelPathMapper, int verseNumber)
        {
            Control = control;
            TextVersesContainer = textContainer;
            TextLabel = textLabel;
            PathMapperContainer = pathMapperContainer;
            LabelPathMapper = labelPathMapper;
            VerseNumber = verseNumber;
            Manager = new FileManager();
            NextText = true;
            PreviousText = true;
            Control.Load += control_Load;
        }

        public void InitializeConfigs()
        {
            PathMapperConfigs();
            TextLabelConfigs();
        }

        private void TextLabelConfigs()
        {
            TextLabel.AutoSize = false;
            TextLabel.Dock = DockStyle.Fill;
            TextLabel.BackColor = Color.Black;
            TextLabel.TextAlign = ContentAlignment.TopLeft;
            TextLabel.ForeColor = Color.White;
            TextLabel.Font = new Font("Verdana", 22, FontStyle.Bold);
            TextLabel.Text = Manager.GetBibleVerse(VerseNumber);
            TextVersesContainer.Controls.Clear();
            TextVersesContainer.Controls.Add(TextLabel);
        }

        private void PathMapperConfigs()
        {
            LabelPathMapper.Controls.Clear();
            string bibleBook = FileManager.BibleBookNameUTF8;
            string bibleChapter = FileManager.BibleChapterNumber;
            PathMapperVerseNumber = FileManager.BibleVerseNumber;
            LabelPathMapper.Text = $"{bibleBook} {bibleChapter} : {PathMapperVerseNumber}";
        }

        public void UpdatePathMapper(string position)
        {
            string bibleBook = FileManager.BibleBookNameUTF8;
            string bibleChapter = FileManager.BibleChapterNumber;

            if (position == "next")
            {
                PathMapperVerseNumber++;
            }

            if (position == "previous")
            {
                PathMapperVerseNumber--;
            }

            LabelPathMapper.Text = $"{bibleBook} {bibleChapter} : {PathMapperVerseNumber}";
        }

        public void UpdateTextVerse(string position)
        {
            if (position == "next")
            {
                VerseNumber++;
                TextVersesContainer.Controls.Clear();
                TextLabel.Text = Manager.GetBibleVerse(VerseNumber);
                TextVersesContainer.Controls.Add(TextLabel);
            }

            if (position == "previous")
            {
                VerseNumber--;
                TextVersesContainer.Controls.Clear();
                TextLabel.Text = Manager.GetBibleVerse(VerseNumber);
                TextVersesContainer.Controls.Add(TextLabel);
            }
        }

        private void control_Load(object sender, EventArgs e)
        {
            Control.Focus();
        }
    }
}
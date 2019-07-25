using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bible;

namespace Entities
{
    class DynamicMenu 
    {
        public FlowLayoutPanel FlowPanel { get; private set; }
        private  UCBibleVerses BibleVerses;
        private UCBibleChapters BibleChapters;

        public DynamicMenu()
        {
            FlowPanel = new FlowLayoutPanel();  
        }

        public FlowLayoutPanel GenerateMenu(int n, string typeTag)
        {
            FlowPanel.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                FlowPanel.Controls.Add(Btn(i, typeTag));
            }

            return FlowPanel;
        }

        public Button Btn(int i, string typeTag)
        {
            Button button = new Button();
            button.Text = (i + 1).ToString();
            button.Font = new Font(button.Font, FontStyle.Bold);
            button.Name = (i + 1).ToString();
            button.Tag = i;
            button.Width = 56;
            button.Height = 50;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 165, 228);
            button.BackColor = Color.White;
            SetClickEvent(button, typeTag);

            return button;
        }

        public void GenerateResultsMenu(List<Button> buttonList, 
               FlowLayoutPanel resultsMenu, UCBibleBooks booksControl)
        {
            Button button;
            resultsMenu.Controls.Clear();
            foreach (Button btn in buttonList)
            {
                button = new Button();
                button.Width = btn.Width;
                button.Height = btn.Height;
                button.Font = new Font(btn.Font, FontStyle.Bold);
                button.Name = btn.Name;
                button.Text = btn.Text;
                button.Tag = btn.Tag;
                button.TextAlign = btn.TextAlign;
                button.ForeColor = btn.ForeColor;
                button.BackColor = btn.BackColor;
                button.FlatStyle = btn.FlatStyle;
                button.FlatAppearance.BorderColor = btn.FlatAppearance.BorderColor;
                button.FlatAppearance.BorderSize = btn.FlatAppearance.BorderSize;
                button.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.MouseDownBackColor;
                button.FlatAppearance.MouseOverBackColor = btn.FlatAppearance.MouseOverBackColor;
                button.Click += booksControl.booksButton_Click;
                resultsMenu.Controls.Add(button);
            }

            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            FileManager.BibleChapterName = FileManager.BibleBookName + btn.Name;
        }

        private void SetClickEvent(Button btn, string typeTag)
        {
            switch (typeTag)
            {
                case "UCBibleChapters":
                    btn.Click += BibleChapters.btnChapterNumber_Click;
                    break;

                case "UCBibleVerses":
                    btn.Click += BibleVerses.btnVersesNumber_Click;
                    break;

                default:
                    btn.Click += btn_Click;
                    break;
            }
        }

        public  void ObjectsReceiver(object sender, EventArgs e)
        {
            BibleVerses = sender as UCBibleVerses;

        }

        public void UcChaptersReceiver(object sender, EventArgs e)
        {
            BibleChapters = sender as UCBibleChapters;

        }



    }
}

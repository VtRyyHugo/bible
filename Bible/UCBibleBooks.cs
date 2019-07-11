using System;
using System.Windows.Forms;
using Bible.Entities.Exceptions;
using Bible.Entities.UserControls;
using Entities;

namespace Bible
{
    public partial class UCBibleBooks : BibleControls
    {
        private int NumberFiles { get;  set; }

        public UCBibleBooks()
        {
            InitializeComponent();
        }

        public int GetNumberFiles
        {
            get { return NumberFiles; }
            set { NumberFiles = value; }
        }


        private void booksButton_Click(object sender, EventArgs e )
        {
            Button btn = sender as Button;
            string tag = btn.Tag.ToString();
            FileManager.BibleBookName = tag;
            FileManager.BibleChapterName = tag.ToLower();
            FileManager.BibleBookNameUTF8 = btn.Text;
            try
            {
                NumberFiles = FileManager.FilesCounter(tag);
            }
            catch (DomainException error)
            {
                MessageBox.Show(error.Message);
            }

            UCBible.PassObject(this, EventArgs.Empty);
            ChangeVisibility(false); 
        }
    }
}

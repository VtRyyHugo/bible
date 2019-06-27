using System;
using System.Windows.Forms;
using Bible.Entities.Exceptions;
using Entities;

namespace Bible
{
    public partial class UCBibleBooks : UserControl
    {
        public UCBibleBooks()
        {
            InitializeComponent();
        }

        private void booksButton_Click(object sender, EventArgs e )
        {
            string tag = ((Button)sender).Tag.ToString();
            try
            {
                int numberFiles = FileManager.FilesCounter(tag);
                //MessageBox.Show(numberFiles.ToString());
            }
            catch (DomainException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }
    }
}

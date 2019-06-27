using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bible
{
    public partial class UCBible : UserControl
    {
        private UCBibleBooks UcBooks;
        private UCBibleChapters UcChapters;

        public Panel PanelContainer
        {
            get { return panelBibleContainer; }
            set { panelBibleContainer = value; }
        }

        public UCBible()
        {
            UcBooks = new UCBibleBooks();
            UcChapters = new UCBibleChapters();
            InitializeComponent();
        }

        private void UCBible_Load(object sender, EventArgs e)
        {
            UcBooks.SetButton(btnBooks);
            UcChapters.SetButton(btnChapters);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (UcBooks.ButtonIcon)
            {
                UcBooks.ChangeVisibility(true, PanelContainer);
                UcChapters.ChangeVisibility(false, PanelContainer);
            }
            else
            {
                UcBooks.ChangeVisibility(false, PanelContainer);
            }
        }

        private void btnChapters_Click(object sender, EventArgs e)
        {
            if (UcChapters.ButtonIcon)
            {
                UcChapters.ChangeVisibility(true, PanelContainer);
                UcBooks.ChangeVisibility(false, PanelContainer);
            }
            else
            {
                UcChapters.ChangeVisibility(false, PanelContainer);
            }
        }

        private void btnVerses_Click(object sender, EventArgs e)
        {

        }       
        
    }
}

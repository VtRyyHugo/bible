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
        private bool btnBooksIcon = true;
        private bool btnChaptersIcon = true;
        private bool btnVersesIcon = true;

        public UCBible()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (btnBooksIcon)
            {
                btnBooks.Image = Properties.Resources.trianlgeDawn;
                btnBooksIcon = false;
                btnChapters.Image = Properties.Resources.triangleUp;
                btnChaptersIcon = true;
                btnVerses.Image = Properties.Resources.triangleUp;
                btnVersesIcon = true;
            }
            else
            {
                btnBooks.Image = Properties.Resources.triangleUp;
                btnBooksIcon = true;
            }       
        }

        private void btnChapters_Click(object sender, EventArgs e)
        {
            if (btnChaptersIcon)
            {
                btnChapters.Image = Properties.Resources.trianlgeDawn;
                btnChaptersIcon = false;
                btnBooks.Image = Properties.Resources.triangleUp;
                btnBooksIcon = true;
                btnVerses.Image = Properties.Resources.triangleUp;
                btnVersesIcon = true;
            }
            else
            {
                btnChapters.Image = Properties.Resources.triangleUp;
                btnChaptersIcon = true;
            }
        }

        private void btnVerses_Click(object sender, EventArgs e)
        {
            if (btnVersesIcon)
            {
                btnVerses.Image = Properties.Resources.trianlgeDawn;
                btnVersesIcon = false;
                btnBooks.Image = Properties.Resources.triangleUp;
                btnBooksIcon = true;
                btnChapters.Image = Properties.Resources.triangleUp;
                btnChaptersIcon = true;
            }
            else
            {
                btnVerses.Image = Properties.Resources.triangleUp;
                btnVersesIcon = true;
            }
        }
    }
}

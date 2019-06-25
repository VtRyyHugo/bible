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
    public partial class UCBibleBooks : UserControl
    {
        public UCBibleBooks()
        {
            InitializeComponent();
        }

        private void booksButton_Click(object sender, EventArgs e )
        {
            string tag = ((Button)sender).Tag.ToString();
        }
    }
}

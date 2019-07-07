using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bible.Entities.UserControls
{
    public partial class UCBibleText : UserControl
    {
        public UCBibleText()
        {
            InitializeComponent();
        }

        public Panel PanelTextContainer
        {
            get { return panelTextContainer; }
            set { panelTextContainer = value; }
        }
    }
}

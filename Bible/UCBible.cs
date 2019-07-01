using System;
using System.Windows.Forms;

namespace Bible
{
    public partial class UCBible : UserControl
    {
        private UCBibleBooks UcBooks;
        private UCBibleChapters UcChapters;
        public static EventHandler PassObject;
        public delegate void PassContainer(Panel panel);
        public static PassContainer PassPanelContainer;

        public Panel PanelContainer
        {
            get { return panelBibleContainer; }
            set { panelBibleContainer = value; }
        }

        public UCBible()
        {
            UcBooks = new UCBibleBooks();
            UcChapters = new UCBibleChapters();
            PassObject += UcChapters.ObjectReceiver;
            PassPanelContainer += UcChapters.ContainerReceiver;
            InitializeComponent();
        }

        private void UCBible_Load(object sender, EventArgs e)
        {
            UcBooks.SetButton(btnBooks);
            UcChapters.SetButton(btnChapters);
            PassPanelContainer(PanelContainer);
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

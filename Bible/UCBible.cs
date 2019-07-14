using System;
using System.Windows.Forms;
using Entities;
using Bible.Entities.Exceptions;

namespace Bible
{
    public partial class UCBible : UserControl
    {
        private UCBibleBooks UcBooks;
        private UCBibleChapters UcChapters;
        private UCBibleVerses UcVerses;
        public static EventHandler PassObject;
        public delegate void PassContainer(Panel panel);
        public static EventHandler PassUcVersesMenu;
        public static EventHandler PassUcChaptersMenu;
        public static PassContainer PassPanelContainer;
        public static EventHandler SvMenu;

        public Panel PanelContainer
        {
            get { return panelBibleContainer; }
            set { panelBibleContainer = value; }
        }

        public UCBible()
        {
            UcBooks = new UCBibleBooks();
            UcChapters = new UCBibleChapters();
            UcVerses = new UCBibleVerses();
            PassObject += UcChapters.ObjectReceiver;
            PassPanelContainer += UcChapters.ContainerReceiver;
            PassPanelContainer += UcVerses.ContainerReceiver;
            PassUcVersesMenu(UcVerses, EventArgs.Empty);
            PassUcChaptersMenu(UcChapters, EventArgs.Empty);
            SvMenu += UcVerses.ShowMenu;
      
            InitializeComponent();
        }

        private void UCBible_Load(object sender, EventArgs e)
        {
            UcBooks.SetButton(btnBooks);
            UcChapters.SetButton(btnChapters);
            UcVerses.SetButton(btnVerses);
            PassPanelContainer(PanelContainer);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (UcBooks.ButtonClickStatus)
            {
                UcBooks.ChangeVisibility(true, PanelContainer);
                UcChapters.ChangeVisibility(false, PanelContainer);
                UcVerses.ChangeVisibility(false, PanelContainer);
            }
            else
            {
                UcBooks.ChangeVisibility(false, PanelContainer);
            }
        }

        private void btnChapters_Click(object sender, EventArgs e)
        {
            if (UcChapters.ButtonClickStatus)
            {
                UcChapters.ChangeVisibility(true, PanelContainer);
                UcBooks.ChangeVisibility(false, PanelContainer);
                UcVerses.ChangeVisibility(false, PanelContainer);
            }
            else
            {
                UcChapters.ChangeVisibility(false, PanelContainer);
            }
        }

        private void btnVerses_Click(object sender, EventArgs e)
        {
            if (UcVerses.ButtonClickStatus)
            {
                UcVerses.ChangeVisibility(true, PanelContainer);
                UcBooks.ChangeVisibility(false, PanelContainer);
                UcChapters.ChangeVisibility(false, PanelContainer);
            }
            else
            {
                UcVerses.ChangeVisibility(false, PanelContainer);
            }
        }       
        
    }
}

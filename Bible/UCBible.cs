using System;
using System.Windows.Forms;
using System.Drawing;
using Entities.Buttons;

namespace Bible
{
    public partial class UCBible : UserControl
    {
        private UCBibleBooks UcBooks;
        private UCBibleChapters UcChapters;
        private UCBibleVerses UcVerses;
        private BibleButtons BooksButton;
        private BibleButtons ChaptersButton;
        private BibleButtons VersesButton;
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
        public Panel PanelMenuContainer
        {
            get { return panelBibleMenu; }
            set { panelBibleMenu = value; }
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
            CreateButtons();
            UcBooks.SetButton(BooksButton);
            UcChapters.SetButton(ChaptersButton);
            UcVerses.SetButton(VersesButton);
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

        private void CreateButtons()
        {
            const int separator = 45;
            int x = 138, y = 42;
            int posX = 140, posY = PanelMenuContainer.Height - (y + 10);
            int xPositionWidth = 0;
            // 60
            BooksButton = new BibleButtons(posX, posY, x, y);
            BooksButton.Text = "Livros";
            BooksButton.Click += btnBooks_Click;
            xPositionWidth = BooksButton.XPositionWidth + separator;

            ChaptersButton = new BibleButtons(xPositionWidth, posY, x, y);
            ChaptersButton.Text = "Capítulos";
            ChaptersButton.Font = new Font("Impact", 18);
            ChaptersButton.Click += btnChapters_Click;
            xPositionWidth = ChaptersButton.XPositionWidth + separator;

            VersesButton = new BibleButtons(xPositionWidth , posY, x, y);
            VersesButton.Text = "Versículos";
            VersesButton.Font = new Font("Impact", 18);
            VersesButton.Click += btnVerses_Click;

            PanelMenuContainer.Controls.Add(BooksButton);
            PanelMenuContainer.Controls.Add(ChaptersButton);
            PanelMenuContainer.Controls.Add(VersesButton);
        }

    }
}

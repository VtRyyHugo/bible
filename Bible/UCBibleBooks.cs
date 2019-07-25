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
        private SearchMenu Search { get; set; }
        private FlowLayoutPanel ResultsMenu { get; set; }

        public UCBibleBooks()
        {
            InitializeComponent();
            Search = new SearchMenu(TextBoxSearch, FlowBooksContainer);
            ResultsMenu = new FlowLayoutPanel();
            ResultsMenuConfigs();
        }

        public int GetNumberFiles
        {
            get { return NumberFiles; }
            set { NumberFiles = value; }
        }

        public Panel PanelBooksContainer
        {
            get { return panelBooksContainer; }
            set { panelBooksContainer = value; }
        }

        public FlowLayoutPanel FlowBooksContainer
        {
            get { return flowBooksPanel; }
            set { flowBooksPanel = value; }
        }

        public TextBox TextBoxSearch
        {
            get { return textBoxSearch; }
            set { textBoxSearch = value; }
        }

        public FlowLayoutPanel SearchMenuResultsContainer
        {
            get{ return ResultsMenu; }
            set { ResultsMenu = value; }
        }

        private void ResultsMenuConfigs()
        {
            ResultsMenu.Dock = DockStyle.Fill;
            ResultsMenu.AutoScroll = true;
            ResultsMenu.Hide();
            PanelBooksContainer.Controls.Add(ResultsMenu);
        }

        private void ChangeSearchMenuVisibility(bool status)
        {
            if (status)
            {
                FlowBooksContainer.Hide();
                ResultsMenu.Show();
            }
            else
            {
                FlowBooksContainer.Show();
                ResultsMenu.Hide();
            }
        }

        public void booksButton_Click(object sender, EventArgs e )
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            Search.SearchButton(SearchMenuResultsContainer, this);
            ChangeSearchMenuVisibility(true);

            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                ChangeSearchMenuVisibility(false);
            }
        }
    }
}

using Bible;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Entities
{
    class SearchMenu
    {
        private TextBox TxtBox { get; set; }
        private FlowLayoutPanel FlowMenu { get; set; }
        private AutoCompleteStringCollection SourceString { get; set; }
        private List<Button> ResultsButton { get; set; }
        private List<string> ButtonNameList { get; set; }
        private DynamicMenu Menu { get; set; }

        public SearchMenu(TextBox txtBox, FlowLayoutPanel flowMenu)
        {
            TxtBox = txtBox;
            FlowMenu = flowMenu;
            SourceString = new AutoCompleteStringCollection();
            ResultsButton = new List<Button>();
            ButtonNameList = new List<string>();
            Menu = new DynamicMenu();
            SourceStringConfigs();
            TextBoxConfigs();
        }

        private void TextBoxConfigs()
        {
            TxtBox.AutoCompleteCustomSource = SourceString;
            TxtBox.AutoCompleteMode = AutoCompleteMode.None;
            TxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void SourceStringConfigs()
        {
            
            foreach (Button btn in FlowMenu.Controls)
            {
                SourceString.Add(btn.Text);
            }
            
        }

        private void OnTextChanged(FlowLayoutPanel resultsMenu, UCBibleBooks booksControl)
        {
            int repeater = 0;
            ResultsButton.Clear();
            ButtonNameList.Clear();
            foreach (Button btn in FlowMenu.Controls)
            {
                foreach (string str in TxtBox.AutoCompleteCustomSource)
                {
                    if (str.Contains(TxtBox.Text))
                    {
                        if (str.Contains(btn.Text))
                        {
                            foreach (Button btnResult in ResultsButton)
                            {
                                if (btnResult.Text == btn.Text)
                                {
                                    repeater++;
                                }
                            }
                            if (repeater == 0)
                            {
                                ResultsButton.Add(btn);
                            }
                        }
                    }
                }
            }
            Menu.GenerateResultsMenu(ResultsButton, resultsMenu, booksControl);
        }


        


        public void SearchButton(FlowLayoutPanel resultsMenu, UCBibleBooks booksControl)
        {
            OnTextChanged(resultsMenu, booksControl);
        }
    }
}

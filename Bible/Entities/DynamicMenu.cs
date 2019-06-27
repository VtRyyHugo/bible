using System;
using System.Drawing;
using System.Windows.Forms;

namespace Entities
{
    class DynamicMenu 
    {
        public int RowCount { get; private set; }
        public int ColumnCount { get; private set; }
        public TableLayoutPanel TablePanel { get; private set; }

        public DynamicMenu(int rowCount, int columnCount)
        {
            TablePanel = new TableLayoutPanel();
            RowCount = rowCount;
            ColumnCount = columnCount;
        }

        public TableLayoutPanel GenerateMenu()
        {
            TablePanel.RowCount = RowCount;
            TablePanel.ColumnCount = ColumnCount;
            TablePanel.RowStyles.Clear();
            TablePanel.ColumnStyles.Clear();

            for (int i = 0; i < ColumnCount; i++)
            {
                TablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / ColumnCount));
            }
            for (int i = 0; i < RowCount; i++)
            {
                TablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / RowCount));
            }
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    Button button = new Button();
                    button.Text = string.Format("{0}{1}", i, j);
                    button.Font = new Font(button.Font, FontStyle.Bold);
                    button.Name = string.Format("{0}{1}", i, j);
                    button.Width = 80;
                    button.Height = 80;
                    button.Dock = DockStyle.Fill;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 165, 228);
                    button.BackColor = Color.White;
                    TablePanel.Controls.Add(button, j, i);
                }
            }

            return TablePanel;
        }

    }
}

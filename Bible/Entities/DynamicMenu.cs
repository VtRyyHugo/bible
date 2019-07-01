using System;
using System.Drawing;
using System.Windows.Forms;

namespace Entities
{
    class DynamicMenu 
    {
        public FlowLayoutPanel FlowPanel { get; private set; }

        public DynamicMenu()
        {
            FlowPanel = new FlowLayoutPanel();  
        }

        public FlowLayoutPanel GenerateMenu(int n)
        {
            FlowPanel.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                FlowPanel.Controls.Add(Btn(i));
            }

            return FlowPanel;
        }

        private Button Btn(int i)
        {
            Button button = new Button();
            button.Text = (i + 1).ToString();
            button.Font = new Font(button.Font, FontStyle.Bold);
            button.Name = (i + 1).ToString();
            button.Tag = i;
            button.Width = 56;
            button.Height = 50;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 165, 228);
            button.BackColor = Color.White;
            button.Click += btn_Click;

            return button;
        }

        public void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Index button tag: {((Button)sender).Tag.ToString()}");
        }

    }
}

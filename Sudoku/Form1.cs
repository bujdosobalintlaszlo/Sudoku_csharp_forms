using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create and configure the FlowLayoutPanel
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Center the FlowLayoutPanel within the form
            flowLayoutPanel.Anchor = AnchorStyles.None;

            // Create the label


            // Create the buttons
            Button bkonnyu = MenuGombGen("btnkonnyu", "Könnyű", 50, 150, Color.AliceBlue, Color.Black);
            flowLayoutPanel.Controls.Add(bkonnyu);
            Button bkozep = MenuGombGen("btnkozep", "Közepes", 50, 150, Color.AliceBlue, Color.Black);
            flowLayoutPanel.Controls.Add(bkozep);
            Button bnehez = MenuGombGen("btnnehez", "Nehéz", 50, 150, Color.AliceBlue, Color.Black);
            flowLayoutPanel.Controls.Add(bnehez);

            // Add the FlowLayoutPanel to the form
            this.Controls.Add(flowLayoutPanel);

            // Center the FlowLayoutPanel within the form
            flowLayoutPanel.Location = new Point(
                (this.ClientSize.Width - flowLayoutPanel.Width) / 2,
                (this.ClientSize.Height - flowLayoutPanel.Height) / 2
            );
            flowLayoutPanel.Anchor = AnchorStyles.None;
        }

        Button MenuGombGen(string nev, string text, int height, int width, Color background, Color textColor)
        {
            Button b = new Button();
            b.Name = nev;
            b.Text = text;
            b.Height = height;
            b.Width = width;
            b.BackColor = background;
            b.ForeColor = textColor;
            return b;
        }
    }

}

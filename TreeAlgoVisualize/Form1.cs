using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeAlgoVisualize
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            g = this.CreateGraphics();
            InitializeComponent();
        }
        private void Run_Tick(object sender, EventArgs e)
        {

        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            int val = int.Parse(Insert.Text);
            TreeNode node = new TreeNode(val);
            this.Controls.Add(CreateLabel.Create(node));
        }
    }
}

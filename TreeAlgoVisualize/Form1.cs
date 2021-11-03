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
        private static TreeNode head;
        Database Algo=new Database();
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
            //Add Algorithms here
            TreeNode Node = new TreeNode(val);
            Algo.Insert(ref head, Node,this.Controls);
            this.Controls.Add(Node.getLabel());
            Insert.Text = "";
            Insert.Focus();
        }

        private void Travelsal_Click(object sender, EventArgs e)
        {
            Algo.Travelsal(head, this.Controls);
        }

       

        private void RankButton_Click(object sender, EventArgs e)
        {
            Algo.DeleteLabel(this.Controls);
            int val = int.Parse(Rank.Text);
            Algo.Rank(head, val, this.Controls);
        }
        private void CeilingButton_Click(object sender, EventArgs e)
        {
            Algo.DeleteLabel(this.Controls);
            int val = int.Parse(Ceiling.Text);
            Algo.Ceiling(head, val, this.Controls);
        }

        private void FindMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value is: "+Algo.MaxValue(head, this.Controls).ToString());
        }

        private void FindMin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Min value is: " + Algo.MinValue(head, this.Controls).ToString());
        }
    }
}

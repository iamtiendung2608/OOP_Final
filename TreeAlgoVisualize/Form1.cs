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
        private static TreeNode Pos;
        private static Point dis;
        Database Algo =new Database();
        Graphics g;
        public Form1()
        {
            g = this.CreateGraphics();
            InitializeComponent();
        }
        
        private void InsertButton_Click(object sender, EventArgs e)
        {
            int val = int.Parse(Insert.Text);
            //Add Algorithms here
            TreeNode Node = new TreeNode(val);
            Pos = new TreeNode(val);
            this.Controls.Add(Pos.getLabel());
            Task.Delay(500).Wait();
            Algo.Insert(ref head, Node,this.Controls);
            dis = TreeTransition.get_distance(Pos.getLabel().Location, Node.getLabel().Location);
            TreeTransition.change_position(Pos, dis);
            this.Controls.Remove(Pos.getLabel());
            this.Controls.Add(Node.getLabel());
            Insert.Text = "";
            Insert.Focus();
        }

        private void Travelsal_Click(object sender, EventArgs e)
        {
            Algo.DeleteLabel(this.Controls);
            Algo.Travelsal(head, this.Controls);
        }
        private void RankButton_Click(object sender, EventArgs e)
        {
            Algo.DeleteLabel(this.Controls);
            int val = int.Parse(Rank.Text);
            Algo.Rank(head, val, this.Controls);
            if (Database.Label.Count == 0)
                Database.NoticeSmall(val);
            Rank.Text = "";
            Rank.Focus();
        }
        private void CeilingButton_Click(object sender, EventArgs e)
        {
            Algo.DeleteLabel(this.Controls);
            int val = int.Parse(Ceiling.Text);
            Algo.Ceiling(head, val, this.Controls);
            if (Database.Label.Count == 0)
                Database.NoticeLarge(val);
            Ceiling.Text = "";
            Ceiling.Focus();
        }

        private void FindMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value is: "+Algo.MaxValue(head, this.Controls).ToString());
        }

        private void FindMin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Min value is: " + Algo.MinValue(head, this.Controls).ToString());
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Add later on
        private void DeleteButton_Click(object sender, EventArgs e)
        {
        }
    }
}

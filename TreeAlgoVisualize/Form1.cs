using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public static Graphics g;
        Database Algo =new Database();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void InsertButton_Click(object sender, EventArgs e)
        {
            int val = int.Parse(Insert.Text);
            TreeNode Node = new TreeNode(val);
            Pos = new TreeNode(val);
            this.Controls.Add(Pos.getLabel());
            Task.Delay(500).Wait();
            Algo.Insert(ref head, Node);
            dis = TreeTransition.get_distance(Pos.getLabel().Location, Node.getLabel().Location);
            TreeTransition.change_position(Pos, dis);
            Label Start =Database.getDrawPoint().getLabel();
            Label End = Node.getLabel();
            DrawComponent.Draw(Start, End);
            TreeTransition.ReDraw();
            this.Controls.Remove(Pos.getLabel());
            this.Controls.Add(Node.getLabel());
            Insert.Text = "";
            Insert.Focus();
        }
        private void Travelsal_Click(object sender, EventArgs e)
        {
            Algo.DeleteLabel();
            Algo.Travelsal(head);
        }
        private void RankButton_Click(object sender, EventArgs e)
        {
            Algo.DeleteLabel();
            int val = int.Parse(Rank.Text);
            Algo.Rank(head, val);
            if (Database.Label.Count == 0)
                Database.NoSmall(val);
            Rank.Text = "";
            Rank.Focus();
        }
        private void CeilingButton_Click(object sender, EventArgs e)
        {
            Algo.DeleteLabel();
            int val = int.Parse(Ceiling.Text);
            Algo.Ceiling(head, val);
            if (Database.Label.Count == 0)
                Database.NoLarge(val);
            Ceiling.Text = "";
            Ceiling.Focus();
        }

        private void FindMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value is: "+Algo.MaxValue(head).ToString());
        }

        private void FindMin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Min value is: " + Algo.MinValue(head).ToString());
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //Add later on
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(Delete.Text);
            TreeNode Node = new TreeNode(value);
            Algo.Delete(ref head, Node);
            Delete.Text = "";
            Delete.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawTool.SetUpDrawing(this.Controls, g);
        }
        
       
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace TreeAlgoVisualize
{
    class TreeNode:Tree
    {
        private Label label;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val) : base(val)
        {
            this.label = new Label();
            this.label.ForeColor = Color.Red;
            this.label.BackColor = Color.Green;
            this.label.Text = val.ToString();
            this.label.Name = val.ToString();
            this.label.Location = new Point(0,300);
            this.label.TextAlign = ContentAlignment.MiddleCenter;
            this.label.Width = 40;
            this.label.Height = 40;
            this.label.Font = new Font("Sanserif", 12, FontStyle.Bold);
        }
        public int Val
        {
            get { return base.val; }
        }
        
        public TreeNode() { }
        public Label getLabel()
        {
            return this.label;
        }
        public void NodeGoLeft(Point pos)
        {
            this.label.Location = new Point(pos.X - 40, pos.Y + 50);
        }
        public void NodeGoRight(Point pos)
        {
            this.label.Location = new Point(pos.X + 40, pos.Y + 50);
        }

        public void SetPostion(Point pos)
        {
            this.label.Location = new Point(pos.X,pos.Y);
        }
        public void HeadGoLeft()
        {
            this.label.Location = new Point(this.label.Location.X - 30,
                this.label.Location.Y + 5);
            
        }
        public void HeadGoRight()
        {
            this.label.Location = new Point(this.label.Location.X + 30,
                this.label.Location.Y + 5);
        }
        
    }
}

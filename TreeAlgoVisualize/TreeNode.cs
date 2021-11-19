using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace TreeAlgoVisualize
{
    class TreeNode
    {
        private int val;
        private Label label;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val)    
        {
            this.val = val;
            this.label = new Label();
            this.label.ForeColor = Color.FromArgb(232, 65, 24);
            this.label.BackColor = Color.FromArgb(46, 204, 113);
            this.label.Text = val.ToString();
            this.label.Name = val.ToString();
            this.label.Location = new Point(540,500);
            this.label.TextAlign = ContentAlignment.MiddleCenter;
            this.label.Width = 40;
            this.label.Height = 40;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.FillMode=System.Drawing.Drawing2D.FillMode.Winding;
            path.AddEllipse(0, 0, this.label.Width, this.label.Height);
            this.label.Region = new Region(path);
            this.label.Font = new Font("serif", 14, FontStyle.Bold);
        }
        public int Val
        {
            get { return this.val; }
            set { this.val = value; }
        }
        
        public TreeNode() { }
        public Label getLabel()
        {
            return this.label;
        }
        public void NodeGoLeft(Point pos)
        {
            this.label.Location = new Point(pos.X - 40, pos.Y + 40);
        }
        public void NodeGoRight(Point pos)
        {
            this.label.Location = new Point(pos.X + 40, pos.Y + 40);
        }
        public void SetPostion(Point pos)
        {
            this.label.Location = new Point(pos.X,pos.Y);
        }
        public void HeadGoLeft()
        {
            this.label.Location = new Point(this.label.Location.X - 25,
                this.label.Location.Y + 8);
        }
        public void HeadGoRight()
        {
            this.label.Location = new Point(this.label.Location.X + 25,
                this.label.Location.Y + 8);
        }

        public void setLabel(Label label)
        {
            this.label.Name = label.Name;
            this.label.Text = label.Text;
        }
    }
}

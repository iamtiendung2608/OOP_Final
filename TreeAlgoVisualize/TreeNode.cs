using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace TreeAlgoVisualize
{
    class TreeNode:Node
    {
        private int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val):base(val.ToString())    
        {
            this.val = val;
        }
        public int Val
        {
            get { return this.val; }
            set { this.val = value; }
        }
        public override void NodeGoLeft(Point pos)
        {
            this.getLabel().Location = new Point(pos.X - 40, pos.Y + 40);
        }
        public override void NodeGoRight(Point pos)
        {
            this.getLabel().Location = new Point(pos.X + 40, pos.Y + 40);
        }
        public override void SetPostion(Point pos)
        {
            this.getLabel().Location = new Point(pos.X,pos.Y);
        }
        public override void  HeadGoLeft()
        {
            this.getLabel().Location = new Point(this.getLabel().Location.X - 25,
                this.getLabel().Location.Y + 8);
        }
        public override void  HeadGoRight()
        {
            this.getLabel().Location = new Point(this.getLabel().Location.X + 25,
                this.getLabel().Location.Y + 8);
        }
    }
}

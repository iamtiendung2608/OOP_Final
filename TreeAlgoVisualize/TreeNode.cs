using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Drawing;
namespace TreeAlgoVisualize
{
    class TreeNode:Tree
    {
        private Point Pos;

        public TreeNode(Point pos, int val):base(val)
        {
            Pos = pos;
        }
        public TreeNode(int val) : base(val)
        {
            //TODO: Default value for X and Y
            Pos.X = 20;
            Pos.Y = 20;
            base.val = val;
        }
        public int Val
        {
            get { return base.val; }
        }
        public Point Node
        {
            get { return Pos; }
            set { this.Pos = value; }
        }
        public TreeNode() { }
        public void InsertChange()
        {
            Pos.X += 30;
            Pos.Y += 10;
        }
        public void DeleteChange()
        {
            Pos.X -= 20;
            Pos.Y -= 10;
        }
    }
}

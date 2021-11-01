using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeAlgoVisualize
{
    class CreateLabel
    {
        public static Pen pen = new Pen(Color.Red,5);
        public static Label Create(TreeNode node)
        {
            Label Result = new Label();
            Result.ForeColor = Color.Red;
            Result.BackColor = Color.Green;
            Result.Text = node.Val.ToString();
            Result.Name = node.Val.ToString();
            Result.Location = new Point(node.Node.X,node.Node.Y);
            Result.TextAlign = ContentAlignment.MiddleCenter;
            Result.Width =  50;
            Result.Height = 30;
            Result.Font = new Font("Sanserif", 14, FontStyle.Bold);
            return Result;
        }
    }
}

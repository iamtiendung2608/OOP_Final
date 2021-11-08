using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
namespace TreeAlgoVisualize
{
    class TreeTransition
    {
        public static void goLeft(TreeNode node)
        {
            if (node == null)
                return;
            node.HeadGoLeft();
            goLeft(node.left);
            goLeft(node.right);
        }
        public static void goRight(TreeNode node)
        {
            if (node == null)
                return;
            node.HeadGoRight();
            goRight(node.left);
            goRight(node.right);
        }
        public static Point get_distance(Point pos1, Point pos2)
        {
            return new Point((pos2.X -pos1.X)/10 , (pos2.Y - pos1.Y)/10 );
        }
        public static void change_position(TreeNode node1, Point dis)
        {
            for (int i = 0; i < 10; i++)
            {
                Point Des = new Point(node1.getLabel().Left + dis.X, node1.getLabel().Top + dis.Y);
                node1.SetPostion(Des);
                Task.Delay(100).Wait();
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeAlgoVisualize
{
    class TreeTransition
    {
        public static Pen DrawPen = new Pen(Color.Red, 4);
        public static Pen DeletePen = new Pen(Color.White, 6);
        public static ArrayList S = new ArrayList();
        public static Graphics DrawGraphics;
        public static Label DeleteLabel;
        public static void SetUpDrawing(Graphics g)
        {
            DrawGraphics = g;
        }
        public static void goLeft(TreeNode node,Label Source)
        {
            if (node == null)
                return;
            DeleteLabel = node.getLabel();
            DrawComponent.DeleteLine(Source, DeleteLabel, DrawGraphics);
            S.Add(new DrawComponent(Source, node.getLabel()));
            goLeft(node.left,node.getLabel());
            goLeft(node.right,node.getLabel());
            node.HeadGoLeft();
        }
        public static void goRight(TreeNode node, Label Source)
        {
            if (node == null)
                return;
            DeleteLabel = node.getLabel();
            DrawComponent.DeleteLine(Source, DeleteLabel, DrawGraphics);
            S.Add(new DrawComponent(Source, node.getLabel()));
            goRight(node.left,node.getLabel());
            goRight(node.right,node.getLabel());
            node.HeadGoRight();
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
        public static void ReDraw(Graphics g)
        {
            Graphics G = g;
            foreach (DrawComponent i in S)
            {
                DrawComponent.Draw(i.start, i.end, G);
            }
            S.Clear();
        }
        public static void DeleteLineBetweenComponent(Graphics g, DrawComponent leaf)
        {
            DrawComponent.DeleteLine(leaf.start, leaf.end, g);
        }
    }
}

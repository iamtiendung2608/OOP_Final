using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeAlgoVisualize
{
    class DeleteComponent
    {
        public static Point DefaultLocation ;
        static Graphics DrawGraphics;
        public static ArrayList DeleteList = new ArrayList();
        public static void CreateDrawGraphics(Graphics g)
        {
            DrawGraphics = g;
        }
        public static void GetDelete(ref TreeNode Head, TreeNode Prev)
        {
            if (Head == null)
                return;
            DeleteList.Add(new DrawComponent(Prev.getLabel(), Head.getLabel()));
            GetDelete(ref Head.left, Head);
            GetDelete(ref Head.right, Head);
        }
        public static void DeleteLine(ref TreeNode Head, TreeNode Prev)
        {
            GetDelete(ref Head, Prev);
            foreach (DrawComponent i in DeleteList)
            {
                TreeTransition.DeleteLineBetweenComponent(DrawGraphics, i); 
            }
            DeleteList.Clear();
            MoveComponent(ref Head, DefaultLocation);
            GetDelete(ref Head, Prev);
            foreach (DrawComponent i in DeleteList)
            {
                DrawComponent.Draw(i.start, i.end, DrawGraphics);
            }
            DeleteList.Clear();
        }
        public static void MoveComponent(ref TreeNode Head, Point Pos)
        {
            if (Head == null)
                return;
            Head.SetPostion(Pos);
            Task.Delay(400).Wait();
            Point Def = Head.getLabel().Location;
            MoveComponent(ref Head.left, new Point(Def.X-40,Def.Y+50));
            MoveComponent(ref Head.right, new Point(Def.X+40, Def.Y+50));
        }
    }
}

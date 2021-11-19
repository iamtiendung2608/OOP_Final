using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeAlgoVisualize
{
    class DrawComponent:DrawTool
    {
        public Label start;
        public Label end;
        public DrawComponent(Label Start, Label End)
        {
            start = Start;
            end = End;
        }
        public static void Draw(Label start, Label end)
        {
            if (start.Location == end.Location)
                return;
            Point Start = new Point(start.Left + start.Width / 2, start.Top + start.Height-5);
            Point End = new Point((end.Left + end.Width / 2), end.Top+5);
            DrawGraphics.DrawLine(TreeTransition.DrawPen, Start, End);
        }
        public static void DeleteLine(Label start, Label end)
        {
            if (start.Location == end.Location||start==null||end==null)
                return;
            Point Start = new Point(start.Left + start.Width / 2, start.Top + start.Height - 5);
            Point End = new Point((end.Left + end.Width / 2), end.Top + 5);
            DrawGraphics.DrawLine(TreeTransition.DeletePen, Start, End);
        }
    }
}

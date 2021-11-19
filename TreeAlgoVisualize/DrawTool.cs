using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Windows.Forms.Control;

namespace TreeAlgoVisualize
{
    abstract class DrawTool
    {
        protected static ControlCollection FormControls;
        protected static Graphics DrawGraphics;
        protected static Pen DrawPen = new Pen(Color.Red, 4);
        protected static Pen DeletePen = new Pen(Color.White, 6);

        public static void SetUpDrawing(ControlCollection k, Graphics g)
        {
            FormControls = k;
            DrawGraphics = g;
        }
    }
}

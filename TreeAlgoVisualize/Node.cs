using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeAlgoVisualize
{
    abstract class Node
    {
        private Label Label;

        protected Node(String Name)
        {
            this.Label = new Label();
            this.Label.ForeColor = Color.FromArgb(232, 65, 24);
            this.Label.BackColor = Color.FromArgb(0, 184, 148);
            this.Label.Text = Name;
            this.Label.Name = Name;
            this.Label.Location = new Point(540, 500);
            this.Label.TextAlign = ContentAlignment.MiddleCenter;
            this.Label.Width = 40;
            this.Label.Height = 40;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.FillMode = System.Drawing.Drawing2D.FillMode.Winding;
            path.AddEllipse(0, 0, this.Label.Width, this.Label.Height);
            this.Label.Region = new Region(path);
            this.Label.Font = new Font("serif", 14, FontStyle.Bold);
        }

        public Label getLabel()
        {
            return this.Label;
        }
        public void setLabel(Label label)
        {
            this.Label.Name = label.Name;
            this.Label.Text = label.Text;
        }
        public abstract void HeadGoRight();
        public abstract void HeadGoLeft();
        public abstract void SetPostion(Point pos);
        public abstract void NodeGoRight(Point pos);
        public abstract void NodeGoLeft(Point pos);


    }
}

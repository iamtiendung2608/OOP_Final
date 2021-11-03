using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TreeAlgoVisualize
{
    abstract class Tree
    {
        protected int val;
        public Tree(int val)
        {
            this.val = val;
        }
        public Tree()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAlgoVisualize
{
    abstract class Tree
    {
        protected int val;
        private Tree left;
        private Tree right;
        public Tree(int val)
        {
            this.left = null;
            this.right = null;
            this.val = val;
        }
        public Tree()
        {

        }

    }
}

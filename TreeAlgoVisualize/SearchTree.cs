using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace TreeAlgoVisualize
{
    class SearchTree:DrawTool
    {
        public static Label ances=new Label();

        public static void searchKey(ref TreeNode current, int key, ref TreeNode par)
        {
            while (current != null && current.Val != key)
            {
                par = current;
                if (key < current.Val)
                {
                    ances = current.getLabel();
                    Database.SearchLabel(current.Val);
                    current = current.left;
                }
                else
                {
                    ances = current.getLabel();

                    Database.SearchLabel(current.Val);
                    current = current.right;
                }
            }
        }
        public static TreeNode getMinimumKey(TreeNode leaf)
        {
            while (leaf.left != null)
                leaf = leaf.left;
            return leaf;
        }

    }
}

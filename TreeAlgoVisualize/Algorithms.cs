using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.Control;

namespace TreeAlgoVisualize
{
    interface Algorithms
    {
        void Insert(ref TreeNode Result, TreeNode S, ControlCollection k);
        void Delete(int val);
        void Rank(TreeNode head,int val, ControlCollection k);
        void Ceiling(TreeNode head, int val, ControlCollection k);
        void Travelsal(TreeNode node, ControlCollection k);
        int MaxValue(TreeNode node, ControlCollection k);
        int MinValue(TreeNode node, ControlCollection k);
    }
}

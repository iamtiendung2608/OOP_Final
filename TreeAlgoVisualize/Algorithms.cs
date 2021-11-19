using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.Control;

namespace TreeAlgoVisualize
{
    interface Algorithms
    {
        void Insert(ref TreeNode Result, TreeNode S);
        void Delete(ref TreeNode Result, TreeNode S);
        void Rank(TreeNode head, int val);
        void Ceiling(TreeNode head, int val);
        void Travelsal(TreeNode node);
        int MaxValue(TreeNode node);
        int MinValue(TreeNode node);
    }
}

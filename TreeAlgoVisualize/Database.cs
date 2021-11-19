using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace TreeAlgoVisualize
{
    class Database : Algorithms
    {
        public static ArrayList Label = new ArrayList();
        static int Start_Hoz = 100;
        const int Start_Ver = 400;
        static int _Hoz = 540;
        const int _Ver = 60;
        static int i = 0;
        static Graphics g;
        public static Stack<TreeNode> Store = new Stack<TreeNode>();
        public static TreeNode Default;
        public static void setGraphics(Graphics G)
        {
            g = G;
        }
        public void Delete(ref TreeNode Result, TreeNode S, ControlCollection k)
        {
            TreeNode parent = null;
            TreeNode current = Result;
            SearchTree.searchKey(ref current, S.Val, ref parent);
            if (current == null)
            {
                MessageBox.Show("Not Found!");
                return;
            }
            //Node delete have no leaf
            if (current.left==null && current.right == null)
            {
                if (current != Result)
                {
                    if (parent.left == current)
                    {
                        parent.left = null;
                    }
                    else
                        parent.right = null;
                }
                else
                    Result = null;
                k.Remove(current.getLabel());
                DrawComponent.DeleteLine(SearchTree.ances, current.getLabel(), g);
            }
            //Node delete have 2 leaf
            else if(current.left != null && current.right != null)
            {
                TreeNode leaf = SearchTree.getMinimumKey(current.right);
                Delete(ref Result, leaf, k);
                current.Val = leaf.Val;
                current.setLabel(leaf.getLabel());
                k.Remove(leaf.getLabel());
            }
            //Node delete have 1 leaf
            else
            {
                TreeNode child = (current.left!=null) ? current.left : current.right;
                
                if (current != Result)
                {
                    if (current == parent.left)
                    {
                        parent.left.setLabel(current.getLabel());
                        parent.left = child;
                    }
                    else
                    {
                        parent.right.setLabel(current.getLabel());
                        parent.right = child;
                    }
                }
                else
                {
                    Result.setLabel(child.getLabel());
                    Result = child;
                }
                DeleteComponent.DefaultLocation = current.getLabel().Location;
                k.Remove(current.getLabel());
                DeleteComponent.DeleteLine(ref child, current);
            }
        }
        public void Insert(ref TreeNode Result, TreeNode S, ControlCollection k)
        {
            if (i == 0)
            {
                i++;
                S.SetPostion(new Point(_Hoz, _Ver));
            }
            if (Result == null)
            {
                Default = S;
                Result = S;
            }
            else if (S.Val >= Result.Val)
            {
                SearchLabel(Result.Val, k);
                TreeTransition.goRight(Result.right,Result.getLabel());
                S.NodeGoRight(Result.getLabel().Location);
                Store.Push(Result);
                Insert(ref Result.right , S, k);
            }
            else
            {
                SearchLabel(Result.Val, k);
                TreeTransition.goLeft(Result.left,Result.getLabel());
                S.NodeGoLeft(Result.getLabel().Location);
                Store.Push(Result);
                Insert(ref Result.left, S, k);
            }
        }
        //Inorder Travelsal
        public void Travelsal(TreeNode node, ControlCollection k)
        {
            if (node == null)
                return;
            Travelsal(node.left,k);
            SearchLabel(node.Val, k);
            PrintLabel(node.Val, k);
            Travelsal(node.right, k);
        }
        public static void SearchLabel(int name, ControlCollection k)
        {
            foreach (Control i in k)
            {
                if (i is Label && i.Text
                    == name.ToString())
                {
                    i.BackColor = Color.FromArgb(155, 89, 182);
                    Task.Delay(600).Wait();
                    i.BackColor = Color.FromArgb(46, 204, 113);
                }
            }
        }
        public int MaxValue(TreeNode node, ControlCollection k)
        {
            if (node.right != null)
            {
                return MaxValue(node.right, k);
            }
            PrintLabel(node.Val, k);
            return node.Val;
        }

        public int MinValue(TreeNode node, ControlCollection k)
        {
            if (node.left != null)
            {
                return MinValue(node.left, k);
            }
            PrintLabel(node.Val, k);
            return node.Val;
        }

        public void Rank(TreeNode head, int val, ControlCollection k)
        {
            if (head == null)
            {
                return;
            }
            Rank(head.left,val,k);
            if (head.Val <= val)
                PrintLabel(head.Val, k);
            SearchLabel(head.Val, k);
            Rank(head.right, val, k);
        }

        public void Ceiling(TreeNode head, int val, ControlCollection k)
        {
            if (head == null)
            {
                return;
            }
            Ceiling(head.left, val, k);
            if (head.Val >= val)
                PrintLabel(head.Val, k);
            SearchLabel(head.Val, k);
            Ceiling(head.right, val, k);
        }
        public void DeleteLabel(ControlCollection k)
        {
            foreach (Label i in Label)
            {
                k.Remove(i);
            }
            Start_Hoz = 100;
            Label.Clear();
        }
        public void PrintLabel(int name, ControlCollection k)
        {
            TreeNode NodeNew = new TreeNode(name);
            NodeNew.SetPostion(new Point(Start_Hoz, Start_Ver));
            Start_Hoz += 70;
            k.Add(NodeNew.getLabel());
            Label.Add(NodeNew.getLabel());
        }
        public static void NoSmall(int val)
        {
            MessageBox.Show("No value Smaller than "+val);
        }
        public static void NoLarge(int val)
        {
            MessageBox.Show("No value Larger than " + val);
        }
        public static TreeNode getDrawPoint()
        {
            if (Store.Count == 0)
                return Default;
            return Store.Pop();
        }
    }
}

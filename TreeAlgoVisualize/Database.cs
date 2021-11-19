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
    class Database : DrawTool,Algorithms
    {
        public static ArrayList Label = new ArrayList();
        static int Start_Hoz = 100;
        const int Start_Ver = 400;
        static int _Hoz = 540;
        const int _Ver = 60;
        static int i = 0;
        public static Stack<TreeNode> Store = new Stack<TreeNode>();
        public static TreeNode Default;

        public void Delete(ref TreeNode Result, TreeNode S)
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
                FormControls.Remove(current.getLabel());
                DrawComponent.DeleteLine(SearchTree.ances, current.getLabel());
            }
            //Node delete have 2 leaf
            else if(current.left != null && current.right != null)
            {
                TreeNode leaf = SearchTree.getMinimumKey(current.right);
                Delete(ref Result, leaf);
                current.Val = leaf.Val;
                current.setLabel(leaf.getLabel());
                FormControls.Remove(leaf.getLabel());
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
                FormControls.Remove(current.getLabel());
                DeleteComponent.DeleteLine(ref child, current);
            }
        }
        public void Insert(ref TreeNode Result, TreeNode S)
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
                SearchLabel(Result.Val);
                TreeTransition.goRight(Result.right,Result.getLabel());
                S.NodeGoRight(Result.getLabel().Location);
                Store.Push(Result);
                Insert(ref Result.right , S);
            }
            else
            {
                SearchLabel(Result.Val);
                TreeTransition.goLeft(Result.left,Result.getLabel());
                S.NodeGoLeft(Result.getLabel().Location);
                Store.Push(Result);
                Insert(ref Result.left, S);
            }
        }
        //Inorder Travelsal
        public void Travelsal(TreeNode node)
        {
            if (node == null)
                return;
            Travelsal(node.left);
            SearchLabel(node.Val);
            PrintLabel(node.Val);
            Travelsal(node.right);
        }
        public static void SearchLabel(int name)
        {
            foreach (Control i in FormControls)
            {
                if (i is Label && i.Text
                    == name.ToString())
                {
                    i.BackColor = Color.FromArgb(155, 89, 182);
                    Task.Delay(600).Wait();
                    i.BackColor = Color.FromArgb(0, 184, 148);
                }
            }
        }
        public int MaxValue(TreeNode node)
        {
            if (node.right != null)
            {
                return MaxValue(node.right);
            }
            PrintLabel(node.Val);
            return node.Val;
        }

        public int MinValue(TreeNode node)
        {
            if (node.left != null)
            {
                return MinValue(node.left);
            }
            PrintLabel(node.Val);
            return node.Val;
        }

        public void Rank(TreeNode head, int val)
        {
            if (head == null)
            {
                return;
            }
            Rank(head.left,val);
            if (head.Val <= val)
                PrintLabel(head.Val);
            SearchLabel(head.Val);
            Rank(head.right, val);
        }

        public void Ceiling(TreeNode head, int val)
        {
            if (head == null)
            {
                return;
            }
            Ceiling(head.left, val);
            if (head.Val >= val)
                PrintLabel(head.Val);
            SearchLabel(head.Val);
            Ceiling(head.right, val);
        }
        public void DeleteLabel()
        {
            foreach (Label i in Label)
            {
                FormControls.Remove(i);
            }
            Start_Hoz = 100;
            Label.Clear();
        }
        public void PrintLabel(int name)
        {
            TreeNode NodeNew = new TreeNode(name);
            NodeNew.SetPostion(new Point(Start_Hoz, Start_Ver));
            Start_Hoz += 70;
            FormControls.Add(NodeNew.getLabel());
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

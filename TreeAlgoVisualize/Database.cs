﻿using System;
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
        static int Start_Hoz = 100;
        const int Start_Ver = 350; 
        
        public void Delete(int val)
        {
            throw new NotImplementedException();
        }

        public void Insert(ref TreeNode Result, TreeNode S, ControlCollection k
           )
        {
            if (Result == null)
            {
                Result = S;
            }
            else if (S.Val >= Result.Val)
            {
                Result.HeadGoRight();
                S.NodeGoRight();
                SearchLabel(Result.Val, k);
                Insert(ref Result.right , S, k);
            }
            else
            {
                Result.HeadGoLeft();
                S.NodeGoLeft();
                SearchLabel(Result.Val, k);
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


        public void SearchLabel(int name, ControlCollection k)
        {
            foreach (Control i in k)
            {
                
                if (i is Label && i.Text
                    == name.ToString())
                {
                    i.BackColor = Color.Purple;
                    Task.Delay(800).Wait();
                    i.BackColor = Color.Green;
                }

            }
        }
        public void PrintLabel(int name, ControlCollection k)
        {
            TreeNode NodeNew = new TreeNode(name);
            NodeNew.SetPostion(new Point(Start_Hoz, Start_Ver));
            Start_Hoz += 70;
            k.Add(NodeNew.getLabel());
        }

        public int MaxValue(TreeNode node, ControlCollection k)
        {
            if (node.right != null)
            {
                PrintLabel(node.Val, k);
                return MaxValue(node.right, k);
            }
            PrintLabel(node.Val, k);
            return node.Val;

        }

        public int MinValue(TreeNode node, ControlCollection k)
        {
            if (node.left != null)
            {
                PrintLabel(node.Val, k);
                return MaxValue(node.left, k);
            }
            PrintLabel(node.Val, k);
            return node.Val;
        }

        public void Rank(TreeNode head, int val, ControlCollection k)
        {
            if (head == null)
                return;
            Rank(head.left,val,k);
            if (head.Val <= val)
                PrintLabel(head.Val, k);
            SearchLabel(head.Val, k);
            Rank(head.right, val, k);
        }

        public void Ceiling(TreeNode head, int val, ControlCollection k)
        {
            if (head == null)
                return;
            Ceiling(head.left, val, k);
            if (head.Val >= val)
                PrintLabel(head.Val, k);
            SearchLabel(head.Val, k);
            Ceiling(head.right, val, k);
        }
        public void DeleteLabel(ControlCollection k)
        {
            foreach (Control i in k)
            {
                if (i.Location.Y == Start_Ver)
                    k.Remove(i);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Tree
    {
        public Node Root { get; set; }
        public int NodeCount { get; set; }

        public Tree()
        {
            Root = new Node();
        }

        public int LeftNodeCount
        {
            get
            {
                int sum = 0;

                if (Root != null && Root.Left != null)
                {
                    sum = Node.GetSideCount(Root.Left, sum);
                }

                return sum;
            }
        }

        public int RightNodeCount
        {
            get
            {
                int sum = 0;

                if (Root != null && Root.Right != null)
                {
                    sum = Node.GetSideCount(Root.Right, sum);
                }

                return sum;
            }
        }

        public void AddLetter(string v)
        {
            Node.AddLetter(Root, v);
            NodeCount++;
        }

        public void ClearNodes()
        {
            Root = new Node();
            NodeCount = 0;
        }

    }


    public class Node
    {
        public string Val { get; set; }
       

        public Node Left { get; set; }
        public Node Right { get; set; }

       
        public static int GetSideCount(Node currentNode, int currentCount)
        {
            if (currentNode == null)
            {
                return currentCount;
            }

            currentCount++;

            if (currentNode.Left != null)
            {
               currentCount = GetSideCount(currentNode.Left, currentCount);
            }

            if (currentNode.Right != null)
            {
                currentCount = GetSideCount(currentNode.Right, currentCount);
            }

            return currentCount;
        }


        public static void AddLetter(Node currentNode, string val)
        {
            if (string.IsNullOrEmpty(currentNode.Val)) //found a spot
            {
                currentNode.Val = val;
                return;
            }

            //if both the left and right side are empty,
            //pick the left if the letter comes BEFORE, right otherwise
            if (currentNode.Right == null && currentNode.Left == null)
            {
                if (currentNode.Val.CompareTo(val) >= 0)
                {
                    currentNode.Left = new Node();

                    AddLetter(currentNode.Left, val);
                    return;
                }
                else
                {
                    currentNode.Right = new Node();
                    AddLetter(currentNode.Right, val);
                    return;
                }
            }

            //if only the right side is avail, pick it
            if (currentNode.Right == null && currentNode.Left != null)
            {
                currentNode.Right = new Node();
                AddLetter(currentNode.Right, val);
                return;
            }

            //if only the left side is avail, pick it
            if (currentNode.Left == null && currentNode.Right != null)
            {
                currentNode.Left = new Node();
                AddLetter(currentNode.Left, val);
                return;
            }

          
            //if both sides are taken, traverse left if the letter comes BEFORE, else go right.
            if (currentNode.Right != null && currentNode.Left != null)
            {
                if (currentNode.Val.CompareTo(val) >= 0)
                {
                    AddLetter(currentNode.Left, val);
                    return;
                }
                else
                {
                    AddLetter(currentNode.Right, val);
                    return;
                }
            }
        }

    }
}

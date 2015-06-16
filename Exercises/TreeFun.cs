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

        public Tree()
        {
            Root = new Node();
        }
        public void PrintNodes()
        {
            Root.PrintVals("");
        }

        public void AddLetter(string v)
        {
            Root.AddLetter(v);
        }

    }


    public class Node
    {
        public string Val { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }

        public void PrintVals(string leftOrRight)
        {
            if (leftOrRight != "")
            {
                Val = leftOrRight + ":" + Val;
            }

            Console.WriteLine(Val + leftOrRight);

            if (Left == null && Right == null)
            {
                return;
            }

            if (Left != null)
            {
                Left.PrintVals("Left");
            }

            if (Right != null)
            {
                Right.PrintVals("Right");
            }

        }

        public void AddLetter(string val)
        {
            if (string.IsNullOrEmpty(Val)) //found a spot
            {
                Val = val;
                return;
            }

            if (Left == null && Right != null)
            {
                Left = new Node();
                Left.AddLetter(val);
                return;
            }

            if (Right == null && Left != null)
            {
                Right = new Node();
                Right.AddLetter(val);
                return;
            }

            //both null
            if (Right == null && Left == null)
            {
                Left = new Node();
                Left.AddLetter(val);
                return;
            }

            if (Right != null && Left != null)
            {
                if (Left.Val.CompareTo(val) > 0)
                {
                    Right.AddLetter(val);
                    return;
                }
                else
                {
                    Left.AddLetter(val);
                    return;
                }
            }



        }

    }
}

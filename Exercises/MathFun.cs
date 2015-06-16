using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class MathFun
    {
        public static int PerformPolish(string s)
        {

            var ops = new List<char>();
            var nums = new List<char>();

            //set up lists
            foreach (char c in s.ToCharArray())
            {
                if (IsOperator(c))
                {
                    ops.Add(c);
                }
                else
                {
                    nums.Add(c);
                }
            }


            int sum = 0;

            if ((ops.Count >= 1) && (nums.Count >= 2))
            {
                sum = PerformOp(ops[ops.Count - 1], nums[0], nums[1]);
            }


            int j = 1; //start from the second number and march outwards

            for (int i = ops.Count - 2; i >= 0; i--)
            {

                if ((j + 1) <= (nums.Count - 1))
                {
                    sum = PerformOp(ops[i], sum, nums[j + 1]);
                }

                j++;

            }

            return sum;
        }


        private static bool IsOperator(char c)
        {
            return (c == '+') || (c == '-') || (c == 'x') || (c == '/');
        }

        private static int PerformOp(char op, char a, char b)
        {
            int sum = 0;

            int valA = (int)Char.GetNumericValue(a);
            int valB = (int)Char.GetNumericValue(b);

            switch (op)
            {
                case '+':
                    sum = (valA + valB);
                    break;
                case '-':
                    sum = (valA - valB);
                    break;
                case '/':
                    sum = (valA / valB);
                    break;
                case 'x':
                    sum = (valA * valB);
                    break;
                default:
                    break;
            }

            return sum;


        }


        private static int PerformOp(char op, int a, char b)
        {
            int sum = 0;


            int valB = (int)Char.GetNumericValue(b);

            switch (op)
            {
                case '+':
                    sum = (a + valB);
                    break;
                case '-':
                    sum = (a - valB);
                    break;
                case '/':
                    sum = (a / valB);
                    break;
                case 'x':
                    sum = (a * valB);
                    break;
                default:
                    break;
            }

            return sum;
        }
    }
}

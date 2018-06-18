using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Solution
    {

        int[] t;

        public Solution(int[] t)
        {
            this.t = t;
        }

        public int solution()
        {
            int counter = 0;
            for (int i = 0; i < this.t.Length; i++)
            {
                if (this.t[i] < 6)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { -5, -5, -5, -42, 6, 12 };
            Solution q = new Solution(t);
            Console.WriteLine("Winter Length = " + q.solution());
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            pascal(2);
        }

        public static List<int> pascal(int n)
        {
            List<int> prev = new List<int>();
            List<int> curr = new List<int>();

            if (n == 1)
            {
                Console.Write(1);
            }
            else
            {
                curr.Add(1);
                //Recursion to get the previous array to allow 
                prev = pascal(n - 1);
                for (int i = 0; i < n - 2; i++)
                {
                    curr.Add(prev[i] + prev[i + 1]);
                }
                curr.Add(1);
            }
            foreach (int num in curr)
            {
                Console.Write(num);
                Console.Write(" ");
            }
            Console.WriteLine("");
            return curr;
        }
    }
}

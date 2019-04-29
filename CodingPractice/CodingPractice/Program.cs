using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 1, 3, 6, 6 };
            Console.WriteLine(removeDuplicates(arr));
        }

        public static int[] removeDuplicates(int [] arr)
        {
            HashSet<int> list = new HashSet<int>();

            for(int i=0; i<arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        list.Add(arr[i]);
                    }
                }
            }
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            return list.ToArray<int>();
         } 
    }
}

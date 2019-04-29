using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

//Write a method that receives a number as parameter and calculate the Fibonacci number with 
//time complexity of O(N) and space complexity of O(1). A Fibonacci number is defined as below.
//The code should be accompanied with passing unit tests.Don’t forget to handle error cases.
//Fib(n) = Fib(n-1) + Fib(n-2), where Fib(0) = 1, and Fib(1) = 1.

namespace CalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate calc = new calculate();

            //Console.Write("Enter First number: ");
            //int fnum = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int snum = Convert.ToInt32(Console.ReadLine());

            //int res = calc.Add(fnum, snum);

            //Console.Write("Result is: " + res);

            

            Console.Write("Fibonacci series recursive: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", fib(i));
            }

            Console.Write("\nFibonacci series iterative: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", fibo(i));
            }
            Console.Write("\nFibonacci iterative nth value: ");
            Console.WriteLine(fibo(4));

            Console.Write("Fibonacci iterative nth value: ");
            Console.WriteLine(fibonacci(4));

            Console.Read();
        }

        //Use an array to store the values of the sequence upto n, then index
        static int fibonacci(int num)
        {
            int[] Fib = new int[num];

            Fib[0] = 1;
            Fib[1] = 1;

            for(int i = 2; i < num; i++)
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
            }
            
            return Fib[num-1];
        }

        //fibonacci iterative 2
        static int fibo(int num)
        {
            int a = 1;
            int b = 1;
            int next = 0;

            if (num == 0)
                return 1;
            if (num == 1)
                return 1;
            for (int i = 2; i <= num; i++)
            {
                next = a + b;
                a = b;
                b = next;
            }
            return next;
        }

        //recursive fibonacci
        static int fib(int num)
        {
            if (num == 0)
            {
                return 1;

            }if (num == 1)
            {
                return 1;
            }
            else
            {
                return fib(num - 1) + fib(num - 2);
            }
            
        }
    }
}

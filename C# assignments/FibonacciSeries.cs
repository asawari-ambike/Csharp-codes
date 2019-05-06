using System;

namespace C__assignments
{
    public class FibonacciSeries
    {
        public void PrintSeries()
        {
            Console.WriteLine("Enter number of terms:");
            int terms = Convert.ToInt32(Console.ReadLine());
            int first = 1, next = 1, temp = 0;

            Console.WriteLine("Fibonacci series upto {0} terms:\n",terms);
            Console.Write("{0}\t",first);

            for (int i=2; i<=terms; i++)
            {
                Console.Write("{0}\t",next);
                temp = next;
                next+=first;
                first = temp;
            }
        }
    }
}

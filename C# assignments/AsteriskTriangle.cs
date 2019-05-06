
using System;

namespace C__assignments
{
    public class AsteriskTriangle
    {
        public void PrintTriangle()
        {
            Console.WriteLine("Enter number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=rows; i++)
            {                
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*\t");
                }
                Console.Write("\n");
            }
        }
    }
}

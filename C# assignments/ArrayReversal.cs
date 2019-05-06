using System;

namespace C__assignments
{
    public class ArrayReversal
    {
        public void ReverseArray()
        {
            Console.WriteLine("Enter the no. of integers to be added in the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("The array:");

            for(int i=0; i<size; i++)
            {
                arr[i] = i;
                Console.Write("{0}\t",arr[i]);
            }

            Console.WriteLine("\nEnter the no. of values to be printed in reverse:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The reversed array:");

            for(int j=n-1; j>=0; j--)
            {
                Console.Write("{0}\t",arr[j]);
            }
        }        
        
    }
}

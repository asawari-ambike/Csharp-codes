using System.ComponentModel;
using System;

namespace C__assignments
{
    public class MaxMinArray
    {
        public int[] GetArray()
        {
            Console.WriteLine("Enter the no. of elements in array:");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[count];
            Console.WriteLine("Enter the integer elements in array:");
            for(int i=0; i<count; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            return arr;

        }

        public void FindMaxMin(int[] arr)
        {
            int len = arr.Length;
            int max = arr[0];
            int min = max;
            for(int i=0; i<len; i++)
            {
                if(arr[i]>max)
                max = arr[i];
            }
            Console.WriteLine("The maximum element in array is: {0}", max);

            for(int j=0; j<len; j++)
            {
                if(arr[j]<min)
                min = arr[j];
            }
            Console.WriteLine("The minimum element in array is: {0}", min);
        }

        public void ArrayMaxMin()
        {
           MaxMinArray obj_ar = new MaxMinArray();
           int[] myarr = obj_ar.GetArray();
           obj_ar.FindMaxMin(myarr); 
        }
    }
}
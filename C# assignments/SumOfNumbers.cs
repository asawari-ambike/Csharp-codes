using System;

namespace C__assignments
{
    public class SumOfNumbers
    {
       int[] Numbers = new int[10];
       
       public void ReadNumbers()
       { 
                   
           Console.WriteLine("Enter the ten numbers:");

           for(int i=1; i<=10; i++)
           {
               Console.WriteLine("Number {0} : ",i);
               Numbers[i-1] = Convert.ToInt32(Console.ReadLine());
               
           }
       }

       public int CalculateSum()
       {
           int[] Num = Numbers;
           int sum=0;
           for(int i=0; i<10; i++)
           {
               sum+=Num[i];
           }
           return sum;
       } 

       public int FindSum()
       {
           SumOfNumbers obj = new SumOfNumbers();
           obj.ReadNumbers();
           int sum = obj.CalculateSum();
           return sum;
       }
    }
}
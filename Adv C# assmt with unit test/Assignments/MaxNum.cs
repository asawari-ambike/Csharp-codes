using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignments
{
    public class MaxNum
    {
        public void FindSecondMax()
        {
             List<int> numList=new List<int>();
             
             Console.WriteLine("Enter the 5 numbers:");
             numList.Add(Convert.ToInt32("3"));
             numList.Add(Convert.ToInt32("4"));
             numList.Add(Convert.ToInt32("54"));
             numList.Add(Convert.ToInt32("88"));
             numList.Add(Convert.ToInt32("65"));

             var FirstLinqQuery = numList.Max();
             
             List<int> numListShort = numList.Where(number => number != FirstLinqQuery).ToList();

             var SecondLinqQuery = (from number in numListShort                                    
                                    select number).Max();

            Console.WriteLine("The second maximum number in the list is: {0}", SecondLinqQuery); 
        }
    }
}
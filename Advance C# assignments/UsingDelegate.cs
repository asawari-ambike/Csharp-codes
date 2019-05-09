using System;

namespace Advance_C__assignments
{
    class UsingDelegate
    {
        public delegate void MyDelegate(int input);

        public static void DisplayName(int rollNumber)
        {
            switch(rollNumber)
            {
                case 1: Console.WriteLine("Asawari");
                break;
                case 2: Console.WriteLine("Rupali");
                break;
                case 3: Console.WriteLine("Aishwarya");
                break;
                default: Console.WriteLine("Only 3 people exist");
                break;
            }            
        }

        public static void CalculatePercent(int marks)
        {
            double percent = (double)marks / 500 * 100;
            Console.WriteLine("Your percentage is: {0}%",percent);
        }

        public static void CalculateFees(int year)
        {
            int baseFee;
            if(year == 1)
            {
                baseFee = 50000;
            }
            else if(year == 2)
            {
                baseFee = 75000;
            }
            else
            {
                baseFee = 100000;
            }
            Console.WriteLine("Your fees are: {0}", baseFee);
        }

        public void DelegateUse()
        {
            MyDelegate delA = new MyDelegate(DisplayName);
            MyDelegate delB = UsingDelegate.CalculatePercent;
            MyDelegate delC = new MyDelegate(CalculateFees);

            Console.WriteLine("Enter roll no. 1-3");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            delA(rollNo);

            Console.WriteLine("Enter the marks out of 500");
            int marks = Convert.ToInt32(Console.ReadLine());
            delB(marks);

            Console.WriteLine("Enter the year of study 1-4");
            int year = Convert.ToInt32(Console.ReadLine());
            delC(year);
        }
    }
}
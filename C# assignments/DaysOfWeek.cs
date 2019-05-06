using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Data;
using System;

namespace C__assignments
{
    public class DaysOfWeek
    {
        public void DisplayByIf()
        {           
            Console.WriteLine("Transverse using if:");
            for(int i=1; i<=7; i++)
            {
                
                if(i == 1)
                    Console.WriteLine("Day {0}: Monday",i);
                else if(i == 2)
                    Console.WriteLine("Day {0}: Tuesday",i);
                else if(i == 3)
                    Console.WriteLine("Day {0}: Wednesday",i);
                else if(i == 4)
                    Console.WriteLine("Day {0}: Thursday",i);
                else if(i == 5)
                    Console.WriteLine("Day {0}: Friday",i);
                else if(i == 6)
                    Console.WriteLine("Day {0}: Saturday",i);
                else if(i == 7)
                    Console.WriteLine("Day {0}: Sunday",i);
                
            }
        }

        public void DisplayBySwitch()
        {
           
            int day=1;
            Console.WriteLine("\nTransverse using switch:");
            while(day <= 7)
            {
                Console.WriteLine("Enter the number of day you want to view:");
                day = Convert.ToInt32(Console.ReadLine());
                switch(day)
                {
                    case 1:
                    Console.WriteLine("Monday");
                    break;
                    case 2:
                    Console.WriteLine("Tuesday");
                    break;
                    case 3:
                    Console.WriteLine("Wednesday");
                    break;
                    case 4:
                    Console.WriteLine("Thursday");
                    break;
                    case 5:
                    Console.WriteLine("Friday");
                    break;
                    case 6:
                    Console.WriteLine("Saturday");
                    break;
                    case 7:
                    Console.WriteLine("Sunday");
                    break;
                    default:
                    Console.WriteLine("Week has only seven days");
                    break;
                }
                                
            }
        }

        
        public void DisplayDay()
        {
            DaysOfWeek display = new DaysOfWeek();
            display.DisplayByIf();
            display.DisplayBySwitch();
        }
        
    }
}

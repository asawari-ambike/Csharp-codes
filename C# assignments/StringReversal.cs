using System.ComponentModel;
using System.Data;
using System;

namespace C__assignments
{
    public class StringReversal
    {
        public String GetString()
        {
            Console.WriteLine("Enter your string:");
            String str = Console.ReadLine();
            return str;
        }
        
        public void ReverseByLoop(String str)
        {
            Console.WriteLine("Reversing characters by loop:");
            char[] ch = str.ToCharArray();
            Console.WriteLine("The characters in your string are:");

            for (int i=0; i<str.Length; i++)
            {
                Console.Write("{0}\t",ch[i]);
            }
            Console.WriteLine("\nThe characters in your string in reverse order are:");

            for(int j=str.Length-1; j>=0; j--)
            {
                Console.Write("{0}\t",ch[j]);
            }
            Console.Write("\n");

        }

        public void ReverseByFunction(String str)
        {
            Console.WriteLine("Reversing characters using built in function:");
           char[] ch = str.ToCharArray();
            Console.WriteLine("The characters in your string are:");

            for (int i=0; i<str.Length; i++)
            {
                Console.Write("{0}\t",ch[i]);
            }
            Console.WriteLine("\nThe characters in your string in reverse order are:");

            Array.Reverse(ch);
            for (int i=0; i<str.Length; i++)
            {
                Console.Write("{0}\t",ch[i]);
            } 
        }

        public void StringReverse()
        {
            StringReversal sr = new StringReversal();
            String str = sr.GetString();
            sr.ReverseByLoop(str);
            sr.ReverseByFunction(str);
        }
    }
}
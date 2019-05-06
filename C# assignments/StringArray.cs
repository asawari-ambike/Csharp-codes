using System;

namespace C__assignments
{
    public class StringArray
    {
        public void StringTraverse()
        {
            String input = "Asawari";
            char[] input_arr = input.ToCharArray();
            int size = input_arr.Length;
            char search;
            bool find = false;

         Console.WriteLine("Enter the character to be searched");
         search = Convert.ToChar(Console.ReadLine());
         int pos = 0;

            for(int i=0; i<size; i++)
            {
             if(input_arr[i]==search)
                {
                    find = true; 
                    pos = i;
                    break;               
                }
            }   

            if(find)
                Console.WriteLine("{0} : Character {1} found at {2}th position", find, search, pos);
            else
                Console.WriteLine("{0} : Character not found", find);       

        }
        
    }
}
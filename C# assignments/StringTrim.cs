using System.Security.Cryptography.X509Certificates;
using System;

namespace C__assignments
{
    public class StringTrim
    {
        public String[] SplitString()
        {
            Console.WriteLine("Enter the string with spaces and | separator:");
            String str = Console.ReadLine();
             
            char[] splitchar = { '|' };
            String[] substr = str.Split(splitchar);

            for(int i=0; i<substr.Length; i++)
            {
                Console.WriteLine("Substring {0}: {1}", i, substr[i]);
            }

            return substr;
        }

        public void CreateNewString(String[] substr)
        {
            for(int i=0; i<substr.Length; i++)
            {
                if(i==0)
                substr[i] = substr[i].TrimEnd();
                else if(i==substr.Length-1)
                substr[i] = substr[i].TrimStart();
                else
                substr[i] = substr[i].Trim();
            }

            String newstring = string.Join("|", substr);
            Console.WriteLine("New string is \"{0}\"", newstring);

            Console.WriteLine("New trimmed string is \"{0}\"", newstring.Trim());
        }

        public void StringTrimming()
        {
            StringTrim str_obj = new StringTrim();
            String[] out_sub = str_obj.SplitString();
            str_obj.CreateNewString(out_sub);

        }
    }
}
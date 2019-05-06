using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System;

namespace C__assignments
{
    public class StringConcat
    {
        public String[] GetString()
        {
            Console.WriteLine("Enter your strings:");
            String[] str = new String[2];
            str[0] = Console.ReadLine();
            str[1] = Console.ReadLine();
            return str;
        }

        public void AppendString(String s1, String s2)
        {
            s1 = s1 + s2;
            Console.WriteLine("The appended string is : {0}", s1);
        }

        public void PrependString(String s1, String s2)
        {
            s2 = s2 + s1;
            Console.WriteLine("The appended string is : {0}", s2);
        }

        public void InsertString(String s1, String s2)
        {
            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            for(int i=0; i<s1.Length; i++)
            {
                for(int j=0; j<s2.Length; j++)
                {
                    if (ch2[j] == ch1[i])
                        ch2[j] = ' ';
                }
            }

            s2 = new String(ch2);

            char[] splitchar = { ' ' };
            String[] substr = s2.Split(splitchar);
            
            for(int i=0; i<substr.Length; i++)
            {
               substr[i] = substr[i].Trim();
            }

            s2 = string.Join("", substr);

            s1 = s1.Insert(1, s2);

            Console.WriteLine("The new non-duplicate merged string is : {0}", s1);
        }

        public void ConcatString()
        {
            StringConcat sc = new StringConcat();
            String[] str = new String[2];
            str = sc.GetString();
            String s1 = str[0];
            String s2 = str[1];
            sc.AppendString(s1,s2);
            sc.PrependString(s1,s2);
            sc.InsertString(s1,s2);
        }
    }
}
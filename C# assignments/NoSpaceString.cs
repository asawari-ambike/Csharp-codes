using System;

namespace C__assignments
{
    public class NoSpaceString
    {
        public void RemoveManually()
        {
            Console.WriteLine("Enter the string with spaces and special characters:");
            String str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            for(int i=0; i<str.Length; i++)
            {
                switch(ch[i])
                {
                    case ' ': ch[i]='|';
                    break;
                    case '@': ch[i]='|';
                    break;
                    case '#': ch[i]='|';
                    break;
                    case '$': ch[i]='|';
                    break;
                    case '%': ch[i]='|';
                    break;
                    case '^': ch[i]='|';
                    break;
                    case '&': ch[i]='|';
                    break;
                    case '*': ch[i]='|';
                    break;
                    case '+': ch[i]='|';
                    break;
                    case '=': ch[i]='|';
                    break;
                    default: break;
                }
            }

            str = new String(ch);

            char[] splitchar = { '|' };
            String[] substr = str.Split(splitchar);

            for(int i=0; i<substr.Length; i++)
            {
                substr[i] = substr[i].Trim();
            }

            String newstring = string.Join("", substr);
            Console.WriteLine("New string is \"{0}\"", newstring);
        }

    }
}
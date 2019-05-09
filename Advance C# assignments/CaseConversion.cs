using System;
using System.Globalization;

namespace Advance_C__assignments
{
    
    class CaseConversion
    {
        public string[] TakeInputStrings(out string userString)
        {
            Console.WriteLine("Enter your string:");
            string input = Console.ReadLine();
            userString = input;
            int lengthOfString = input.Length;
            char[] splitChar = { ' ' };
            string[] subStrings = input.Split(splitChar);
            return subStrings;
        }

        public string ConvertToCamelCase(string[] subStrings)
        {
            int lengthOfArray = subStrings.Length;
            for (int i=0; i<lengthOfArray; i++)
            {
                if(i==0)
                {
                    subStrings[i]=subStrings[i].ToLower();
                }
                else
                {
                    for(int j=0; j<subStrings[i].Length; j++)
                    {
                        char[] stringArray = subStrings[i].ToCharArray();
                        if(j==0)
                        {
                            stringArray[j]=Char.ToUpper(stringArray[j]);
                        }
                        else
                        {
                            stringArray[j]=Char.ToLower(stringArray[j]);
                        }
                        subStrings[i] = new string(stringArray);
                    }
                }
            }

            string camelString = string.Join("", subStrings);
            return camelString;
        }

        public string ConvertToTitleDefault(string myString)
        {
            TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
            myString = myTI.ToTitleCase(myString);
            return myString;
        }

        public string ConvertToTitleCase(string[] subStrings)
        {
            int lengthOfArray = subStrings.Length;
            for (int i=0; i<lengthOfArray; i++)
            {
                for(int j=0; j<subStrings[i].Length; j++)
                    {
                        char[] stringArray = subStrings[i].ToCharArray();
                        if(j==0)
                        {
                            stringArray[j]=Char.ToUpper(stringArray[j]);
                        }
                        else
                        {
                            stringArray[j]=Char.ToLower(stringArray[j]);
                        }
                        subStrings[i] = new string(stringArray);
                    }                
            }

            string titleString = string.Join(" ", subStrings);
            return titleString;
        }

        public void UnitTestCases()
        {
            CaseConversion caseObj = new CaseConversion();
            string userString;

            string[] outputArray = caseObj.TakeInputStrings(out userString);

            string camelString = caseObj.ConvertToCamelCase(outputArray);
            Console.WriteLine("String in camelCase: {0}", camelString);

            string titleStringDefault = caseObj.ConvertToTitleDefault(userString);
            Console.WriteLine("String in Title Case using in-built function: {0}", titleStringDefault);

            string titleString = caseObj.ConvertToTitleCase(outputArray);
            Console.WriteLine("String in Title Case: {0}", titleString);
        }

    }
}

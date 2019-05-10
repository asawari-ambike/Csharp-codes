using System;

namespace Assignments
{
    public class StringWords
    {
        public int GetCount(string[] inputArray)
        {
            int numberOfWords = inputArray.Length;
            return numberOfWords;
        }

        public void CountNumberOfWords()
        {
            StringWords wordObj = new StringWords();
            CaseConversion caseObj = new CaseConversion();

            string userString;

            string[] outputArray = caseObj.TakeInputStrings(out userString);
            int numberOfWords = wordObj.GetCount(outputArray);

            Console.WriteLine("Number of words in your string \'{0}\' are: {1}", userString, numberOfWords);
        }
    }
}
using System;

namespace Assignments
{
    public class DistinctWords
    {
        public int GetDistinctCount(string[] inputArray)
        {
            int numberOfWords = inputArray.Length;
            string compare;
            int distinctCount = 0, duplicateCount = 0;

            for(int i=0; i<numberOfWords; i++)
            {
                compare = inputArray[i];
                for(int j=i; j<numberOfWords; j++)
                {
                    if(i!=j)
                    {
                        if(compare == inputArray[j])
                        {
                            duplicateCount++;
                            break;                        
                        }
                    }
                }
            }

            distinctCount = numberOfWords - duplicateCount;
            return distinctCount;
        }

        public void CountNumberOfDistinctWords()
        {
            DistinctWords dWordObj = new DistinctWords();
            CaseConversion caseObj = new CaseConversion();

            string userString;

            string[] outputArray = caseObj.TakeInputStrings(out userString);
            int distinctCount = dWordObj.GetDistinctCount(outputArray);

            Console.WriteLine("Number of distinct words in your array \'{0}\' are: {1}", userString, distinctCount);            
        }
    }
}
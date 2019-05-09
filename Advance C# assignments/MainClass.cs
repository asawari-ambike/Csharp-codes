using System;

namespace Advance_C__assignments
{
    class MainClass
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Assignment 1: Camel case and title case");
            CaseConversion caseObj = new CaseConversion();
            caseObj.UnitTestCases();

            Console.WriteLine("Assignment 2: No. of words in string");
            StringWords wordObj = new StringWords();
            wordObj.CountNumberOfWords();
            
            Console.WriteLine("Assignment 3: No. of distinct words in string");
            DistinctWords dWordObj = new DistinctWords();
            dWordObj.CountNumberOfDistinctWords();

            Console.WriteLine("Assignment 4: 2nd max no.");
            MaxNum maxObj = new MaxNum();
            maxObj.FindSecondMax();

            Console.WriteLine("Assignment 5: Using Delegate");
            UsingDelegate delObj = new UsingDelegate();
            delObj.DelegateUse();

            Console.WriteLine("Assignment 6: Simple interest calculation");
            SimpleInterest interestObj = new SimpleInterest();
            interestObj.SimpleInterestCalculation();

            

            
        }
    }
}

using NUnit.Framework;
using Assignments;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Assignment1()
        {
            Console.WriteLine("Assignment 1: Camel case and title case");
            CaseConversion caseObj = new CaseConversion();
            caseObj.UnitTestCases();
        }

        [Test]
        public void Assignment2()
        {
            Console.WriteLine("Assignment 2: No. of words in string");
            StringWords wordObj = new StringWords();
            wordObj.CountNumberOfWords();
        }

        [Test]
        public void Assignment3()
        {
            Console.WriteLine("Assignment 3: No. of distinct words in string");
            DistinctWords dWordObj = new DistinctWords();
            dWordObj.CountNumberOfDistinctWords();
        }

        [Test]
        public void Assignment4()
        {
            Console.WriteLine("Assignment 4: 2nd max no.");
            MaxNum maxObj = new MaxNum();
            maxObj.FindSecondMax();
        }

        [Test]
        public void Assignment5()
        {
            Console.WriteLine("Assignment 5: Using Delegate");
            UsingDelegate delObj = new UsingDelegate();
            delObj.DelegateUse();
        }

        [Test]
        public void Assignment6()
        {
            Console.WriteLine("Assignment 6: Simple interest calculation");
            SimpleInterest interestObj = new SimpleInterest();
            interestObj.SimpleInterestCalculation();
        }
    }
}
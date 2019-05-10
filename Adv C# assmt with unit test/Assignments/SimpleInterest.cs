using System;

namespace Assignments
{
    interface ISimpleInterestElements
    {
        void AcceptInterestElements();
        double CalculateInterest();
    }

    public class SimpleInterest : ISimpleInterestElements
    {
        private int principleAmount;
        private double rateOfInterest, tenureTime;

        public SimpleInterest()
        {            
        }

        public SimpleInterest(int P, double N, double R)
        {
            this.principleAmount = P;
            this.tenureTime = N;
            this.rateOfInterest = R;
        }

        public void AcceptInterestElements()
        {
            int months, years, days;

            Console.WriteLine("Enter the Principle amount:");
            this.principleAmount = Convert.ToInt32("50000");

            Console.WriteLine("Enter the rate of interest per annum:");
            this.rateOfInterest = Convert.ToDouble("7.25");

            Console.WriteLine("Enter the tenure time:");
            Console.WriteLine("Years:");
            years = Convert.ToInt32("3");
            Console.WriteLine("Months:");
            months = Convert.ToInt32("3");
            Console.WriteLine("Days:");
            days = Convert.ToInt32("3");

            this.tenureTime = (years + ((double)months/12) + ((double)days/365));            
        }

        public double CalculateInterest()
        {
            double interestAmount = principleAmount * tenureTime * rateOfInterest / 100;
            return interestAmount;
        }

        public void SimpleInterestCalculation()
        {
            SimpleInterest fixInterestObj = new SimpleInterest(10000, 2.5, 6.75);
            SimpleInterest interestObj = new SimpleInterest();

            Console.WriteLine("Fixed Simple Interest is:");
            double simpleInterestFixed = fixInterestObj.CalculateInterest();
            Console.WriteLine(simpleInterestFixed);

            Console.WriteLine("To Calculate Interest for your input:");
            interestObj.AcceptInterestElements();
            double simpleInterestAmount = interestObj.CalculateInterest();
            Console.WriteLine("Your Simple Interest is:");
            Console.WriteLine(Math.Round((double)simpleInterestAmount, 2));
        }
    }
}
using System;

namespace Advance_C__assignments
{
    interface ISimpleInterestElements
    {
        void AcceptInterestElements();
        double CalculateInterest();
    }

    class SimpleInterest : ISimpleInterestElements
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
            this.principleAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest per annum:");
            this.rateOfInterest = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the tenure time:");
            Console.WriteLine("Years:");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Months:");
            months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Days:");
            days = Convert.ToInt32(Console.ReadLine());

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
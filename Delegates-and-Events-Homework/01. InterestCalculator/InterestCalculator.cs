namespace _01.InterestCalculator
{
    using System;

    public delegate decimal CalculateInterest(decimal amount, double interest, int years);

    public class InterestCalculator
    {
        private decimal amount;
        private double interest;
        private int years;
        private CalculateInterest calculateInterest;

        public InterestCalculator(decimal amount, double interest, int years, CalculateInterest calculateInterest)
        {
            this.Amount = amount;
            this.Interest = interest;
            this.Years = years;
            this.CalculateInterest = calculateInterest;
        }

        public decimal Amount
        {
            get { return this.amount; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Amount can't be negative!");
                }

                this.amount = value;
            }
        }

        public double Interest
        {
            get { return this.interest; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest can't be negative!");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get { return this.years; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Years can't be negative!");
                }

                this.years = value;
            }
        }

        public CalculateInterest CalculateInterest
        {
            get { return this.calculateInterest; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("calculateInterest", "calculateInterest can't be null!");
                }

                this.calculateInterest = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0:F4}", this.CalculateInterest(this.amount, this.interest, this.years));
        }
    }
}
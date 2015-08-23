using System;

namespace _02.HumanStudentAndWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private ushort workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, ushort workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("weekSalary", "Week salary can't be null!");
                }
                this.weekSalary = value;
            }
        }

        public ushort WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("workHoursPerDay", "Work hours per day can't be null!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}; Money Per Hour: {2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
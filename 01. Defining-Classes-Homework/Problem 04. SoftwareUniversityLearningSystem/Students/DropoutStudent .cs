using System;

namespace _04.SoftwareUniversityLearningSystem.Students
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public string DropoutReason
        {
            get { return this.dropoutReason; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Dropout reason must not be empty!");
                }
                this.dropoutReason = value;
            }
        }

        public DropoutStudent(string firstName, string lastName, short age, 
            int studentNumber, short averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public void Reapply()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Student number: " + StudentNumber);
            Console.WriteLine("Average grade: " + AverageGrade);
            Console.WriteLine("Dropout reason: " + DropoutReason);
        }
    }
}
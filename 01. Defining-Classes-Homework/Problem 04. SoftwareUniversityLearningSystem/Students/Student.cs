using System;

namespace _04.SoftwareUniversityLearningSystem.Students
{
    class Student : Person
    {
        private int studentNumber;
        private short averageGrade;

        public int StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Student number must be a positive number!");
                }
                this.studentNumber = value;
            }
        }

        public short AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Average grade must be a positive number!");
                }
                this.averageGrade = value;
            }
        }

        public Student(string firstName, string lastName, short age, int studentNumber, short averageGrade) 
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }
    }
}
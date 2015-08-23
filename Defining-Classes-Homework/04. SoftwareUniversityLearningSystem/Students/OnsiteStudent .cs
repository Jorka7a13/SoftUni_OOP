using System;

namespace _04.SoftwareUniversityLearningSystem.Students
{
    class OnsiteStudent : CurrentStudent
    {
        private short numberOfVisits;

        public short NumberOfVisits
        {
            get { return this.numberOfVisits; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of visits must be a positive number!");
                }
                this.numberOfVisits = value;
            }
        }

        public OnsiteStudent(string firstName, string lastName, short age, 
            int studentNumber, short averageGrade, string currentCourse, short numberOfVisits) 
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}\nAge: {2}\nStudent number: {3}\n" +
                                 "Average grade: {4}\nCurrent course: {5}\nNumber of visits: {6}", 
                                 FirstName, LastName, Age, StudentNumber, AverageGrade, CurrentCourse, NumberOfVisits);
        }
    }
}
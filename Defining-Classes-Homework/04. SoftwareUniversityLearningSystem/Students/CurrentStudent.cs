using System;

namespace _04.SoftwareUniversityLearningSystem.Students
{
    class CurrentStudent : Student
    {
        private string currentCourse;

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Current course must not be empty!");
                }
                this.currentCourse = value;
            }
        }

        public CurrentStudent(string firstName, string lastName, short age, 
            int studentNumber, short averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}\nAge: {2}\nStudent number: {3}\n" +
                                 "Average grade: {4}\nCurrent course: {5}",
                                 FirstName, LastName, Age, StudentNumber, AverageGrade, CurrentCourse);
        }
    }
}
using System;

namespace _04.SoftwareUniversityLearningSystem.Students
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, short age,
            int studentNumber, short averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}\nAge: {2}\nStudent number: {3}\n" +
                                 "Average grade: {4}\nCurrent course: {5}",
                                 FirstName, LastName, Age, StudentNumber, AverageGrade, CurrentCourse);
        }
    }
}
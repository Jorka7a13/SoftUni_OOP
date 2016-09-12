using System;

namespace _04.SoftwareUniversityLearningSystem.Trainers
{
    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, short age) : base(firstName, lastName, age)
        {
        }

        void CreateCourse(string courseName)
        {
            Console.WriteLine("A new course \"" + courseName + "\" has been created.");
        }
    }
}
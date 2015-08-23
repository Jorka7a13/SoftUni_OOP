using System;

namespace _04.SoftwareUniversityLearningSystem.Trainers
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, short age) : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("The course \"" + courseName + "\" has been deleted.");
        }
    }
}
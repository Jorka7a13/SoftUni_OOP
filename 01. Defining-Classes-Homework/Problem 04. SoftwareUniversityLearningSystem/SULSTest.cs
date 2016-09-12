// Problem 4.** Software University Learning System

// Define a class Person and the classes Trainer, Student. There are two types of trainers – 
// Junior and Senior Trainer. There are three types of Students – Graduate, Current and Dropout Student. 
// There are two types of Current Students – Online and Onsite Student.

using System;
using System.Collections.Generic;
using System.Linq;
using _04.SoftwareUniversityLearningSystem.Trainers;
using _04.SoftwareUniversityLearningSystem.Students;

namespace _04.SoftwareUniversityLearningSystem
{
    class SULSTest
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>
            {
                new Person("Ivo", "Stoichkov", 23),
                new Person("Viara", "Stoyanova", 21),
                new Trainer("Jelezar", "Durvenosec", 28),
                new Student("Misho", "Mihov", 19, 2004032, 4),
                new Student("Monika", "Gruncharova", 20, 2004210, 5),
                new JuniorTrainer("Moni", "Stoilova", 22),
                new SeniorTrainer("Simeon", "Georgiev", 26),
                new GraduateStudent("Petur", "Ivanov", 31, 2002001, 6),
                new CurrentStudent("Misho", "Minkov", 23, 2004323, 6, "Beer brewing"),
                new DropoutStudent("Ivan", "Toshev", 27, 2004022, 3, "Ran out of hmel :/"),
                new OnlineStudent("Georgi", "Last Name", 21, 2003866, 6, "OOP"),
                new OnsiteStudent("Yana", "Konstantinova", 26, 2003897, 6, "How to suck at JS", 0)
            };

            var currentStudents =
                from person in persons
                where person is CurrentStudent
                select (CurrentStudent)person;

            currentStudents = currentStudents.OrderByDescending(st => st.AverageGrade);

            foreach (var currentStudent in currentStudents)
            {
                Console.WriteLine(currentStudent);
                Console.WriteLine();
            }
        }
    }
}

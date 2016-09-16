// Problem 2. Human, Student and Worker

// Initialize a list of 10 students and sort them by faculty number in ascending order (use LINQ or OrderBy() 
// extension method). Initialize a list of 10 workers and sort them by payment per hour in descending order.
// Merge the lists and then sort them by first name and last name.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HumanStudentAndWorker
{
    public class MainClass
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivo", "Nikolov", "FE931C3"),
                new Student("Georgi", "Manolov", "FE644IE"),
                new Student("Aleksandra", "Todorova", "FE72234SE"),
                new Student("Miroslav", "Balkin", "FE287234"),
                new Student("Monika", "Ruseva", "FJS44242A"),
                new Student("Mihail", "Grigorov", "FE3141592"),
                new Student("Barack", "Obama", "FE76692J2"),
                new Student("Ivan", "Simeonov", "AAAAAAA"),
                new Student("Grisho", "Petkov", "FE88MNB70"),
                new Student("Krasimira", "Ruseva", "FE980TA2")
            };

            var orderedStudents = students.OrderBy(student => student.FacultyNumber);
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Petur", "Stoilov", 40M, 8),
                new Worker("Jackie", "Chan", 50M, 6),
                new Worker("Misha", "Petkova", 45M, 4),
                new Worker("Ralitsa", "Stoilova", 20M, 9),
                new Worker("Ivan", "Rusev", 75M, 5),
                new Worker("Miroslav", "Grigorov", 33M, 7),
                new Worker("Stanislav", "Petrov", 120M, 12),
                new Worker("Redjina", "Krastavicharova", 150M, 8),
                new Worker("Koko", "Monef", 160M, 8),
                new Worker("Okok", "Fenom", 130M, 4)
            };

            var orderedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();

            List<Human> humans = new List<Human>()
            {
                new Student("Ivo", "Nikolov", "FE931C3"),
                new Student("Georgi", "Manolov", "FE644IE"),
                new Student("Aleksandra", "Todorova", "FE72234SE"),
                new Student("Miroslav", "Balkin", "FE287234"),
                new Student("Monika", "Ruseva", "FJS44242A"),
                new Student("Mihail", "Grigorov", "FE3141592"),
                new Student("Barack", "Obama", "FE76692J2"),
                new Student("Ivan", "Simeonov", "AAAAAAA"),
                new Student("Grisho", "Petkov", "FE88MNB70"),
                new Student("Krasimira", "Ruseva", "FE980TA2"),
                new Worker("Petur", "Stoilov", 40M, 8),
                new Worker("Jackie", "Chan", 50M, 6),
                new Worker("Misha", "Petkova", 45M, 4),
                new Worker("Ralitsa", "Stoilova", 20M, 9),
                new Worker("Ivan", "Rusev", 75M, 5),
                new Worker("Miroslav", "Grigorov", 33M, 7),
                new Worker("Stanislav", "Petrov", 120M, 12),
                new Worker("Redjina", "Krastavicharova", 150M, 8),
                new Worker("Koko", "Monef", 160M, 8),
                new Worker("Okok", "Fenom", 130M, 4)
            };

            var orderedHumans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
            foreach (var human in orderedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
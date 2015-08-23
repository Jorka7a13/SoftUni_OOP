using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Discipline : DetailedObject
    {
        private string name;
        private uint numberOfLectures;
        private List<Student> students;

        public Discipline(string name, uint numberOfLectures, List<Student> students, string details = null) : base(details)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name can't be null or empty!");
                }
                this.name = value;
            }
        }

        public uint NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("numberOfLectures", "Number of lectures can't be null!");
                }
                this.numberOfLectures = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("students", "Students can't be null or empty!");
                }
                this.students = value;
            }
        }
    }
}
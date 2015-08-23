// Problem 1. School

// Identify the classes (in terms of OOP) and their members, encapsulate their fields, 
// define the class hierarchy (inherit shared data and functionality) and create a class diagram with Visual Studio.

using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Class : DetailedObject
    {
        private string uniqueID;
        private List<Student> students; 
        private List<Teacher> teachers;

        public Class(string uniqueID, List<Student> students, List<Teacher> teachers, string details = null) : base(details)
        {
            this.UniqueID = uniqueID;
            this.Students = students;
            this.Teachers = teachers;
        }

        public string UniqueID
        {
            get { return this.uniqueID; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("uniqueID", "UniqueID can't be null or empty!");
                }
                this.uniqueID = value;
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

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("teachers", "Teachers can't be null or empty!");
                }
                this.teachers = value;
            }
        }
    }
}
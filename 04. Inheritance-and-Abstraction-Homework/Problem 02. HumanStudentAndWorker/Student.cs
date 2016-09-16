using System;

namespace _02.HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentNullException("facultyNumber", "Faculty number can't be null or empty, " +
                                                                     "and must be 5-10 digits/letters!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}; Faculty number: {2}", 
                this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
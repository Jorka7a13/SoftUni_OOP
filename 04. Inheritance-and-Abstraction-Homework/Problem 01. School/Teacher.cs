using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines, string details = null) : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set
            {
                if (disciplines == null || disciplines.Count == 0)
                {
                    throw new ArgumentNullException("disciplines", "Disciplines can't be null or empty!");
                }
                this.disciplines = value;
            }
        }
    }
}
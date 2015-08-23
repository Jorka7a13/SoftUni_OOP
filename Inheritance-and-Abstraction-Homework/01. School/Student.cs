using System;
using System.Data;

namespace _01.School
{
    public class Student : Person
    {
        private uint uniqueID;

        public Student(string name, uint uniqueID, string details = null) : base(name, details)
        {
            this.UniqueID = uniqueID;
        }

        public uint UniqueID
        {
            get { return this.uniqueID; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("uniqueID", "UniqueID can't be null!");
                }
                this.uniqueID = value;
            }
        }
    }
}
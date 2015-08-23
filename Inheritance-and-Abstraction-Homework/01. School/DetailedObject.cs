using System;

namespace _01.School
{
    public abstract class DetailedObject
    {
        private string details; // Optional field

        protected DetailedObject(string details = null)
        {
            this.Details = details;
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("details", "Details can't be empty!");
                }
                this.details = value;
            }
        }
    }
}
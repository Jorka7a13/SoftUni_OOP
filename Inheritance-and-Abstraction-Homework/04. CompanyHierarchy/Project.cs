using System;

namespace _04.CompanyHierarchy
{
    public class Project : IProject
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private bool isOpen;

        public Project(string projectName, DateTime startDate, string details)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.isOpen = true;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("projectName", "Project name can't be null or empty!");   
                }
                this.projectName = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("startDate", "Start date can't be null or empty!");  
                }
                this.startDate = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("details", "Details can't be null or empty!");
                }
                this.details = value;
            }
        }

        public bool IsOpen { get; set; }

        public void CloseProject()
        {
            if (!this.isOpen)
            {
                throw new Exception("Project is already closed!");
            }
            this.isOpen = false;
        }

        public override string ToString()
        {
            string result = String.Format("Project name: {0}, Start date: {1}, Details: {2}, State: ", 
                this.ProjectName, this.StartDate, this.Details);

            if (IsOpen)
            {
                result += "open";
            }
            else
            {
                result += "closed";
            }  

            return result;
        }
    }
}
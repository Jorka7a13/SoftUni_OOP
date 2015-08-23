// Problem 4.* HTML Dispatcher

// Write a class ElementBuilder that creates HTML elements.

using System;
using System.Collections.Generic;
using System.Text;

namespace _04.HTMLDispatcher
{
    class ElementBuilder
    {
        private string name;
        private Dictionary<string, string> attributes = new Dictionary<string, string>();
        private string content;

        public ElementBuilder(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must not be empty!");
                }
                this.name = value;
            }
        }

        public void AddAttribute(string attribute, string value)
        {
            attributes.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            if (String.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Content must not be empty!");
            }
            this.content = content;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<" + this.name);

            foreach (KeyValuePair<string, string> attribute in attributes)
            {
                sb.Append(String.Format(" {0}=\"{1}\"", attribute.Key, attribute.Value));
            }

            sb.Append(">" + this.content);
            sb.Append("</" + this.name + ">");

            return sb.ToString();
        }

        public static string operator *(ElementBuilder elem, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n must be a positive number!");
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(elem.ToString());
            }

            return sb.ToString();
        }
    }
}
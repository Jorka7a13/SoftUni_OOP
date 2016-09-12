//Problem 1. Persons

//Define a class Person that has name, age and email. The name and age are mandatory. 
//The email is optional. Define properties that accept non-empty name and age in the range [1...100]. 
//In case of invalid argument, throw an exception. Define a property for the email that accepts either null or non-empty 
//string containing '@'. Define two constructors. The first constructor should take name, age and email. 
//The second constructor should take name and age only and call the first constructor. 
//Implement the ToString() method to enable printing persons at the console.

using System;

class Persons
{
    class Person 
    { 
        private string name;
        private short age;
        private string email;

        public string Name {
            get 
            {
                return name;    
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public short Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("age", "Age must be in the range [1..100]");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Email should be null or contain '@'!");
                }
                this.email = value;
            }
        }

        public Person(string name, short age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, short age) : this(name, age, null)
        {
        }

        public override string ToString()
        {
            string result = String.Format("Name: {0}, Age: {1}", this.Name, this.Age);

            if (this.Email != null)
            {
                result += ", Email: " + this.Email;
            }

            return result;
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            Person person1 = new Person("Ivan", 21);
            Console.WriteLine(person1);

            Person person2 = new Person("Vasil", 25, "asd@asd.as");
            Console.WriteLine(person2);

            //Person invalidNamePerson = new Person(" ", 21);
            //Console.WriteLine(invalidNamePerson);

            //Person invalidAgePerson = new Person("Vasil", 250, "asd@asd.as");
            //Console.WriteLine(invalidAgePerson);

            //Person invalidEmailPerson = new Person("Vasil", 25, "asdasd.as");
            //Console.WriteLine(invalidEmailPerson);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCAdvance.Entities
{
    public class Student
    {
        private string id = string.Empty;
        private string name = string.Empty;
        private int age;
        private string address = string.Empty;
        private DateTime dob;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public Student()
        {
        }

        public Student(string id, string name, int age, string address, DateTime dob)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Invalid input parameters: id cannot be null or empty.");
            }

            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.dob = dob;
        }
    }
}


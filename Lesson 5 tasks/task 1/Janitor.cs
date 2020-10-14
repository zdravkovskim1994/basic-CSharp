using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Janitor : Person
    {
        public Janitor(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public string Clean()
        {
            return "I'm cleaning";

        }
        public override string Introduce()
        {
            string introduction = $"I am {firstName} {lastName}. I am {age} years old. I am cleaning at university.";
            return introduction;
        }
    }
}

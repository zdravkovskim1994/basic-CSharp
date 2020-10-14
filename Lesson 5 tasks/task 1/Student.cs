using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Student : Person
    {
        public Student(string firstName,string lastName,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string Learn()
        {
            return "I'm learning";
        }

        public override string Introduce()
        {
            string introduction = $"I am {firstName} {lastName}. I am {age} years old. I am learning new things at university.";
            return introduction;
        }
    }
}

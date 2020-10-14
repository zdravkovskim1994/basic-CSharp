using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Teacher : Person
    {
        public string subject;
        public string Subject { get; set; }

        public Teacher(string firstName, string lastName, int age, string subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.subject = subject;
        }
        public string Teach()
        {
            return "I’m teaching " + subject;
        }
        public override string Introduce()
        {
            string introduction;
            introduction = $"I'm {firstName} {lastName}. I'm {age} years old. I'm teaching the student " + Teach() + ".";
            return introduction;
        }
        







    }
}

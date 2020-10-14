using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Student
    {
        int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void GoToClasses()
        {
            Console.WriteLine("I'm goint to calss");
        }
        public void SetAge(int n)
        {
            age = n;
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: " + age + " years old");
        }
    }
}

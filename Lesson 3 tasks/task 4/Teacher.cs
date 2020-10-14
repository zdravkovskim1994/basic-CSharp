using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Teacher
    {
        string subject;
        int age;

        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
        public void SetAge(int n)
        {
            Console.WriteLine("My age is: " + n + " years old");
            
        }
    }
}

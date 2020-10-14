using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHello();

            Student student = new Student();
            student.Greet();
            student.SetAge(21);
            student.ShowAge();
            student.GoToClasses();
            
            
            

            Teacher teacher = new Teacher();

            teacher.Greet();
            teacher.SetAge(30);
            teacher.Explain();


            Console.ReadLine();
        }

    }
}

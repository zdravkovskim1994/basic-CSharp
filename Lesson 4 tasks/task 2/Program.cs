using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Name = "Mario Zdravkovski",
                    Age = 25
                },
                new Student
                {
                    Name = "Kristijan Zdravkovski",
                    Age = 29
                },
                new Student
                {
                    Name = "Trajko Trajkovski",
                    Age = 30
                }
            };
            Console.WriteLine("Press enter!");
            Console.ReadLine();

            foreach(var item in students)
            {
                Console.WriteLine("Name: " + item.Name +"   " + "Age: " + item.Age);
            }

            Console.ReadLine();
        }
    }
}

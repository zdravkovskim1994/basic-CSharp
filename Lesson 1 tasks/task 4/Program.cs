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
            String studentName = "Mario Zdravkovski";
            int studentId = 236;
            int age = 25;
            String universityName = "FIKT";

            Console.WriteLine("Imeto e " + studentName + " broj na index " 
                + studentId + " broj na godini " + age + " vo fakultet " + universityName);

            Console.ReadLine();
        }
    }
}

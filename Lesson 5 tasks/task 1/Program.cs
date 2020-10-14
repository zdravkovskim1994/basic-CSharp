using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1 Teacher\n2 Student\n3 Janitor");
                int selection = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Please enter last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Please enter age");

                const int maxAge = 99;
                int age = 0;
                if (!int.TryParse(Console.ReadLine(), out age) || age <= 0 || age > maxAge )
                {
                    Console.WriteLine("Invalid age");
                    continue;
                }
              
                Person person = null;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Etner teaching subject.");
                        string subject = Console.ReadLine();
                        person = new Teacher(firstName, lastName, age, subject);
                        break;
                    case 2:
                        person = new Student(firstName, lastName, age);
                        break;
                    case 3:
                        person = new Janitor(firstName, lastName, age);
                        break;
                }
                Console.WriteLine(person.Introduce());

                Console.ReadLine();

                
            } while (Console.ReadLine() != "n");
        }
    }
}

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
            Employee developer = new Employee(Positions.Developer, "John Doe")
            {
                Salary = 15000,
                YearOfExperiance = 10
            };
            if (developer.Promote(Positions.TeamLeader) && developer.Position == Positions.TeamLeader)
            {
                Console.WriteLine("Developer was promoted to Team Leader!");               
            }
            Manager manager = new Manager(Positions.ProductManager, "Jane Doe");
            manager.Salary = 30000;

            if (!manager.Promote(Positions.Owner) && manager.Position == Positions.ProductManager)
            {
                Console.WriteLine("Product manager cannot be promoted to Owner!");
            }

            Console.ReadLine();
        }
    }
}

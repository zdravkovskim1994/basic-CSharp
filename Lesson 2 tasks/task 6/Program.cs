using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your proffesion:\n");

            string drinks = Console.ReadLine();

            switch (drinks)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;

                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffe");
                    break;

                case "SoftUni Student":
                    Console.WriteLine("Bear");
                    break;

                default:
                    Console.WriteLine("Tea");
                    break;
            }
            Console.ReadLine();
        }
    }
}
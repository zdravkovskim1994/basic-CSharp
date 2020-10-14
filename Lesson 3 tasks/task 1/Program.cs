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

                Calculate calculate = new Calculate();

                Console.Write("Enter the first number: ");
                calculate.FirstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                calculate.SecondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n----------------------------------------");

                Console.WriteLine("1.Add\n" + "2.Subtract\n" + "3.Multiply\n" + "4.Division\n");
                int menu = Convert.ToInt32(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Result: " + calculate.Add());
                        break;
                    case 2:
                        Console.WriteLine("Result: " + calculate.Subtract());
                        break;
                    case 3:
                        Console.WriteLine("Result: " + calculate.Multiply());
                        break;
                    case 4:
                        if(calculate.SecondNumber > 0) { 
                        Console.WriteLine("Result: " + calculate.Division());
                        }
                        else
                        {
                            Console.WriteLine("Can't divide with zero");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid number!");
                        break;
                }


                Console.WriteLine("Continue y/n");
            } while (Console.ReadLine() != "n");
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Etner the number of the mounth");
                int mounths = int.Parse(Console.ReadLine());

                switch ((Month)mounths)
                {
                    case Month.January:
                    case Month.February:
                        Console.WriteLine("Winter");
                        break;
                    case Month.March:
                    case Month.April:
                    case Month.May:
                        Console.WriteLine("Spring");
                        break;
                    case Month.June:
                    case Month.July:
                    case Month.August:
                        Console.WriteLine("Summer");
                        break;
                    case Month.September:
                    case Month.October:
                    case Month.November:
                        Console.WriteLine("Fall");
                        break;
                    case Month.December:
                        Console.WriteLine("Winter");
                        break;
                    default:
                        Console.WriteLine("Invalid months");
                        break;
                }
                Console.WriteLine("Continue y/n");
            } while (Console.ReadLine() != "n");
        }
    }
}


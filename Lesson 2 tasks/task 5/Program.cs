using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product of first 10 natural numbers!");

            int i;
            int pro = 1;

            for (i = 1; i <= 10; i++)
            {
                pro = pro * i;
                Console.WriteLine(i);
            }

            Console.WriteLine("\nThe product is: {0}\n", pro);
            Console.ReadLine();
        }
    }
}

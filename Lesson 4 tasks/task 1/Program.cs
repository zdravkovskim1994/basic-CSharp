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
            int i, n;
            int sum = 0;

            Console.Write("Vnesi:  ");
            n = int.Parse(Console.ReadLine());

            for(i = 1;i <= n; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }

            Console.WriteLine("Sum: {0}",sum);

            Console.ReadLine();
        }
    }
}

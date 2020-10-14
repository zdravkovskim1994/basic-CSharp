using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double broj1, broj2, ostatok;
            Console.WriteLine("Vnesi broj shto sakash da go delish: ");
            broj1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Go delish so brojot: ");
            broj2 = Convert.ToDouble(Console.ReadLine());

            ostatok = broj1 % broj2;
            Console.WriteLine("Ostatokot e " + ostatok);
            Console.ReadLine();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, side;
            Console.WriteLine("Enter the side: ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;

            Console.WriteLine("Area of a square: " + "\n" + area);


            Console.ReadLine();
        }
    }
}

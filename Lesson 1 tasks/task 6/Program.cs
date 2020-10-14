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
            
            double radius, perimetar;
            const double pi = 3.14159;
            
            //Vnes na radius
            Console.WriteLine("Enter the radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            //Formula za perimetar (L=2rP)
            perimetar = (2 * radius * pi);

            //Pecati perimetar
            Console.WriteLine("Perimetar: " + perimetar);

            Console.ReadLine();
        }
    }
}

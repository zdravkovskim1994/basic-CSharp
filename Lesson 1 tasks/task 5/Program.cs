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
            double length, width, area;
            
            // Vnes na dolzhina
            Console.WriteLine("Enter the length: ");
            length = Convert.ToInt32(Console.ReadLine());

            // Vnes na shirina
            Console.WriteLine("Enter the width: ");
            width = Convert.ToInt32(Console.ReadLine());
            
            //Formula za area
            area = length * width;
            
            //Pecati area
            Console.WriteLine("Area of rectangle: " + area);
            Console.ReadLine();

        }
    }
}

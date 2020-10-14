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
            Console.WriteLine("Enter the width of the table");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the table");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the lenght of the table");
            double lenght = Convert.ToDouble(Console.ReadLine());

            Table table = new Table(width,height,lenght);

            Console.WriteLine(table.ShowData());
            Console.ReadLine();

        }
    }
}

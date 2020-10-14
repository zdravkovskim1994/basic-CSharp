using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, swap;
            
            Console.WriteLine("Vnesi broj za a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vnesi broj za b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vrednosta na a:{0} i vrednosta na b:{1}", a,b);

            swap = a;
            a = b;
            b = swap;

           
            Console.WriteLine("Swap broevite za a:{0} i za b:{1}", a,b);
            Console.ReadLine(); 
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            if(number == 0)
            {
                Console.WriteLine("Number is zero");
            }
            else if(number > 0){
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

            Console.ReadLine();
            
        }
    }
}

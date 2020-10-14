using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.WriteLine("Enter a first number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a third number:");
            number3 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2 && number1 > number3)
            {
                Console.WriteLine("First number is largest!");
            }else if(number2 > number1 && number2 > number3)
            {
                Console.WriteLine("Second number is largest!");
            }
            else
            {
                Console.WriteLine("Third number is largest!");
            }

            Console.ReadLine();
            
        }
    }
}

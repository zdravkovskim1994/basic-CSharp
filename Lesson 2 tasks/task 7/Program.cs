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
            int number1, number2, number3, temp;

            Console.WriteLine("Enter a first number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a third number:");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
            }
            if (number1 > number3)
            {
                temp = number1;
                number1 = number3;
                number3 = temp;
            }
            if (number2 > number3)
            {
                temp = number2;
                number2 = number3;
                number3 = temp;
            }
           
            Console.WriteLine($"The ordered numbers are {number1}, {number2} and {number3}");
            Console.ReadLine();

        }
    }
}

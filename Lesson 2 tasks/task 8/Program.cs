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
            int number1, number2, pro;

            Console.WriteLine("Enter the frist number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
                      
            //Neznam na kakov podrug nachin da ja resham
            if (number1 > 0 & number2 > 0)
            {
                pro = number1 * number2;
                Console.WriteLine(pro);
                
            }else
            {
                Console.WriteLine("Invalid");
                
            }
            Console.ReadLine();
        }
        
    }
}

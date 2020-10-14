using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calculator = new TaxCalculator();
            
            Console.WriteLine("Enter the amount: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the tax: ");
            double tax1 = Convert.ToDouble(Console.ReadLine());

            calculator.Tax = tax1;

            double result = calculator.ApllyTax(salary);

            Console.WriteLine("Amount with applied tax is: " + result);

            Console.ReadLine();
        }
    }
}

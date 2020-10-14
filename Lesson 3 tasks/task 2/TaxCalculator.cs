using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class TaxCalculator
    {        
        private double tax;

        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Invalid tax!");
                }
                else
                {
                    tax = value;
                }
            }

        }

        public double ApllyTax(double amount)
        {
            amount = amount - (amount * tax / 100);
            return amount;
            
        }

    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Aww..");
        }
    }
}

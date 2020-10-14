using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IAnimal[] animals = new IAnimal[3];
            animals[0] = new Dog();
            animals[1] = new Cat();
            animals[2] = new Cow();

            Console.WriteLine("Choose an animal !");
            Console.WriteLine("Dog\nCat\nCow");
            Console.WriteLine("-----------------");

            string menu = Convert.ToString(Console.ReadLine());

            switch (menu)
            {
                case "Dog":
                case "dog":
                    animals[0].Sound();                    
                    break;
                case "Cat":
                case "cat":
                    animals[1].Sound();
                    break;
                case "Cow":
                case "cow":
                    animals[2].Sound();
                    break;
            }
            Console.ReadLine();
        }
    }
}

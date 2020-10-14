using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
   public abstract class Person
    {
        protected int age;
        protected string firstName;
        protected string lastName;
        

        public string FirstName
        {
            get
            {
                return FirstName;
            }
                        
        }
        public string LastName
        {
            get
            {
                return LastName;
            }
        }
        public int Age
        {
            get
            {
                return Age;
            }
            
        }
        public abstract string Introduce();





    }
}

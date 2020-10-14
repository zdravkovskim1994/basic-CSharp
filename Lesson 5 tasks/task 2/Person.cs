using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public abstract class Person
    {
        protected Positions position;

        public Positions Position
        {
            get
            {
                return position;
            }
           private set { }
        }
        
        public string Name { get; private set; }
        public int Salary { get; set; }
        public int YearOfExperiance { get; set; }

        public Person(Positions position, string name)
        {
            this.position = position;
            this.Name = name;
        }

    }
}

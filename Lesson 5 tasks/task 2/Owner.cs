using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Owner : Person
    {
        private int yearFoundedCompany { get; set; }
        public Owner(Positions position, string name, int yearFoundedCompany) : base (position,name)
        {
            this.yearFoundedCompany = yearFoundedCompany;
        }
    }
}

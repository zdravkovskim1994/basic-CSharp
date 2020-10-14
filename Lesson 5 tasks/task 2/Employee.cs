using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Employee : Person, IPromotable
    {
        public bool Promote(Positions newPosition)
        {
            bool success = false;

            if(this.position == Positions.Developer && newPosition == Positions.TeamLeader)
            {
                this.position = newPosition;
                success = true;
            }
            return success;
        }
        public Employee(Positions position, string name) : base(position, name) { }
    }
}

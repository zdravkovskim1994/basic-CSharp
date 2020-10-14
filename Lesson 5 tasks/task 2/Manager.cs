using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Manager : Person,IPromotable
    {
        public bool Promote(Positions newPosition)
        {
            bool success = false;

            if (this.position == Positions.ProjectManager && newPosition == Positions.ProductManager)
            {
                this.position = newPosition;
                success = true;
            }
            return success;
        }
        public Manager(Positions position, string name) : base(position, name) { }
    }
}

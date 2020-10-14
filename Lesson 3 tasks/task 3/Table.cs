using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Table
    {
        double width, height, length;

        public Table(double width, double height, double length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }

        public string ShowData()
        {
            return $"Width: {width}, Height: {height}, Length: {length}";
        }
    }
}

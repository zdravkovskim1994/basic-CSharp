using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Calculate
    {
        int firstNumber, secondNumber;

        public int FirstNumber  
        {
            get
            {
                return firstNumber;
            }
            set
            {
                firstNumber = value;
            }
        }
        public int SecondNumber
        {
            get
            {
                return secondNumber;
            }
            set
            {
                secondNumber = value;
            }
        }

        public int Add()
        {
            return firstNumber + secondNumber;
        }

        public int Subtract()
        {
            return firstNumber - secondNumber;
        }

        public int Multiply()
        {
            return firstNumber * secondNumber;
        }

        public int Division()
        {
            return firstNumber / secondNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public float Dividy(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("Pamiętaj cholero, nie dziel przez 0!");

            return x / (float)y;
        }

        public float Modulo(int x, int y)
        {
            return x % (float)y;
        }
    }
}

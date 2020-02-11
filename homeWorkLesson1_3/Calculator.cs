using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson1_3
{
    class Calculator<T1, T2>
    {
        public double Add (T1 argument1, T2 argument2)
        {
            return Convert.ToDouble(argument1) + Convert.ToDouble(argument2);
        }
        public double Sub(T1 argument1, T2 argument2)
        {
            return Convert.ToDouble(argument1) - Convert.ToDouble(argument2);
        }
        public double Mult(T1 argument1, T2 argument2)
        {
            return Convert.ToDouble(argument1) * Convert.ToDouble(argument2);
        }
    }
}

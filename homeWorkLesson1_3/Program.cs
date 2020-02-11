using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int, int> calculator = new Calculator<int, int>();

            Console.WriteLine(calculator.Add(200, 15));

            Console.WriteLine(calculator.Sub(13, 121));

            Console.WriteLine(calculator.Mult(2, 15));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<int> book1 = new Book<int>();
            Book<string> book2 = new Book<string>();

            book1.Name = "Name";
            book1.Price = 100;
            book1.Show();

            book2.Name = "Name2";
            book2.Price = "110";
            book2.Show();

            Console.ReadKey();
        }
    }
}

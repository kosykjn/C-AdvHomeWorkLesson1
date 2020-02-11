using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson1_1
{
    class Book<T>
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private T price;
        public T Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Show()
        {
            Console.WriteLine($"Название книги: {Name} цена: {Price} грн.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson1_2
{
    static class MyClass<T> where T : new()
    {
        public static T Create()
        {
            return new T();
        }
    }
}

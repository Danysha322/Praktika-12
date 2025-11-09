using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class ObjectCounter
    {
        private static int _count = 0;

        public ObjectCounter()
        {
            _count++;
        }

        public static void DisplayCount()
        {
            Console.WriteLine($"Количество созданных объектов: {_count}");
        }
    }
}

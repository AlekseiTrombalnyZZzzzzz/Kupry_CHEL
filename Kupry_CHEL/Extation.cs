using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupry_CHEL
{
    static class Extation
    {
        public static T[] Print(this T[] array)
        {
            foreach (var item in array)
                Console.Write(item + "\t");
            Console.WriteLine();
            return array;
        }
        public static T Print<T>(this T obj)
        {
                Console.WriteLine(obj);
                return obj;
        }
    }
}

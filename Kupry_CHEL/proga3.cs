using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupry_CHEL
{
    static class proga3
    {
        public static void main()
        {
            int x = 2;
            int y = 5;
            Square(x, y).Print();
        }
        static int Square(int a, int b)
        {
            int s = a * b;
            return s;
        }
    }
}

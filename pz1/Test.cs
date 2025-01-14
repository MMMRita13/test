using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz1
{
    public class Test
    {
        public int if1(int a, int b)
        {
            if (a == b)
            {
                return a + b;
            }
            else
            {
                return a * b;
            }
        }

        public int if2(int a, int b)
        {
            if (a > b)
            {
                return a - b;
            }
            else
            {
                Console.WriteLine("Ошибка");
                return 0;
            }
        }

        public int if3(int a, int b)
        {
            if (a < b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        public int if4(int a, int b, int c)
        {
            if (a > c && a > b)
            {
                return a + b - c;
            }
            else
            {
                return a + c + b;
            }
        }

        public int if5(int a, int b, int c)
        {
            if ((a + b) > c)
            {
                return a + b - c;
            }
            else
            {
                return a - b + c;
            }
        }

        public int if6(int a, int b)
        {
            if (a > b)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }
    }
}

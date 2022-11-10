using System;
using System.Collections.Generic;
using System.Text;

namespace OneWeek.basic.basic6day.basic2
{
    class main
    {
        static void Main(string[] args)
        {
            Class2 c = new Class2();

            int a = 1, b = 2, d = 3;

            int ans1 = c.Add(a, b);
            int ans2 = c.Add(a, b, d);

            Console.WriteLine("{0} + {1} = {2}", a, b, ans1);
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, d, ans2);
        }
    }
}

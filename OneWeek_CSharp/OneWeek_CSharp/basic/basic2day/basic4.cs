
// キャストとデータの型変換を使用したコンソールへの表示方法.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic2day
{
    class basic4
    {
        static void Main(string[] args)
        {
            int a;
            double b, c, d;

            a = (int)1.23;
            b = 1.23;
            c = 10;
            d = (double)c;

            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);
        }
    }
}

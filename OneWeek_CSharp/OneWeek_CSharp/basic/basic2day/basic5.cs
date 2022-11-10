
// 文字列の変数を使用したコンソールへの表示方法とキーボードから入力された物をstirng型の変数に保存する方法.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic2day
{
    class basic5
    {
        static void Main(string[] args)
        {
            string str1, str2;

            Console.WriteLine("str1 = ");
            str1 = Console.ReadLine();

            Console.WriteLine("str2 = ");
            str2 = Console.ReadLine();

            Console.WriteLine("str1 + str2 = {0}", str1 + str2);
        }
    }
}

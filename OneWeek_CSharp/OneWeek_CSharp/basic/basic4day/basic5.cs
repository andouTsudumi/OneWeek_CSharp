using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic4day
{
    class basic5
    {
        static void Main()
        {
            int i, num;
            num = 1;

            Console.Write("whileで実行：");
            i = 1;
            while(i < num)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine();

            Console.Write("do～whileで実行：");
            i = 1;
            do
            {
                Console.WriteLine("*");
            } while (i < num);
        }
    }
}

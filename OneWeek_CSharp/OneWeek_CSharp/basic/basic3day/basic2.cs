﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic3day
{
    class basic2
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力：");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("a = " + a);

            if (a > 0)
            {
                Console.WriteLine("aは正の数です。");
            }
            else
            {
                Console.WriteLine("aは正の数ではありません。");
            }
        }
    }
}

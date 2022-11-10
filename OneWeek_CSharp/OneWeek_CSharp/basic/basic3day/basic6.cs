using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic3day
{
    class basic6
    {
        static void Main(string[] args)
        {
            Console.Write("さいころの目(1～6)：");

            int dice = int.Parse(Console.ReadLine());

            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("丁(チョウ)です。");
                    break;

                case 2:
                case 4:
                case 6:
                    Console.WriteLine("半(ハン)です。");
                    break;

                default:
                    Console.WriteLine("範囲外の数値です。");
                    break;
            }
        }
    }
}

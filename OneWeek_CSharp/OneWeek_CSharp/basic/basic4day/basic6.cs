using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic4day
{
    class basic6
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("6が出たら終了.");

            while(true)
            {
                int dice = rnd.Next(1, 7);
                Console.WriteLine(dice);
                if(dice == 6)
                {
                    break;
                }
            }
            Console.WriteLine("終了");
        }
    }
}

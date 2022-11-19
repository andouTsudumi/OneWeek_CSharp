using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek_CSharp.practical.practical1day._1_3
{
    class Dummy
    {
        // コンストラクタ.
        public Dummy()
        {
            Console.WriteLine("コンストラクタ");
        }

        // デストラクタ.
        ~Dummy()
        {
            Console.WriteLine("デストラクタ");//@@@
        }
    }
}

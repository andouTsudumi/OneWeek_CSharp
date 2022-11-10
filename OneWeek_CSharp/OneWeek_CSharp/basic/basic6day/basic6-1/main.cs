using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic6day.basic1
{
    class main
    {
        static void Main(string[] args)
        {
            Class1 c1, c2;
            
            // インスタンスを生成.
            c1 = new Class1();
            c2 = new Class1();

            c1.name = "ちんぽう";
            c1.age = 19;

            c2.SetAgeAndName("栗とリス", 23);

            c1.ShowAgeAndName();
            c2.ShowAgeAndName();
        }
    }
}

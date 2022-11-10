using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic7day.basic7_3
{
    class main
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();

            p.SetAgeAndName("おちんぽ", 26);

            p.Age = 32;
            //p.Name = 36;

            Console.WriteLine("名前：{0}、年齢：{1}", p.Name, p.Age);
        }
    }
}

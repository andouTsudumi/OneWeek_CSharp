using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic7day.basic7_1
{
    class main
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();

            p1.Name = "かり";
            p1.Age = 19;

            p2.SetAgeAndName("kuritorisu", 23);

            p1.ShowAgeAndName();
            Console.WriteLine("名前：{0}、年齢：{1}", p2.Name, p2.Age);
        }
    }
}

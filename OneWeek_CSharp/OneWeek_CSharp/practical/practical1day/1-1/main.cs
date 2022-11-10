using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.practical.practical1
{
    class main
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person("はとぽっぽ",29);

            p1.Name = "おちんぽっぽ";
            p1.Age = 18;

            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}

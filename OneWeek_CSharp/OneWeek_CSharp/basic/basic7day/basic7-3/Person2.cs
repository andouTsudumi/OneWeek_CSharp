using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic7day.basic7_3
{
    class Person2
    {
        public void SetAgeAndName(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            private set;get;
        }

        public int Age
        {
            set;get;
        }
    }
}

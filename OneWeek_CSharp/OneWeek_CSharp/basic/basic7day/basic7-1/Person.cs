using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic7day.basic7_1
{
    class Person
    {
        private string name = "";
        private int age = 0;

        public void SetAgeAndName(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowAgeAndName()
        {
            Console.WriteLine("名前：{0}、年齢：{1}", this.name, this.age);
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }
    }
}

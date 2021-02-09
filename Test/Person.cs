using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Person : ICustomCompare, IChineseGreeting, IAmericanGreeting
    {
        public int Age { get; set; }

        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            Person otherp = (Person)value;
            if (this.Age < otherp.Age)
            {
                return -1;
            }
            if (this.Age > otherp.Age)
            {
                return 1;
            }

            return 0;
        }

        void IChineseGreeting.SayHello()
        {
            Console.WriteLine("你好");
        }

        void IAmericanGreeting.SayHello()
        {
            Console.WriteLine("hello");
        }
    }
}

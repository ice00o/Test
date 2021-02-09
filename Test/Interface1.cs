using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    interface ICustomCompare
    {
        int CompareTo(Object other);
    }

    interface IChineseGreeting
    {
        void SayHello();
    }
    interface IAmericanGreeting
    {
        void SayHello();
    }

}

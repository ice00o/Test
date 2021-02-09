using System;

namespace Test
{
    class Program
    {
        //接口 示例 
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //    Person P1 = new Person
        //    {
        //        Age = 18
        //    };
        //    Person P2 = new Person
        //    {
        //        Age = 19
        //    };
        //    if (P1.CompareTo(P2) > 0 )
        //    {
        //        Console.WriteLine("P1比P2大");
        //    }
        //    else if(P1.CompareTo(P2) < 0)
        //    {
        //        Console.WriteLine("P1比P2小");
        //    }
        //    else
        //    {
        //        Console.WriteLine("P1和P2一样大");
        //    }

        //    IChineseGreeting IChinsesG = (IChineseGreeting)P1;
        //    IChinsesG.SayHello();
        //    IAmericanGreeting IAmericanG = (IAmericanGreeting)P2;
        //    IAmericanG.SayHello();
        //    Console.Read();
        //}

        //委托 示例
        delegate void MyDelegate(int para1, int para2);
        static void Main(string[] args)
        {
            MyDelegate d;
            d = new MyDelegate(new Program().Add);
            MyMethod(d);
            Console.Read();

        }
        void Add(int para1, int para2)
        {
            int sum = para1 + para2;
            Console.WriteLine("两数之和为：" + sum);
        }
        private static void MyMethod(MyDelegate myDelegate)
        {
            myDelegate(1, 2);
        }
    }
}


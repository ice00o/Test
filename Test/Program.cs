using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person P1 = new Person();
            P1.Age = 18;
            Person P2 = new Person();
            P2.Age = 19;
            if(P1.CompareTo(P2) > 0 )
            {
                Console.WriteLine("P1比P2大");
            }
            else if(P1.CompareTo(P2) < 0)
            {
                Console.WriteLine("P1比P2小");
            }
            else
            {
                Console.WriteLine("P1和P2一样大");
            }
            Console.Read();
        }

    }
}


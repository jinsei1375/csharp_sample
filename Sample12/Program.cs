using System;
using Sample12;

namespace Sample12
{
    // デリゲート
    delegate void Operation(int a, int b);

    class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }

    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static void Func(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        static void Main(string[] arg)
        {
            Calc c = new();
            Operation o1 = new Operation(Add);
            Operation o2 = new Operation(c.Sub);
            o1 += new Operation(Func);
            o2 += new Operation(Func);
            o1(2, 1);
            o2(2, 1);
        }
    }

}


using System;
using Sample08;

namespace Sample08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.num1 = 19;
            c1.num2 = 10;
            c1.add();
            c1.sub();

            ExCalculator c2 = new();
            c2.num1 = 20;
            c2.num2 = 10;
            c2.add();
            c2.mul();
            c2.div();

            Calculator p = new Calculator();
            Calculator r = new ExCalculator();
            p.Foo();
            r.Foo();
        }
    }
}




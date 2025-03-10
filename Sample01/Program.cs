namespace csharp_sample;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(123);
        Console.WriteLine(456);

        Console.Write("ABC");
        Console.WriteLine("DEF");

        Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);
        Console.WriteLine("{0} ÷ {1} = {2} 余り {3}", 5, 2, 5 / 2, 5 % 2);

        int a = 6;
        int b = 3;
        int d = 10;
        double avg;
        int c  = 4;
        avg = (a + b + c) / 3.0;
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("{0} + {1} = {2}", a, c, a + c);
        Console.WriteLine("{0}と{1}と{2}の平均値は{3}", a, b, d, avg);
    }
}

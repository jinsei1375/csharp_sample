

using System;
using Sample09;

namespace Sample09
{
    public class Program
    {
        static void Main()
        {
            Crow c = new Crow();
            Sparrow s = new Sparrow();
            Console.Write(c.Name + " : ");
            c.Sing();
            Console.Write(s.Name + " : ");
            s.Sing();

            Bird[] d = new Bird[2];
            d[0] = new Crow();
            d[1] = new Sparrow();
            for(int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i].Name + " : ");
                d[i].Sing();
            }
        }
    }
}


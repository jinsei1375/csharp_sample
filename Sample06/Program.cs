

using System;
using Sample06;

namespace Sample06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("山田", 20);
            p1.name = "aaa";
            p1.ShowAgeAndName();

            String[] a = new string[10000];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new String('M', 10000);
            }
            Console.WriteLine("メモリ使用量（GC発動前）: " + GC.GetTotalMemory(false));
            a = null;
            Console.WriteLine("メモリ使用量（参照解除後）: " + GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("メモリ使用量（GC解除後）: " +  GC.GetTotalMemory(false));
        }
    }
}


using System;
namespace Sample07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Data[] d = new Data[2];
            Data.ShowNumber();
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = new Data(i * 100);
                Data.ShowNumber();
            }
        }
    }
}
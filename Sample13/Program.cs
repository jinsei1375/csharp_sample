using System;
using Sample13;

namespace Sample13
{
    class Program
    {
        public static void Main()
        {
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    int a = getNum(i);
                    int b = 2;
                    Console.Write(a + "/" + b + "=");
                    Console.WriteLine(calc(a, b));
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine();
                Console.WriteLine("0による割り算発生");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("配列範囲外");
            }
            finally
            {
                Console.WriteLine("終了");
            }

        }
        private static int calc(int a, int b)
        {
            return a / b;
        }
        private static int getNum(int index)
        {
            Console.WriteLine(index);
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            if (index >= nums.Length)
            {
                Console.WriteLine("例外スロー");
                throw new IndexOutOfRangeException();
            }
            return nums[index];
        }

    }
}
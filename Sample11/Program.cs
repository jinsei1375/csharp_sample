using System;
using System.Collections.Generic;
using Sample11;

namespace Sample11
{
    class Program
    {
        public static void Main()
        {
            List<int> a = new List<int>();
            a.Add(0);
            a.Add(2);
            a.Add(3);
            a.Add(1);

            List<int> b = new List<int>
            {
                1,2,3,4,4,5
            };

            a.Insert(1, 9);
            a.Remove(2);
            a.RemoveAt(1);

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
            foreach(int num in b)
            {
                Console.WriteLine(num);
            }

            // キーとバリューセット
            Dictionary<string, string> capital = new Dictionary<string, string>();
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["フランス"] = "パリ";
            foreach(string s in capital.Keys)
            {
                Console.WriteLine("{0}の首都は{1}です。", s, capital[s]);
            }

            HashSet<int> h = new HashSet<int>
            {
                1, 2, 3,1
            };
            foreach(int i in h)
            {
                Console.WriteLine(i);
            }
        }
    }
}


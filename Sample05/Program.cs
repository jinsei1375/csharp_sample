using System;
namespace Sample05
{
	public class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person();
			Person p2 = new Person();
			p1.Name = "山田";
			p1.Age = 10;
			p2.SetAgeAndName("河田", 20);
			p1.ShowAgeAndName();
			p2.ShowAgeAndName();
			Console.WriteLine("{0}", p1.Name);
			Console.WriteLine("");
			Access a = new Access();
			//a.Data1 = 1;
			a.Data2 = 2;
			a.ShowDatas();
			//Console.WriteLine("{0}", a.Data2);

			Person2 person2 = new Person2();
			person2.SetAgeAndName("鈴木", 20);
			person2.Age = 20;
            //person2.Name = "ああああ";
            Console.WriteLine("{0}, {1}", person2.Name, person2.Age);
        }
	}
}


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
        }
	}
}


using System;
namespace Sample05
{
	public class Person2
	{
        // プロパティ定義
        public string Name
        {
            private set; get;
        }
        public int Age
        {
            set; get;
        }

        public void ShowAgeAndName()
		{
			Console.WriteLine("Name: {0}, 年齢: {1}", Name, Age );
		}
		public void SetAgeAndName(string name, int age)
		{
			Name = name;
			Age = age;
		}
    }
}


using System;
namespace Sample05
{
	public class Person
	{
        // フィールド
		private string name = "";
		private int age = 0;

        // プロパティ定義
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public void ShowAgeAndName()
		{
			Console.WriteLine("Name: {0}, 年齢: {1}", name, age );
		}
		public void SetAgeAndName(string name, int age)
		{
			this.name = name;
			this.age = age;
		}
    }
}


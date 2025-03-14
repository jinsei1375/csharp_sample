using System;
namespace Sample06
{
	public class Person
	{
        // プロパティ定義
        public string name
        {
            set; get;
        }
        public int age
        {
            set; get;
        }

        // 引数なしコンストラクタ
        public Person() : this("引数なし", 0)
        {
            Console.WriteLine("引数なし");
        }

        // 引数なしコンストラクタ
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Name: {0}, 年齢: {1}", name, age);
        }

        // デストラクタ
        ~Person()
        { 
            Console.WriteLine("デストラクタ");
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




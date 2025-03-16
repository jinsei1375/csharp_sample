using System;
namespace Sample09
{
	abstract class Bird
	{
		protected string name;

		public Bird(string name)
		{
			this.name = name;
		}

		public String Name
		{
			get { return name;  }
		}

		public abstract void Sing();
	}
}


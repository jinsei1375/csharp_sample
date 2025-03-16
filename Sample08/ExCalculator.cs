using System;
namespace Sample08
{
	public class ExCalculator : Calculator
	{
		public ExCalculator()
		{
			
		}

		public void mul()
		{
			Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }

        public void div()
        {
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }

		//親クラスのメソッドをオーバーライド
		public override void Foo()
		{
			Console.WriteLine("子クラスのFoo()メソッド");
		}

    }
}


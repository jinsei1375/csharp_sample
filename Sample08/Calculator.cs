using System;
namespace Sample08
{
	public class Calculator
	{

        //継承クラスでもアクセス可能
        public int num1 { get; set; }
        public int num2 { get; set; }
		public Calculator()
        {

        }

        public void add()
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }

        public void sub()
        {
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        }

        //継承クラスでオーバーライドさせるためにvirtulつける
        public virtual void Foo()
        {
            Console.WriteLine("親クラスのFoo()メソッド");
        }
    }
}


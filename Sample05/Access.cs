using System;
namespace Sample05
{
	public class Access
	{
        // 読み込みオンリー
        private int data1 = 5;

        // 書き込みオンリー
        private int data2 = 2;

        public int Data1
        {
            get { return data1; }
        }
        public int Data2
        {
            set { data2 = value; }
        }

        public void ShowDatas()
		{
			Console.WriteLine("Data1={0}, Data2={1}", data1, data2 );
		}
    }
}


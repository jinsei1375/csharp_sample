using System;
using Sample10;

namespace Sample10
{
    class Program
    {
        public static void Main()
        {
            CellPhone cp = new CellPhone("hoge@gmail.com", "00000000000");
            cp.Call("9000000000000");
            cp.SendMail("gggggg@gmail.com");

            //IPhoneでキャスト
            IPhone phone = (IPhone)cp;
            phone.Call("91939429894");
            //phone.SendMail("dsofdsf@gmail.com");
        }
    }
}


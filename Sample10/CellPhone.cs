using System;
namespace Sample10
{
	public class CellPhone : IPhone, IEmail
	{
        private string mailAdress;
        private string number;
        public CellPhone(string mailAdress, string number)
		{
			this.mailAdress = mailAdress;
			this.number = number;
		}

		public void SendMail(string address)
		{
			Console.WriteLine(address + "に" + this.mailAdress + "からメール送信します。");
		}

        public void Call(string number)
        {
            Console.WriteLine(number + "に" + this.number + "からメール電話をかけます。");
        }


    }
}


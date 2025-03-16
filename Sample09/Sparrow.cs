using System;
namespace Sample09
{
    class Sparrow : Bird
    {
        public Sparrow() : base("雀")
        {
            
        }

        public override void Sing()
        {
            Console.WriteLine("ちゅんちゅん");
        }
    }
}
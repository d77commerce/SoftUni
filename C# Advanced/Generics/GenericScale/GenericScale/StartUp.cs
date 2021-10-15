using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<string> equalityScale = new EqualityScale<string>("Ema","Ema");
            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}

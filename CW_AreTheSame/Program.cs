using System;

namespace CW_AreTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new AreTheSame();
            Console.WriteLine(a.comp(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 }));
            Console.ReadKey();
        }
    }
}

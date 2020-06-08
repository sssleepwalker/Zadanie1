using System;
using static lib1;

namespace zadanie1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Z1: " + lib1.Stpow("cat", 8));
            Console.WriteLine("Z2: " + lib1.Rev("frog"));
            Console.WriteLine("Z3: " + lib1.remov("wuyeqVWAFWWW","W"));
            Console.WriteLine("Z4: " + lib1.leng("vgdvugd"));
        }

    }
}
using System;

namespace _03_SignedUnsigned
{
    class MainApp
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (SByte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

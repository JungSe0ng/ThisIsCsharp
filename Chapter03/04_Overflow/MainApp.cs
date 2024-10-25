using System;

namespace _04_Overflow
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);
            
            a = a + 1;

            Console.WriteLine(a);
        }
    }
}

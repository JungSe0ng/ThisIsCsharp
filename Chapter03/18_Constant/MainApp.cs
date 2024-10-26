using System;

namespace _18_Constant
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483648;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
        }
    }
}

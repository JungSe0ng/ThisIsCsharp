using System;

namespace _07_DoWhile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                Console.WriteLine("b) i : {0}", i--);
            }
            while (i > 0);
        }
    }
}

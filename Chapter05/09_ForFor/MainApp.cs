using System;

namespace _09_ForFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}

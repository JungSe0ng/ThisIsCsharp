﻿using System;
using System.Globalization;

namespace _13_Break
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("계속할까요? (예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }
        }
    }
}

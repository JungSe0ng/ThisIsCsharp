﻿using System;
using static System.Console;

namespace _31_StringInterpolation
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string name = "정성권";
            int age = 23;
            WriteLine($"{name,-10}, {age:D3}");

            name = "박날씬";
            age = 30;
            WriteLine($"{name}, {age,-10:D3}");

            name = "이비실";
            age = 17;
            WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");
        }
    }
}

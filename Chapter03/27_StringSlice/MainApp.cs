﻿using System;
using static System.Console;

namespace _27_StringSlice
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting.Substring(0, 5));    // Good
            WriteLine(greeting.Substring(5));       // Moning
            WriteLine();

            string[] arr = greeting.Split(new string[] {" "}, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);
            
            foreach(string element in arr)
                WriteLine("{0}", element);
        }
    }
}

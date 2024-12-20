﻿using System;
using System.Globalization;
using static System.Console;

namespace _30_StringFormatDatetime
{
    class MainApp
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 10, 27, 13, 39, 21);
            
            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}",dt);
            WriteLine("24시간 형식 : {0:yyyy-MM-dd tt HH:mm:ss (dddd)}",dt);

            CultureInfo ciko = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)",ciko));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)",ciko));
            WriteLine(dt.ToString(ciko));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
    }
}

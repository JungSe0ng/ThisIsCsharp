﻿using System;

namespace _21_Enum3
{
    enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK }
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}

using System;

namespace _19_Enum
{
    enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
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

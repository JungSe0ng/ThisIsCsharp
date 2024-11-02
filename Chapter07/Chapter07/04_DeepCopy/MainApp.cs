using System;
using System.Net.WebSockets;

namespace _04_DeepCopy
{
    class MyClas
    {
        public int MyField1;
        public int MyField2;
        public MyClas DeepCopy()
        {
            MyClas newCopy = new MyClas();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClas source = new MyClas();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClas target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        
            Console.WriteLine("Deep Copy");
            
            {
                MyClas source =new MyClas();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClas target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}

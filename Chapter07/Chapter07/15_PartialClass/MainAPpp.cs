using System;

namespace _15_PartialClass
{
    partial class MyClass
    {
        public void Mymethod1()
        {
            Console.WriteLine("MyMethod1");
        }
        public void Mymethod2()
        {
            Console.WriteLine("MyMethod2");
        }
    }
    partial class MyClass
    {
        public void MyMethod3()
        {
            Console.WriteLine("MyMethod3");
        }
        public void MyMethod4()
        {
            Console.WriteLine("MyMethod4");
        }
    }
        
    class MainAPpp
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Mymethod1();
            obj.Mymethod2();
            obj.MyMethod3();
            obj.MyMethod4();

        }
    }
}

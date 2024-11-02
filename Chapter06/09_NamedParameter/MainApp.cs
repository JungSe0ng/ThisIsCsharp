using System;

namespace _09_NamedParameter
{
    class MainApp
    {

        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name : {name}, Phone : {phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone : "010-1234-5678");
            PrintProfile(phone: "010-1234-0000", name: "박지성");
            PrintProfile("박세리", "010-2222-3333");
        }
    }
}

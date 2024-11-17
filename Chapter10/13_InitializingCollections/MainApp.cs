﻿using System;
using System.Collections;

namespace _13_InitializingCollections
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach(object item in list)
                Console.WriteLine($"ArrayList : {item}");
            Console.WriteLine();
            
            Stack stack = new Stack(arr);
            foreach (object item in stack)
                Console.WriteLine($"Stack : {item}");
            Console.WriteLine();
            
            Queue queue = new Queue(arr);
            foreach (Object item in queue)
                Console.WriteLine($"Queue : {item}");
            Console.WriteLine();

            ArrayList list2 = new ArrayList() { 11, 22,33 };
            foreach(Object item in list2)
                Console.WriteLine($"ArrayList2 : {item}");
            Console.WriteLine();

        }
    }
}

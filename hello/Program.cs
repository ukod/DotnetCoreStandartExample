﻿using System;
using logic;
using Wintellect.PowerCollections;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name:");
            var name = "Kostya";
            var message = HelloWorld.GetMessage(name);
            Console.WriteLine(message);

            var data = new Bag<int>() { 1, 2, 3 };
            foreach (var element in data)
                Console.WriteLine(element);
        }
    }
}

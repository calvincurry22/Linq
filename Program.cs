using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> fruits = new List<string>
            {
                "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"
            };
            IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L"));
            LFruits.ToList().ForEach(fruit => Console.WriteLine(fruit));
        }
    }
}

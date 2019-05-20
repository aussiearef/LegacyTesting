using System;
using System.Collections.Generic;

namespace SproutMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var legacyClass = new LegacyClass();

            var dict1 = new Dictionary<int, int>()  { { 1,0},{ 2,0},{ 3,0} };
            var dict2 = new Dictionary<int, int>() { { 7, 0 }, { 8, 0 }, { 9, 0 }, { 1, 800 } };

            legacyClass.AppendDictionary<int, int>(dict1, dict2);

            foreach (var item in dict2)
            {
                Console.WriteLine($"{item.Key} , {item.Value}");
            }
            
            Console.WriteLine("Press a key...");
            Console.ReadKey();
        }
    }
}

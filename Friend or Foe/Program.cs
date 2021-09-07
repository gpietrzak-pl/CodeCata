using System;
using System.Collections.Generic;

namespace Friend_or_Foe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// https://www.codewars.com/kata/55b42574ff091733d900002f/train/csharp
        /// </summary>
        public static class Kata
        {
            public static IEnumerable<string> FriendOrFoe(string[] names)
            {
                var output = new List<string>();

                foreach (var item in names)
                {
                    if (item.Length == 4)
                        output.Add(item);
                }

                return output;
            }
        }
    }
}
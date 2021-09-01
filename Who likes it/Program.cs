using System;

namespace Who_likes_it
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    /// https://www.codewars.com/kata/5266876b8f4bf2da9b000362/train/csharp
    /// </summary>
    public static class Kata
    {
        public static string Likes(string[] name)
        {
            if (name.Length > 3)
            {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
            if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            if (name.Length == 2)
            {
                return $"{name[0]} and {name[1]} like this";
            }
            if (name.Length == 1)
            {
                return $"{name[0]} likes this";
            }
            else
            {
                return "no one likes this";
            }
        }
    }
}

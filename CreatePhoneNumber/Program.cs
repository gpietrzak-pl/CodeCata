using System;

namespace CreatePhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /// <summary>
    /// https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp
    /// </summary>
    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string str = ($"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}");
            return str;
        }
    }
}

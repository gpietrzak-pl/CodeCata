using System;

namespace String_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static class Repeat
        {
            public static string RepeatStr(int n, string s)
            {
                var output = "";
                for (int i = 0; i < n; i++)
                {
                    //String.Empty
                    output = output + s;
                }
                return output;
            }
        }
    }
}

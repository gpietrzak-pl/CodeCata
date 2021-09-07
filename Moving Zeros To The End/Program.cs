using System;

namespace Moving_Zeros_To_The_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] MoveZeroes(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] == 0)
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }

            }

            return arr;
        }
    }
}

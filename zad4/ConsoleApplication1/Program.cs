using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Max(new []{1,2,3,4,5,6}));
        }

        public static int Max(int[] ints)
        {
            int a = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] > a)
                    a = ints[i];
            }

            return a;
        }
    }
}
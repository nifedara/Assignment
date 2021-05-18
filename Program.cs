using System;

namespace ConsoleApp3
{
    /// <summary>
    /// This program prints 1-100 using the for loop,
    /// puts a comma btw the numbers until the last number after which it puts a fullstop.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[100];
            
            for (var i = 0; i < v.Length; i++)
            {
                v[i] = i + 1;

                if (v[i] != 100)
                {
                    Console.Write("{0}, ", v[i]);
                }

                else
                {
                    Console.Write("{0}. ", v[i]);
                }
            }

        }
    }
}

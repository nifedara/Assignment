using System;

namespace ConsoleApp3b
{
    /// <summary>
    /// This program prints 1-100in reverse, i.e it prints 100-1 using the for loop,
    /// puts a comma btw the numbers until the last number, 1,  after which it puts a fullstop.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[102];

            for (var i = 101; i != 1; i--)
            {
                v[i] = i - 1;

                if (v[i] != 1)
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
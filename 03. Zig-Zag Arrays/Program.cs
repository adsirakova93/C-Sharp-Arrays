using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] evenArray = new int[n];
            int[] oddArray = new int[n];

            for (int index = 0; index < n; index++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (index % 2 == 0)
                {
                    evenArray[index] = input[0];
                    oddArray[index] = input[1];
                }
                else
                {
                    oddArray[index] = input[0];
                    evenArray[index] = input[1];
                }
            }
            Console.WriteLine(string.Join(" ",evenArray));
            Console.WriteLine(string.Join(" ",oddArray));


        }
    }
}

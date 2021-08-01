using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main( )
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfRotation = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfRotation; i++)
            {
                int firstElement = numbers[0];

                for (int index = 0; index < numbers.Length-1; index++)
                {
                    numbers[index] = numbers[index + 1];
                }
                numbers[numbers.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        
    }
}

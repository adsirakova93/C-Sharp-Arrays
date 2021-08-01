using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int equalNumbers = 0;

            int maxCounter = int.MinValue;
            int pos = 0;

            while (pos < numbers.Length - 1)
            {
                if (numbers[pos] == numbers[pos + 1])
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        equalNumbers = numbers[pos];

                    }

                }
                else
                {
                    counter = 1;
                }
                pos++;


            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{equalNumbers} ");
            }
        }

    }
}


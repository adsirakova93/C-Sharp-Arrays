using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagon = int.Parse(Console.ReadLine());

            int[] wagons = new int[numberOfWagon];
            int sumOfPeople = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sumOfPeople += wagons[i];
            }
            Console.WriteLine(string.Join(' ', wagons));
            Console.WriteLine(sumOfPeople);

        }
    }
}

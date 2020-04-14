using Algoritmos.Problems;
using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer problema numero menos inmediato a la izquierda:");
            int[] arr = new int[] { 1, 6, 4, 10, 2, 5 };
            printArr(arr);
            int[] res = NearestMinimumLeft.SequenceNearestMinimumLeft(arr);
            printArr(res);
        }

        static void printArr(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i.ToString() + ",");
            }
            Console.WriteLine();
        }
    }
}

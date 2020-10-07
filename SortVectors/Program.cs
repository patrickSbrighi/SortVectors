using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 4, -9, 4, 9, 3, -2, 7, 5, 987, 1052 };
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadKey();
        }
    }
}

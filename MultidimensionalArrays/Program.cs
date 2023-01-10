using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //двумерные массивы
            int[,] array;
            int[,] array2 = new int[2,3];
            int[,] array3 =
            { { 2, 3, 4 }, 
              { 4, 5, 6 }, 
              { 7, 8, 9 }  // мы не можем задать различное количество элементов в каждом вложенном массиве, ни больше ни меньше
            };
            int[,] array4 = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6}
            };

            Console.WriteLine(array4[0,0]);// найдем 1
            Console.WriteLine(array4[1,1]);// найдем 5
            Console.WriteLine(array3[2,2]);// найдем 9

            Console.WriteLine(array3.Length);
            
            for (var i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write(array3[i,j] + " ");
                }

                Console.WriteLine();
            }

            Random random = new Random();
            int[,] array5 = new int[4, 4];
            
            for (var i = 0; i < array5.GetLength(0); i++)
            {
                for (int j = 0; j < array5.GetLength(1); j++)
                {
                    array5[i, j] = random.Next(0, 10);
                    Console.Write(array5[i,j] + " ");
                }
            }
        }
    }
}
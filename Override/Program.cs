using System;

namespace Override
{
    class Program
    {
        // В сигнатуру метода входит возвращаемый тип и параметры
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[,] array2 = new int[5, 5];
            array1 = Resize(array1, 9);
            array2 = Resize(array2,10, 9);
            Console.WriteLine(array1.Length);
            Console.WriteLine(array2.Length);
        }

        static int[] Resize(int[] array, int size)
        {
            int[] temp = new int[size];
            for (var i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }

            array = temp;
            return array;
        }

        static int[,] Resize(int [,] array,int x,int y)
        {
            int[,] temp = new int[x, y];
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    temp[i, j] = array[i, j];
                }
                
            }
            array = temp;
            return array;
        }
}
}
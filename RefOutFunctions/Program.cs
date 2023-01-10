using System;

namespace RefOutFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0, x = 1, y = 5;
            Add(ref summ,x,y);
            Console.WriteLine(summ);
            //end
            int[] array = new int[5];
            EditArray(array,2,5);
            Console.WriteLine(array[2]);
        }

        static void Add(ref int summ, int x, int y)
        {
            summ = x + y;
        }

        static void EditArray(int[]array,int index,int value)
        {
            array[index] = value;
        }
    }
}
using System;

namespace ArrayAndTempArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив -ссылочный тип
            // // создание двух массивов с разным количеством элементов и сохранение одного в другой
            int[] array = new int [3];
            int[] tempArray = new int [5];

            array = tempArray; // перекладывае один в другой и ТЕПЕРЬ они ссылаюсь на одну область памяти, благодаря чему , меняя один мы меняем и второй
            tempArray[1] = 4;
            array[0] = 5;
            Console.WriteLine(tempArray[0]);
            Console.WriteLine(array[1]);
            // конец первого

            int[] petrovich = new int [3];
            int[] ivanich = new int [5];
            int[] sidorich = new int[0];

            petrovich = ivanich;

            petrovich[0] = 5;
            petrovich[1] = 3;

            sidorich = petrovich;
            Console.WriteLine(ivanich[0]);
            Console.WriteLine(ivanich[1]);
            sidorich[2] = 5;
            sidorich[3] = 6;
            Console.WriteLine(sidorich[0]);
            Console.WriteLine(sidorich[1]);

            petrovich = new int[10];
        }
    }
}
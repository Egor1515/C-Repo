﻿using System;

namespace ArraysPractice
{
    class ArraysPractice
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 7, 8 }; // создаем обычный массив 
            for (var i = 0; i < array.Length; i++) // теперь хотим с помощью цикла достучаться до каждого элемента
            {
                Console.WriteLine(array[i]);// и выводи конкретный элемент в консоль
            }

            int summ = 0;// далее хотим посчитать сумму и создаем для этого отдельную переменную
            for (var i = 0; i < array.Length; i++) // далее начинаем перебирать каждый отдельный элемент и кладем его в переменную сум
            {
                summ += array[i];// здесь мы это и делаем 
            }

            Console.WriteLine(summ);// после цикла выводим сумму в консоль
            // конец суммы

            int maximum = int.MinValue;// создаем переменную для сохранения максимального число из массива и изначально мы должны ее проинициализировать и положить туда какое-то число,
                                       // но мы не можем сделать 0 потому что у нас может быть работа с отрицательными числами, поэтому мы должны положить МИНИМАЛЬНОе значение САМОГО ИНТА, и это можно сделать
                                       for (var i = 0; i < array.Length; i++) // делаем цикл в котором и будем перебирать и искать максимальное значение
            {
                if (maximum < array[i]) // здесь важно понять что мы сравниваем изначальное значение переменной(минимальный инт) с каждым отдельным элементом из массива и дальше
                {
                    maximum = array[i]; // дальше если мы получаем число большее чем в начальной МАКСИМАЛЬНОЙ переменной то мы будем ее переписывать ТЕКУЩИМ элементов из массива
                }
            }
            Console.WriteLine(maximum); // и когда прогоним все операции то просто выведем самое максимальное число
        }
        
    }
}
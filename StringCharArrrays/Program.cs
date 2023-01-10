using System;

namespace StringCharArrrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // по факту стринг это массив чаров и мы можем так же обращаться к ним, но не можем изменять значение каждого отдельного элемента, только читать
            string line = "Привет";
            Console.WriteLine(line[0]);
            //end

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            for (var i = 0; i < numbers.Length; i++)
            {
                // используем с индексом, когда он нужен
                Console.WriteLine(numbers[i]);
            }
            
            foreach (int number in numbers)
            {
                // когда не нужен индекс используем forEach
                Console.Write(number);
            }
        }
    }
}
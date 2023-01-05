using System;

namespace RandomGame
{
    class RandomGame
    {
        static void Main(string[] args)
        {
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 10, number + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower}, но меньше чем {higher}");
            Console.WriteLine($"Что это за число? у вас {triesCount} попыток угадать");

            while (triesCount-- > 0)
            {
                Console.WriteLine("Ваш ответ: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("Вы правы, это было число " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не угадали, попробуйте еще раз");
                }
            }

            if (triesCount < 0)
            {
                Console.WriteLine("Вы проиграли, число было: " + number);
            }
        }
    }
}
using System;

namespace ConsoleOutputPractice
{
    class ConsolePractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Андрей!\n Куда ты вчера делся?\nЯ убежал к..."); // переносит на след строчку с помощью \n 
            Console.WriteLine("Привет, Андрей!\n Куда ты вчера делся?\nЯ убежал к...1\b \b"); // удаляет символ(типо BACKSPACE) путем двойного написания \b\b;
            Console.Clear(); // очищает консоль
            Console.SetCursorPosition(15, 25); // ставит курсор в заданное нами положение ( параметрами принимается количество клеточек слева и сверху) типо 15 клеток слева и 25 сверху
            Console.ForegroundColor = ConsoleColor.Yellow; // команда меняет цвет вывода в консоль
            Console.BackgroundColor = ConsoleColor.Red; // здесь имеется возможность поменять задний фон выведенного текста
            Console.WriteLine("Здесь видим что цвет поменялся и задний фон тоже");
            Console.WindowHeight = 10;// задается высота консоли
            Console.WindowWidth = 35;// задается длина консоли
            Console.ReadKey();
        }
    }
}
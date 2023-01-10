using System;

namespace MultiDimensionalArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books =
            {
                { "Pushkin", "Лермонтов", "Есенин" },
                { "Петров", "Кинг", "Иванов" },
                { "Егоров", "Игорев", "Кириллов" }
            };
            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Весь  список авторов: \n");

                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.WriteLine(books[i, j] + " ! ");
                    }

                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine(
                    "\n1 - Узнать имя автора по индексу книги. \n\n2 - Найти книгу по автору. \n\n3 - Выход.");
                Console.WriteLine("Выберите пункт меню");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.WriteLine("Введите номер полки");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите номер колонки");
                        column = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Это автор:" + books[line, column]);
                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;
                        Console.WriteLine("Введите автора");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.WriteLine(
                                        $"Автор: {books[i, j]} находится по адресу полка: {i + 1} место: {j + 1} ");
                                    authorIsFound = true;
                                }
                            }
                        }
                        if (authorIsFound == false)
                        {
                            Console.WriteLine("Такого автора нет(");
                        }

                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда");
                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
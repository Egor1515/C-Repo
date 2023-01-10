using System;
using System.Reflection.Emit;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
           // аргумент это то что функция получает
           // а параметр это то что функция ХОЧЕТ получить

           string userInput = "asASD";
           userInput.ToLower();// встроенная функция приводящая значение к нижнему регистру, она является встроенной в язык
           Console.WriteLine(userInput.ToLower()); // Соответственно мы можем вывести так, либо сохранить в отдельную переменную и вывести ее и увидим что у нас все стало писаться с маленькой буквы


           Console.WriteLine("Привет");
           Console.WriteLine("Tы здесь?");
           WriteError("Нет соединения с интернетом");
           Console.WriteLine("Странно...");// здесь передача называется АРГУМЕНТ
           WriteError("Пора оплатить интернет");
        }

        static void WriteError(string text) // здесь передача называется ПАРАМЕТР
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;
            // конец
            int result = summ(1, 2) + 1;// здесь мы вызываем функцию ниже, передаем в нее два параметра это число Х и У, далее прибавляем еще 1 к ней, можем хоть 100 прибавить и после чего все это помещаем в переменную резалт
        }

        static int summ(int x, int y)
        {
            int summ = x + y;
            
            return summ;
        }
    }
}
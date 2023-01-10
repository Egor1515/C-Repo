using System;
using System.Drawing;

namespace FunctionExampleAnother
{
    class Program
    {
        static void Main(string[] args)
        {
          WriteError("Error2",ConsoleColor.Blue);
          WriteError("Error2",ConsoleColor.Green);
          WriteError("Error2",ConsoleColor.Red);
          WriteError("Error2",ConsoleColor.Magenta);
          WriteError("Error2");
          WriteError("Error2",t:')'); // здесь мы хотели передать текст и поменять символ, но не хотели менять второй по очереди параметр(необязательный), поэтому мы просто явно дали понять,
                                      // что хотим поменять параметр T и через двоеточие это указали(это просто запомнить) 
        }

        static void WriteError(string text,ConsoleColor color = ConsoleColor.Red, char t = '!') // здесь присутствует необязатеельный параметр, который может И НЕ УКАЗЫВАТЬСЯ ПРИ ВЫЗОВЕ
                                                                                  // и тогда он примет то значение которое мы передали через знак равно,
                                                                                  // после необязательных параметров нельзя ставить обязательные параметры,все необзятельные должны отдельно стоять в конце 
        {
           ConsoleColor defColor =  Console.ForegroundColor;
           Console.ForegroundColor = color;
           Console.WriteLine(text);
           Console.ForegroundColor = defColor;
        }
    }
}
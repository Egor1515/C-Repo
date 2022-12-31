using System;
using System.Text;

namespace ConsoleApp1
{
    //CTRL + ALT + i - это команда для причесывания кода, если строчки поехали, нажимаешь и все равняется аккуратно, попробуй
    public class AnotherClass
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;// используется для установления кодировки,чтобы при вводе данных(INput) можно было писать и русские и английские
            Console.OutputEncoding = Encoding.Unicode;// используется для установления кодировки,чтобы при ВЫВОДЕ данных(OUTput) можно было писать и русские и английские
            // Console.WriteLine();
            // Console.Write();
            // Console.ReadKey();

            string name;//Создали переменную
            Console.Write("Введите ваше имя : ");// Написали пользователю,что мы от него ждем,чтобы он тупо не пялил в экран
            name = Console.ReadLine(); // в эту же переменную сохраняем получаемое значение
            Console.WriteLine("Ваше имя : " + name); // Выводим обычным способом
            Console.WriteLine($"Ваше имя : {name}");// Вывоодим через интерполяцию
            int age; //создали переменную      
            Console.Write("Введите ваш возраст : ");//Сообщаем чего ожидаем от пользоватея
            age = Convert.ToInt32(Console.ReadLine()); // хотим сохранить получаемое значение
            Console.WriteLine($"Ваш возраст: {age}"); //Выводим через интерполяцию       
        }
    }
}
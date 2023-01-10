using System;

namespace RandomFightGladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            // чтобы не повторять много раз ctrl c ctrl v , можно поставить в те места куда нужно курсор с помощью ctrl alt 
            Random random = new Random(); // опять создаем рандом
            float health1 = random.Next(90, 100); // сохраняем первую переменную хп
            int damage1 = random.Next(5, 20); // здесь то же самое для дамага
            int armor1 = random.Next(25, 65);// то же самое для армора

            float health2 = random.Next(80, 150);// то же самое для 2го пользователя
            int damage2 = random.Next(20, 40);// то же самое
            int armor2 = random.Next(65, 100);// и то же самое
            Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {damage1} наносимый урон, {armor1} броня");// после чего используя интерполяцию просто выводим инфо о каждом гладиаторе его хп армор дамаг
            Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {damage2} наносимый урон, {armor2} броня");// так же для 2го

            while (health1 > 0 && health2 > 0) // дальше начинаем цикл и проверяем чтобы хп второго и первого было боьлше нуля ибо зачем им драться
            {
                health1 -= Convert.ToSingle(random.Next(0, damage2 + 1)) / 100 * armor1;// дальше мы будем отнимать от здоровья рандомное число дамаги и проводить остальные умножеия на армор и тд
                health2 -= Convert.ToSingle(random.Next(0, damage1 + 2)) / 100 * armor1;// то же самое для второго

                Console.WriteLine("Здоровье гладиатора 1: " + health1);// и каждую итерацию будем выводить в консоль че по хп
                Console.WriteLine("Здоровье гладиатора 2: " + health2);// то же самое 
            }

            if (health1 <= 0 && health2 <= 0) // если в одном цикле они ударят и хп станет 0 или меньше то будет ничья
            {
                Console.WriteLine("Ничья");// и собственно тут мы это и выведем
            }
            else if (health1 <= 0)// если же только первого хп будет меньше нуля то первый проиграл
            {
                Console.WriteLine("Гладитор 1 пал");
            }
            else if (health2 <= 0)// если же только второго будет меньше нуля то второй проиграл
            {
                Console.WriteLine("Гладитор 2 пал");
            }

            {
            }
        }
    }
}
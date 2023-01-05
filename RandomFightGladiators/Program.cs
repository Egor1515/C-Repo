using System;

namespace RandomFightGladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            // чтобы не повторять много раз ctrl c ctrl v , можно поставить в те места куда нужно курсор с помощью ctrl alt 
            Random random = new Random();
            float health1 = random.Next(90, 100);
            int damage1 = random.Next(5, 20);
            int armor1 = random.Next(25, 65);

            float health2 = random.Next(80, 150);
            int damage2 = random.Next(20, 40);
            int armor2 = random.Next(65, 100);
            Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {damage1} наносимый урон, {armor1} броня");
            Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {damage2} наносимый урон, {armor2} броня");

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(random.Next(0, damage2 + 1)) / 100 * armor1;
                health1 -= Convert.ToSingle(random.Next(0, damage1 + 2)) / 100 * armor1;

                Console.WriteLine("Здоровье гладиатора 1: " + health1);
                Console.WriteLine("Здоровье гладиатора 2: " + health2);
            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Гладитор 1 пал");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Гладитор 2 пал");
            }

            {
            }
        }
    }
}
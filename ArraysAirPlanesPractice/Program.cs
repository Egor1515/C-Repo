using System;

namespace ArraysAirPlanesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
        // программа по приобретению билетов на самолет
            int[] sectors = { 6, 28, 15, 15, 17 }; // создаем массив с секторами в самолете,сектора это отдельный элемент, а его значение это количество сидений
            bool isOpen = true; // создаем переменную которая просто будет служить для хранения тру и фоолс, дальше по коду поймем зачем

            while (isOpen)// здесь мы создаем сам массив и в него передаем изначальное значение ТРУ
            {
                Console.SetCursorPosition(0, 18); // далее мы хотим красивенько отобразить и можем сделать это с помощью метода устанавливающего курсор в определенное место , в качестве
                for (var i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n\n1 - забронировать места \n\n2 - выход из программы.\n\n");
                Console.WriteLine("Введите номер команды");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.WriteLine("В каком секторе вы хотите забронировать место");
                        userSector = Convert.ToInt32(Console.ReadLine())-1;
                        if (sectors.Length <= userSector || userSector < 0 )
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.WriteLine("Сколько мест вы хотите заабронировать");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (sectors[userSector]< userPlaceAmount || userPlaceAmount< 0)
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест, Остаток {sectors[userSector]}");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронирование прошло успешно");
                        break;

                    case 2:
                        isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
﻿using System;

namespace logicalOperations
{
    class logicalOperation{
        static void Main(string[] args)
        {
            // ==  оператор сравнения типо x ==1 ? типо равно ли х одному или нихуя
            // = оператор приравнивания типо int x = 1;
            // > больше x>1?
            // < меньше x<1? 
            // >= больше либо равно х >=5 значит пятерка в Х тоже будет удовлетворять условию
            // <= меньше либо равно  тоже самое
            // != не равно то есть x!= 1 типо проверяем чтобы х не была равно 1,противоположная обычному ==
            // все результаты при работе с данными операторами будут возвращать нам ДА или НЕТ , а значит по прогерски TRUE or FALSE, соответственно мы можем сохранять результат в булевые переменные,
            // (boolean), которые и хранят в себе только 2 варика развития событий
            int age = 18; //создаем переменную
            bool accessIsAllowed = age >= 18; //создаем вторую, с типом бул и проверяем внутри нее типо правда ли что переменная age больше или равна 18 и так как это правда то выводя в консоль получаем TRUE
            Console.WriteLine(accessIsAllowed);// здесь как раз и выводим , переменная называется так, потому что просто переводится типо "доступРазрешен?" и так логично называть для понимания нахуя она нам

        }
    }
}
using System;

namespace Random
{
    class Random
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();

            int value = random.Next(0, 10); // первое значение попадает в диопозон, второе не попадает
            Console.WriteLine(value);
            
            while (true) // бесконечный цикл, так как в скобках просто написано ТРУ , это фишка, для зацикливания
            {
                int value1 = random.Next(0, 10);
                Console.WriteLine(value1);
                Console.ReadKey();
            }
        }
        
        
    }
}
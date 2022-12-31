using System;

namespace IncrementAndDecrement
{
    class IncrementDecrement
    {
        static void Main(string[] args)
        {
            int i = 0;
            // Console.WriteLine(i);
            // i++;
            // Console.WriteLine(i);
            // i--;
            // Console.WriteLine(i);
            // ++i;
            // Console.WriteLine(i++ + ++i);
            //Префиксная форма сначала увеличивает или уменьшает число в перменно,а потом возвращает его, а постфиксная форма сначала возвращает а потом увеличивает или уменьшает
            Console.WriteLine(i++);// здесь сначала выводится 0,потом увеличивается и при следующем выводе там уже будет хранится 1
            Console.WriteLine(++i);//здесь же сначала увеличили(НО,так как в предыдущей строке мы увеличили на 1, то тут уже 1 а не 0) и далее вывели в консоль уже 2!!!
            //ИНКРЕМЕНТЫ И ДЕКРЕМЕНТЫ ВСЕГДА ИМЕЮТ НАИВЫСШИЙ ПРИОРИТЕТ 
            
        }
    }
}
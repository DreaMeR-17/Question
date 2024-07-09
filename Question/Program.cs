using System;

namespace Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine(" ");

            Console.Write("Как Вас зовут? ");
            string name = Console.ReadLine();

            Console.Write("Сколько Вам лет? ");
            string age = Console.ReadLine();

            Console.Write("А какой у Вас любимый десерт? ");
            string dessert = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine($"Вы {name}, Вам {age} лет и Ваш любимый десерт это {dessert}");

            Console.ReadKey();
        }
    }
}

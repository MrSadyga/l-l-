using System;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string patronymic;
            string templateName;

            name = ("Владимирович");
            patronymic = ("Александр");

            Console.WriteLine($"{name} {patronymic}");

            templateName = name;
            name = patronymic;
            patronymic = templateName;

            Console.WriteLine($"{name} {patronymic}");
            Console.ReadKey();
        }
    }
}

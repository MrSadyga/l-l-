using System;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string mesage;

            name = ("Александр");
            surname = ("Владимирович");

            Console.WriteLine($"{surname} {name}");

            mesage = name;
            name = surname;
            surname = mesage;

            Console.WriteLine($"{surname} {name}");
            Console.ReadKey();
        }
    }
}

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
            mesage = name + ' ' + surname;

            Console.WriteLine($"{surname} {name}");
            Console.WriteLine($"{mesage}");
            Console.ReadKey();
        }
    }
}

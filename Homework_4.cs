using System;

namespace Homework_4
{
    class Program
    {   
        static void Main(string[] args)
        {
            string name;
            string surname;
            string zodiacSign;
            int years;
            int experience;

            Console.Write("Добрый день!\nВведите ваше имя: ");
            name = Console.ReadLine();

            Console.Write("Введите ваше отчество: ");
            surname = Console.ReadLine();

            Console.Write("Введите ваш знак зодиака: ");
            zodiacSign = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            years = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш опыт работы: ");
            experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Добро пожаловать {name} {surname}\nВаш возраст {years} ," +
                $"ваш знак зодиака {zodiacSign}\nОпыт работы {experience} лет\nМы рассмотрим вашу кандедатуру и обязательно вам перезвоним!");
            Console.ReadKey();
        }
    }
}

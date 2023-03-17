using System;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeInMinets;
            int hourOfTime;
            int minuteOfTime;
            int numberOfPeople;
            int serviceTimeForPerson = 10;
            int numberOfMinutesInOneHour = 60;

            Console.WriteLine("Добро пожаловать в поликлинику Dante");
            Console.WriteLine("Если вы хотите узнать время ожидания,\n" +
                "Введите количество людей ожидающих в очереди");

            numberOfPeople = Convert.ToInt32(Console.ReadLine());
            timeInMinets = serviceTimeForPerson * numberOfPeople;
            hourOfTime = timeInMinets / numberOfMinutesInOneHour;
            minuteOfTime = timeInMinets % numberOfMinutesInOneHour;

            Console.WriteLine($"Вам нужно прождать {hourOfTime} часа и {minuteOfTime} минут");
            Console.WriteLine($"Можете подойти за {minuteOfTime} минут до приема, мы займем вашу очередь!!!");
            Console.ReadKey();

        }
    }
}

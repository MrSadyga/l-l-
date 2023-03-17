using System;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQueueTime;
            int hoursInQueue;
            int minutesInLine;
            int numberOfPeople;
            int serviceTimeForPerson = 10;
            int numberOfMinutesInHour = 60;

            Console.WriteLine("Добро пожаловать в поликлинику Dante");
            Console.WriteLine("Если вы хотите узнать время ожидания,\n" +
                "Введите количество людей ожидающих в очереди");

            numberOfPeople = Convert.ToInt32(Console.ReadLine());
            totalQueueTime = serviceTimeForPerson * numberOfPeople;
            hoursInQueue = totalQueueTime / numberOfMinutesInHour;
            minutesInLine = totalQueueTime % numberOfMinutesInHour;

            Console.WriteLine($"Вам нужно прождать {hoursInQueue} часа и {minutesInLine} минут");
            Console.WriteLine($"Можете подойти за {minutesInLine} минут до приема, мы займем вашу очередь!!!");
            Console.ReadKey();

        }
    }
}

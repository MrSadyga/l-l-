using System;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeInMinets;
            int hour;
            int minute;
            int quantity;
            int queueTime = 10;

            Console.WriteLine("Добро пожаловать в поликлинику Dante");
            Console.WriteLine("Если вы хотите узнать время ожидания,\n" +
                "Введите количество людей ожидающих в очереди");

            quantity = Convert.ToInt32(Console.ReadLine());
            timeInMinets = queueTime * quantity;
            hour = timeInMinets / 60;
            minute = timeInMinets % 60;

            Console.WriteLine($"Вам нужно прождать {hour} часа и {minute} минут");
            Console.WriteLine($"Можете подойти за {minute} минут до приема, мы займем вашу очередь!!!");
            Console.ReadKey();

        }
    }
}

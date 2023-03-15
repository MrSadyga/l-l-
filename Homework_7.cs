using System;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string shop = ("Легенда");
            int gold;
            int crystal = 10;
            int quantity;
            int purchase;
            int remainder;
            int sum;

            Console.WriteLine($"Добро пожаловать в магазин {shop}.");
            Console.WriteLine("У нас вы можете приобрести кристаллы.");
            Console.WriteLine("Укажите какое колличество золота у вас имеется?");

            gold = Convert.ToInt32 (Console.ReadLine());
            sum = gold / crystal;

            Console.WriteLine($"У вас {gold} золота цена за один кристалл {crystal} золота, \n" +
                $"Вы можете приобрести {sum} кристаллов");
            Console.WriteLine("Укажите сколько кристаллов вы бы хотели приобрести");
            quantity = Convert.ToInt32(Console.ReadLine());
            purchase = crystal * quantity;
            remainder = gold - purchase;

            Console.WriteLine($"Колличество ваших кристаллов составляет {quantity},\n" +
                $"Затраты золота составили {purchase},\n" +
                $"Остаток золота в кошельке {remainder},\n" +
                $"Приходите еще, мы будем рады видеть вас в нашем магазине {shop}!");
            Console.ReadKey();
        }
    }
}

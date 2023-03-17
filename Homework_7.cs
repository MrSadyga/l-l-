using System;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string shopName = ("Легенда");
            int goldCoins;
            int priceForCrystal = 10;
            int numberOfCrystals;
            int valueOfCrystals;
            int remainingGold;
            int sum;

            Console.WriteLine($"Добро пожаловать в магазин {shopName}.");
            Console.WriteLine("У нас вы можете приобрести кристаллы.");
            Console.WriteLine("Укажите какое колличество золота у вас имеется?");

            goldCoins = Convert.ToInt32 (Console.ReadLine());
            sum = goldCoins / priceForCrystal;

            Console.WriteLine($"У вас {goldCoins} золота цена за один кристалл {priceForCrystal} золота, \n" +
                $"Вы можете приобрести {sum} кристаллов");
            Console.WriteLine("Укажите сколько кристаллов вы бы хотели приобрести");
            numberOfCrystals = Convert.ToInt32(Console.ReadLine());
            valueOfCrystals = priceForCrystal * numberOfCrystals;
            remainingGold = goldCoins - valueOfCrystals;

            Console.WriteLine($"Колличество ваших кристаллов составляет {numberOfCrystals},\n" +
                $"Затраты золота составили {valueOfCrystals},\n" +
                $"Остаток золота в кошельке {remainingGold},\n" +
                $"Приходите еще, мы будем рады видеть вас в нашем магазине {shopName}!");
            Console.ReadKey();
        }
    }
}

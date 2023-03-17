using System;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string shopName = ("Легенда");
            int goldCoin;
            int priceForCrystal = 10;
            int amountOfCrystal;
            int buyingCrystals;
            int theRestOfTheCrystals;
            int sum;

            Console.WriteLine($"Добро пожаловать в магазин {shopName}.");
            Console.WriteLine("У нас вы можете приобрести кристаллы.");
            Console.WriteLine("Укажите какое колличество золота у вас имеется?");

            goldCoin = Convert.ToInt32 (Console.ReadLine());
            sum = goldCoin / priceForCrystal;

            Console.WriteLine($"У вас {goldCoin} золота цена за один кристалл {priceForCrystal} золота, \n" +
                $"Вы можете приобрести {sum} кристаллов");
            Console.WriteLine("Укажите сколько кристаллов вы бы хотели приобрести");
            amountOfCrystal = Convert.ToInt32(Console.ReadLine());
            buyingCrystals = priceForCrystal * amountOfCrystal;
            theRestOfTheCrystals = goldCoin - buyingCrystals;

            Console.WriteLine($"Колличество ваших кристаллов составляет {amountOfCrystal},\n" +
                $"Затраты золота составили {buyingCrystals},\n" +
                $"Остаток золота в кошельке {theRestOfTheCrystals},\n" +
                $"Приходите еще, мы будем рады видеть вас в нашем магазине {shopName}!");
            Console.ReadKey();
        }
    }
}

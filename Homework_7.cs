using System;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string shopName = ("Легенда");
            int walletWithGold;
            int priceForCrystal = 10;
            int numberOfCrystals;
            int moneySpent;
            int sumOfCrystals;

            Console.WriteLine($"Добро пожаловать в магазин {shopName}.");
            Console.WriteLine("У нас вы можете приобрести кристаллы.");
            Console.WriteLine("Укажите какое колличество золота у вас имеется?");

            walletWithGold = Convert.ToInt32(Console.ReadLine());
            sumOfCrystals = walletWithGold / priceForCrystal;

            Console.WriteLine($"У вас {walletWithGold} золота цена за один кристалл {priceForCrystal} золота, \n" +
                $"Вы можете приобрести {sumOfCrystals} кристаллов");
            Console.WriteLine("Укажите сколько кристаллов вы бы хотели приобрести");
            numberOfCrystals = Convert.ToInt32(Console.ReadLine());
            moneySpent = priceForCrystal * numberOfCrystals;
            walletWithGold -= moneySpent;

            Console.WriteLine($"Колличество ваших кристаллов составляет {numberOfCrystals},\n" +
                $"Затраты золота составили {moneySpent},\n" +
                $"Остаток золота в кошельке {walletWithGold},\n" +
                $"Приходите еще, мы будем рады видеть вас в нашем магазине {shopName}!");
            Console.ReadKey();
        }
    }
}

using System;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesCount = 52;
            int countPerColumn = 3;

            int fullRowsCount = picturesCount / countPerColumn;
            int overflowCount = picturesCount % countPerColumn;

            Console.WriteLine($"Рядов занято: {fullRowsCount}");
            Console.WriteLine($"Остаток картинок: {overflowCount} ");
            Console.ReadLine();
        }
    }
}

using System;
using DuckFarm.Ducks;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckStorage duckstorage = DuckStorage.Get();        //создаем склад
            Console.WriteLine("Рождение живых уток...");
            for (int i = 0; i < 5; i++)
            {
                Duck duck = new Duck();                     //создаем уток и добавляем на склад
                duckstorage.Add(duck.Name);
            }
            

            Console.WriteLine("Вырезание деревянных уточек...");
            for (int i = 0; i < 8; i++)
            {
                WoodenDuck woodenduck = new WoodenDuck();
                duckstorage.Add(woodenduck.Name);
            }


            Console.WriteLine("Выплавление железных уток...");
            for (int i = 0; i < 4; i++)
            {
                IronDuck ironduck = new IronDuck();
                duckstorage.Add(ironduck.Name);
            }

            Console.WriteLine("На складе имеется:");
            foreach (KeyValuePair<string,int> keyValue in duckstorage.Storage)          //извлечение значений из словаря
            {
                Console.WriteLine(keyValue.Key + ": " + keyValue.Value+" штук");
            }

            Console.ReadLine();
        }
    }
}

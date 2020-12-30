using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем два меню
            HellDuckMenu hellDuckMenu = new HellDuckMenu();
            DuckParadiseMenu duckParadiseMenu = new DuckParadiseMenu();

            //создаем официантку и загружаем в ее маленький мозг эти 2 меню
            Waitress waitress = new Waitress(duckParadiseMenu,hellDuckMenu);
            waitress.PrintMenu(); //выводим меню на экран
            Console.ReadLine();
        }
    }
}

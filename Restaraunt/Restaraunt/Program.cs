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
            HellDuckMenu hellDuckMenu = new HellDuckMenu();
            DuckParadiseMenu duckParadiseMenu = new DuckParadiseMenu();

            Waitress waitress = new Waitress(duckParadiseMenu,hellDuckMenu);
            waitress.PrintMenu();
            Console.ReadLine();
        }
    }
}

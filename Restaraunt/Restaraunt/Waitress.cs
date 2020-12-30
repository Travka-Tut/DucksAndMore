using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class Waitress               //официантка, принимающая меню и в виде массива и в виде списка
    {
        DuckParadiseMenu _duckParadiseMenu;
        HellDuckMenu _hellDuckMenu;

        public Waitress(DuckParadiseMenu duckParadiseMenu, HellDuckMenu hellDuckMenu)        //принимает экземпляры двых меню
        {
            this._duckParadiseMenu = duckParadiseMenu;
            this._hellDuckMenu = hellDuckMenu;
        }

        public void PrintMenu()            //при печати меню использует итератор(сам прочтешь в книге)
        {
            IIterator hellDuckIterator = _hellDuckMenu.CreateIterator();
            IIterator duckParadiseIterator = _duckParadiseMenu.CreateIterator();
            Console.WriteLine("Меню\n\n---------Легкие блюда из утки -----------");
            PrintMenu(duckParadiseIterator);
            Console.WriteLine("\n----------Гриль-----------");
            PrintMenu(hellDuckIterator);

        }

        private void PrintMenu(IIterator iterator)               //хз зачем, но надо
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.Write(menuItem.getName()+", ");
                Console.Write(menuItem.getPrice()+"----");
                Console.WriteLine(menuItem.getDescription()+"");
            }
        }

       //другие методы 
    }
}

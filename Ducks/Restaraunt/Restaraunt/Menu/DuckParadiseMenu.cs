using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class DuckParadiseMenu
    {
        List<MenuItem> menuItems;
        public DuckParadiseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem("Суп из домашней утки", "Утка, картошка, макароны, зелень. 400гр.", 2.99);
            AddItem("Запеченная утиная грудка", "Утиная грудка, соевый соус, мед. 400гр.", 10.60);
            AddItem("Запеченная утка с апельсинами", "Утка, апельсины, чеснок, гранат", 15.39);
            AddItem("Салат с утиной грудкой", "Утиная грудка, листья зеленого салата, картофель, яйцо, сыр. 350гр.", 4.00);
        }
        public void AddItem(string name, string description,
             double price)
        {
            MenuItem menuItem = new MenuItem(name, description, price);
            menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new DuckParadiseIterator(menuItems);
        }
//другие методы
    }
}

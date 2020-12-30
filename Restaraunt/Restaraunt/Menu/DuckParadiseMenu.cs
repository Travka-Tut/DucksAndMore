using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class DuckParadiseMenu            // меню в виде списка
    {
        List<MenuItem> menuItems;
        public DuckParadiseMenu()            //создание меню в виде списка
        {
            menuItems = new List<MenuItem>();

            AddItem("Суп из домашней утки", "Утка, картошка, макароны, зелень. 400гр.", 2.99);
            AddItem("Запеченная утиная грудка", "Утиная грудка, соевый соус, мед. 400гр.", 10.60);
            AddItem("Запеченная утка с апельсинами", "Утка, апельсины, чеснок, гранат", 15.39);
            AddItem("Салат с утиной грудкой", "Утиная грудка, листья зеленого салата, картофель, яйцо, сыр. 350гр.", 4.00);
        }
        public void AddItem(string name, string description,       //метод для добавления элементов меню (чтоб много кода не писать в конструкторе выше)
             double price)
        {
            MenuItem menuItem = new MenuItem(name, description, price);
            menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()          //дает указание для интерфейса, куда дальше отправлять меню для обработки потом официанткой
        {
            return new DuckParadiseIterator(menuItems);
        }
//другие методы
    }
}

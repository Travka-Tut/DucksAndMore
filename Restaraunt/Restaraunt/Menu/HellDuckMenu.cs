using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class HellDuckMenu         //меню - массив (реализация точно така же (смотри меню - список))
    {
       static int maxItems = 6;
       int numberOfItems = 0;
       MenuItem[] menuItems;

       public HellDuckMenu()
       {
           menuItems = new MenuItem[maxItems];

           AddItem("Утка во фритюре с панировочными сухарями", "Крылышки и бедра утки, панировочные сухари, кутчуп.  400гр.", 3.49);
           AddItem("Утка на гриле", "Свежая охлажденная утка, кисло-сладкий соус, листья зеленого салата.  350гр.", 5.50);
           AddItem("Жаренные утиные крылышки с острым соусом", "Утинные крылышки, соус Чили, азербайджанские помидоры, кутчуп. 300гр.", 2.99);
           AddItem("Котлеты из утки", "Утиный фарш, яйца, сухари. 300гр.", 1.99);
       }
       public void AddItem(string name, string description, double price)
       {
           MenuItem menuItem = new MenuItem(name, description, price);
           if (numberOfItems >= maxItems)
               Console.WriteLine("Меню заполнено! Не возможно добавить элемент в меню.");
           else
           {
               menuItems[numberOfItems] = menuItem;
               numberOfItems++;
           }
       }

       public IIterator CreateIterator()
       {
           return new HellDuckIterator(menuItems);
       }
       //Далее код
    }
}

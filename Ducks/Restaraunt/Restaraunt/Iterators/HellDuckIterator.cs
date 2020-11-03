using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class HellDuckIterator:IIterator
    {
       MenuItem[] items;
       int position = 0;

       public HellDuckIterator(MenuItem[] items)
       {
           this.items = items;
       }

       public MenuItem Next()
       {
           MenuItem menuItem = items[position];
           position++;
           return menuItem;
       }

       public bool HasNext()
       {
           if (position >= items.Length || items[position] == null)
               return false;
           else
               return true;
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class DuckParadiseIterator:IIterator
    {
       List<MenuItem> _items;
       int _position = 0;

       public DuckParadiseIterator(List<MenuItem> items)
       {
           this._items = items;
       }

       public MenuItem Next()
       {
           MenuItem menuItem = _items[_position];
           _position++;
           return menuItem;
       }

       public bool HasNext()
       {
           if (_position >= _items.Count || _items[_position] == null)
               return false;
           else
               return true;
       }
    }
}

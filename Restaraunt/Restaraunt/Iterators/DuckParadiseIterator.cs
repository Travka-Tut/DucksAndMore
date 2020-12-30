using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class DuckParadiseIterator:IIterator        //класс обрабатывает меню, как список
    {
       List<MenuItem> _items;
       int _position = 0;

       public DuckParadiseIterator(List<MenuItem> items)         //принимает элемент меню
       {
           this._items = items;
       }

       public MenuItem Next()                   //переходит на следующий элемент меню
       {
           MenuItem menuItem = _items[_position];
           _position++;
           return menuItem;
       }

       public bool HasNext()                         //проверка на наличие следующего элемента
       {
           if (_position >= _items.Count || _items[_position] == null)
               return false;
           else
               return true;
       }
    }
}

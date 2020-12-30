using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class MenuItem        //класс для каждого элемента меню (не важно массив или список)
    {
        string name;
        string description;
       double price ; 

        public MenuItem (string name,string description, double price) {        //создание элемента меню

            this.name = name;
            this.description = description;
            this.price = price;
    }
       //методы для дальнейшего получения информации о блюде

        public string getName()      
        {
            return name;
        }

        public string getDescription()
        {
            return description;
        }

        public double getPrice()
        {
            return price;
        }
    }
}

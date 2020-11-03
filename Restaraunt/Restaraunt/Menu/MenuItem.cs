using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public class MenuItem
    {
        string name;
        string description;
       double price ; 

        public MenuItem (string name,string description, double price) {

            this.name = name;
            this.description = description;
            this.price = price;
    }

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

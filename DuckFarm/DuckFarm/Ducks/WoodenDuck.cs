using DuckFarm.Move;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DuckFarm.Ducks
{
    class WoodenDuck:BaseDuck
    {
       public WoodenDuck():base(new CanNotFly(),new CanNotQuack(),new CanSwim())
        {
            Name = "Деревянная утка";
        }
       public string Name;
    }
}

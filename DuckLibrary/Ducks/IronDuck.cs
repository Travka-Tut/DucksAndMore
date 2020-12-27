using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Interface;
using DuckFarm.Move;

namespace DuckFarm.Ducks
{
   public class IronDuck:BaseDuck
    {
        public IronDuck():base (new CanNotFly(),new CanNotQuack(),new CanNotSwim())
        {
            Name = "Железная утка";
        }
        public string Name;
    }
}

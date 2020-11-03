using DuckFarm.Move;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DuckFarm.Ducks
{
    class Duck:BaseDuck
    {
        public Duck (): base(new CanFly(),new CanQuack(),new CanSwim())
        {

        }
    }
}

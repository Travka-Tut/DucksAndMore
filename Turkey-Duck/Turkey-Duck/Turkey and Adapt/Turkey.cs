using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Interface;
using DuckFarm.Move;

namespace Turkey_Duck
{
    class Turkey      //тупо индюк обыкновенный (создается, как утка)
    {
        readonly IFly _fly;
        readonly ISwim _swim;
        readonly ICackle _cackle;

        public Turkey(IFly fly, ISwim swim, ICackle cackle) 
        {
            _fly = fly;
            _swim = swim;
            _cackle = cackle;
        }

        public void Cackle()
        {
            _cackle.Cackle();
        }

        public void Fly()
        {
            _fly.Fly();
        }
        public void Swim()
    {
        _swim.Swim();
    }
    }
}

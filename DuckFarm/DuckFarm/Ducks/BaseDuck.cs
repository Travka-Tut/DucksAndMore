using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Move;
using DuckFarm.Interface;

namespace DuckFarm.Ducks
{
    public abstract class BaseDuck
    {
        readonly IFly _fly;
        readonly IQuack _quack;
        readonly ISwim _swim;

        protected BaseDuck(IFly fly, IQuack quack, ISwim swim)
        {
            _fly = fly;
            _quack = quack;
            _swim = swim;
        }

        public void Fly()
        {
            _fly.Fly();
        }

        public void Quack()
        {
            _quack.Quack();
        }

        public void Swim()
        {
            _swim.Swim();
        }
    }
}

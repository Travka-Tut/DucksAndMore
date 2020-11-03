using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Interface;

namespace DuckFarm.Move
{
    class CanNotQuack:IQuack
    {
       public void Quack()
        {
            Console.WriteLine("Я не умею крякать!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Interface;

namespace DuckFarm.Move
{
    class CanNotSwim:ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Я не умею плавать!");
        }
    }
}

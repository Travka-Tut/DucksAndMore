using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Interface;

namespace DuckFarm.Move
{
   public class CanSwim:ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Я умею плавать!");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Interface;

namespace DuckFarm.Move
{
   public class CanQuack:IQuack
    {
       public void Quack()
        {
            Console.WriteLine("Я умею крякать!");
        }
    }
}

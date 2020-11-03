using DuckFarm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckFarm.Move
{
    class CanNotFly:IFly
    {
       public void Fly()
        {
            Console.WriteLine("Я не умею летать!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Move;

namespace Turkey_Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Turkey tur = new Turkey(new CanFly(),new CanSwim(), new CanCackle());
            Console.WriteLine("\nЯ утка!\n");
            TurkeyToDuckAdapter adaptturkey = new TurkeyToDuckAdapter(tur);
            adaptturkey.Fly();
            adaptturkey.Swim();
            adaptturkey.Quack();
            Console.ReadLine();
        }
    }
}

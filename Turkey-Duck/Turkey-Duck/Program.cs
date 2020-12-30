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
            //подключена библиотека ducklibrary (смотри в ссылках)
            Turkey tur = new Turkey(new CanFly(),new CanSwim(), new CanCackle());//то, что делает утка - с библиотеки взято, а то, что делает индюк - в этом проекте создано
            Console.WriteLine("\nЯ утка!\n");
            TurkeyToDuckAdapter adaptturkey = new TurkeyToDuckAdapter(tur); //закидываем созданного индюка в адаптер, чтоб могли просить его, как и утку, крякать
            adaptturkey.Fly();
            adaptturkey.Swim();
            adaptturkey.Quack();   //но он индюк и не понимает, поэтому кричит на своем идюшачьем
            Console.ReadLine();
        }
    }
}

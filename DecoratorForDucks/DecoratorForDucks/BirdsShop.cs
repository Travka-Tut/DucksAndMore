using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    class BirdsShop
    {

        static void Main(string[] args)
        {
            Bird bird = new Turkey();       //создаем инюка
            Console.WriteLine(bird.GetDescription()+Environment.NewLine        //выводим цену и описание голой тупой птицы
                +bird.Cost());
            //эволюционируем
            Bird bird2 = new Duck();        //создаем утку
            bird2 = new Slippers(bird2);      //одеваем ей тапки 
            bird2 = new Ribbon(bird2);        //две пары, она ж еще тупая, тип как телки, пусть будет
            bird2 = new Ribbon(bird2);       //и ленточку для красоты от Гуччи
            Console.WriteLine(bird2.GetDescription() + Environment.NewLine          //выводим что-то непонятное, что получилось
                + bird2.Cost());
            //опять эволюционируем
            Bird bird3 = new Chicken();          //создаем курицу  
            bird3 = new Glasses(bird3);          //одеваем для начала очки (+ 100 к интеллекту)
            bird3 = new Ribbon(bird3);           //ленточка, чтоб не заклевали тупые сородичи тупо за то, что не похожа на них
            bird3 = new Slippers(bird3);         //и тапочки (просто почему бы и нет)
            Console.WriteLine(bird3.GetDescription() + Environment.NewLine        //выводим сие божество на продажу
                + bird3.Cost());

            Console.ReadLine();
        }
    }
}

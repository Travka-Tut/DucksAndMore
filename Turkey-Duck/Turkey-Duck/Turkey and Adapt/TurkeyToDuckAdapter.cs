using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Ducks;
using DuckFarm.Interface;
using DuckFarm.Move;


namespace Turkey_Duck
{
    class TurkeyToDuckAdapter:BaseDuck          //наследуем от утки, чтоб можно было перевести индюшиный язык на утячий
    {
        readonly Turkey _turkey;
         
        public TurkeyToDuckAdapter(Turkey turkey)
        {
            _turkey = turkey;
        }
        public override void Quack()          //вот тут переводчик
        {
            _turkey.Cackle();
        }
        public override void Fly()
        {
            _turkey.Fly();
        }
        public override void Swim()
        {
            _turkey.Swim();
        }

    }
}

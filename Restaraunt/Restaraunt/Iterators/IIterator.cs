using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public interface IIterator        //тупо интерфейс, который выберет какое блюдо куда отправлять ( в массив или в список)
    {
        bool HasNext();
        MenuItem Next();
    }
}

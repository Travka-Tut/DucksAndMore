using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
   public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Turkey_Duck
{
  public  class CanCackle:ICackle
    {
      public  void Cackle()
        {
            Console.WriteLine("Я умею гоготать!");
        }
    }
}

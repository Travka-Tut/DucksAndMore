using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class DuckStorage
    {
        public Dictionary<string,int> Storage;

        private DuckStorage()
        {
            init();
        }

        private void init()
        {
            Storage = new Dictionary<string,int>();
            Console.WriteLine("Единственный экземпляр склада создан...");
        }

        public void Add(string duckType)
        {
            if (Storage.ContainsKey(duckType))
            {
                Storage[duckType]++;
            }
            else
            {
                Storage.Add(duckType, 1);
            }
        }

        private static DuckStorage _item;

        public static DuckStorage Get()
        {
            if (_item == null)
            {
                _item = new DuckStorage();
            }
            return _item;
        }
    }
}

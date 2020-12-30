using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class DuckStorage   //взаимодействует с классом duckfarm.
    {
        public Dictionary<string,int> Storage;          //обычный словарик для хранения данных (ключ - тип утки, значение - количество уток данного типа)

        private DuckStorage()   //т.к. конструктор приватный, не возможно создать извне экземпляр класса
        {
            init();
        }

        private void init()      //создание экземпляра
        {
            Storage = new Dictionary<string,int>();
            Console.WriteLine("Единственный экземпляр склада создан...");
        }

        public void Add(string duckType)   //добавление утки на склад
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

        private static DuckStorage _item;        //поле, содержащее экземпляр склада

        public static DuckStorage Get()        //проверка на наличие уже созданного экземпляра склада...
        {
            if (_item == null)                 
            { 
                _item = new DuckStorage();
            }
            return _item;
        }
    }
}

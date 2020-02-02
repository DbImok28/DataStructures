using System.Collections.Generic;

namespace MyDataStructures.Model.HashTable
{
    public class HashTableItem<T>
    {
        public int Key { get; set; }
        public List<T> Items {get; set;}
        public HashTableItem(int key)
        {
            Key = key;
            Items = new List<T>();
        }
    }
}

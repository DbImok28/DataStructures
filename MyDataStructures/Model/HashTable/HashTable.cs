namespace MyDataStructures.Model.HashTable
{
    public class HashTable<T>
    {
        private HashTableItem<T>[] Items;
        public HashTable(int capacity)
        {
            Items = new HashTableItem<T>[capacity];
            for (int i = 0; i < Items.Length; i++)
            {
                Items[i] = new HashTableItem<T>(i);
            }
        }
        public void Add(T item)
        {
            Items[GetHash(item)].Items.Add(item);
        }
        public bool Search(T item)
        {            
            return Items[GetHash(item)].Items.Contains(item);
        }
        private int GetHash(T item)
        {
            return item.GetHashCode() % Items.Length;
        }
    }
}

using System.Collections;

namespace MyDataStructures.Model.Map
{
    public class Map<TKey,TValue> : IEnumerable
    {
        private MapItem<TKey, TValue>[] items;
        public Map(int Capacity)
        {
            items = new MapItem<TKey, TValue>[Capacity];
        }
        public void Add(MapItem<TKey, TValue> item)
        {
            int hash = GetHash(item.Key);
            int startHash = hash;
            do
            {
                if (items[hash]?.Key.Equals(item.Key) ?? false)
                {
                    return;
                }
                hash = (hash + 1) % items.Length;
            }       
            while (hash != startHash);
            do
            {
                if (items[hash] == null)
                {
                    items[hash] = item;
                    return;
                }
                hash = (hash + 1) % items.Length;  
            }
            while (hash != startHash);
            return;
        }
        public void Add(TKey key, TValue value)
        {
            this.Add(new MapItem<TKey, TValue>(key, value));
        }
        public void Remove(TKey key)
        {
            int hash = GetHash(key);
            int startHash = hash;
            do
            {
                if (items[hash]?.Key.Equals(key) ?? false)
                {
                    items[hash] = null;
                    return;               
                }
                hash = (hash + 1) % items.Length;
            }
            while (hash != startHash);
            return;
        }
        public TValue Search(TKey key)
        {
            int hash = GetHash(key);
            int startHash = hash;
            do
            {
                if (items[hash]?.Key.Equals(key) ?? false)
                {
                    return items[hash].Value;
                }
                hash = (hash + 1) % items.Length;
            }
            while (hash != startHash);
            return default(TValue);
        }
        public int GetHash(TKey key)
        {
            return key.GetHashCode() % items.Length;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}

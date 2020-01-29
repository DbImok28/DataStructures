using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Queue
{
    public class ArrayQueue<T>
    {
        private T[] Items { get; set; }
        public int Count;
        public int Capacity;
        private T Head => Items[Count - 1];
        private T Tail => Items[0];
        public ArrayQueue(int capacity = 2)
        {            
            Items = new T[capacity];
            Capacity = capacity;
            Count = 0;
        }
        public ArrayQueue(T data, int capacity = 2) : this(capacity)
        {
            Enqueue(data);
        }
        public void Enqueue(T data)
        {
            Count++;
            if (Count >= Capacity)            
                SetCapacity(Capacity * 2);          
            Items[Count - 1] = data;
        }
        public T Dequeue()
        {
            if (Capacity / 2 >= Count)
                SetCapacity(Capacity / 2);
            Count--;
            return Items[Count];
        }
        public T Peek()
        {
            return Head;
        }
        public void SetCapacity(int NewCapacity)
        {
            T[] newItems = new T[NewCapacity];
            MigrateItems(newItems);
            Capacity = NewCapacity;
        }
        public void MigrateItems(T[] newItems)
        {
            for (int i = 0; i < Count; i++)           
                newItems[i] = Items[i];         
            Items = newItems;
        }
    }
}

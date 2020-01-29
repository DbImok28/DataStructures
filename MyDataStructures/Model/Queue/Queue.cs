using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Queue
{
    public class Queue<T>
    {
        private List<T> Items { get; set; } = new List<T>();
        public int Count => Items.Count;
        private T Head => Items.Last();
        private T Tail => Items.First();
        public Queue()
        {

        }
        public Queue(T data)
        {
            Items.Add(data);
        }
        public void Enqueue(T data)
        {
            Items.Insert(0, data);
        }
        public T Dequeue()
        {
            var item = Head;
            Items.Remove(item);           
            return item;
        }
        public T Peek()
        {
            return Head;
        }
    }
}

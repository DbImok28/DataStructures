using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Queue
{
    public class Deque<T>
    {
        private List<T> Items { get; set; } = new List<T>();
        public int Count => Items.Count;
        private T Head => Items.Last();
        private T Tail => Items.First();
        public Deque()
        {
        }
        public Deque(T data)
        {
            Items.Add(data);
        }
        public void PushBack(T data)
        {
            Items.Insert(0, data);
        }
        public void PushFront(T data)
        {
            Items.Add(data);
        }
        public T PopBack()
        {
            var data = Tail;
            Items.RemoveAt(0);
            return data;
        }
        public T PopFront()
        {
            var data = Head;
            Items.RemoveAt(Count - 1);
            return data;
        }
        public T PeekBack()
        {
            return Tail;
        }
        public T PeekFront()
        {
            return Head;
        }
    }
}

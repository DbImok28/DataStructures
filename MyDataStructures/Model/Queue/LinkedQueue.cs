using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Queue
{
    public class LinkedQueue<T>
    {
        private LinkedListItem<T> Head;
        private LinkedListItem<T> Tail;
        public int Count;
        public LinkedQueue()
        {
            Tail = null;
            Head = null;
            Count = 0;
        }
        public LinkedQueue(T data)
        {
            SetHeadAndTail(data);
        }
        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadAndTail(data);
                Count = 1;
                return;
            }
            var item = new LinkedListItem<T>(data)
            {
                Next = Tail
            };
            Tail = item;
            Count++;
        }
        public T Dequeue()
        {
            var data = Head.Data;
            var current = Tail.Next;
            var privious = Tail;
            while (current != null && current.Next != null)
            {

                privious = current;
                current = current.Next;
            }
            Head = privious;
            Head.Next = null;
            Count--;
            return data;
        }
        public T Peek()
        {
            return Head.Data;
        }
        private void SetHeadAndTail(T data)
        {
            Tail = Head = new LinkedListItem<T>(data);
        }
    }
}

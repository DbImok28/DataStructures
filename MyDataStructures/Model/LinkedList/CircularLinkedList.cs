using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDataStructures.Model.LinkedList
{
    public class CircularLinkedList<T> : IEnumerable<T>
    {
        public DoublyLinkedListItem<T> Head { get; set; }
        public int Count { get; private set; }
        public int LastIndex => Count - 1;
        public bool IsEmpty => Count <= 0;
        public CircularLinkedList()
        {
            Clear();
        }
        public CircularLinkedList(T data)
        {
            SetHead(data);
        }
        public CircularLinkedList(DoublyLinkedListItem<T> item)
        {
            Head = item;
            var current = item;
            while (current.Next != null)
            {
                current = current.Next;
                Count++;
            }
            Count++;
        }
        public void Add(T data)
        {
            var item = new DoublyLinkedListItem<T>(data);
            if (Count > 0)
            {
                item.Next = Head;
                item.Previous = Head.Previous;
                Head.Previous.Next = item;
                Head.Previous = item;
                Count++;
                return;
                // <-[an]->...<-[1]->
                // \_______________/
            }
            else
            {
                SetHead(item);
                return;
                // <-[1]->
                // \_____/
            }
        }
        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                Head.Previous.Next = Head.Next;
                Head.Next.Previous = Head.Previous;
                Head = Head.Next;
                Count--;
                return;
            }
            var current = Head.Next;
            for (int i = LastIndex - 1; i >= 0; i--)
            {
                // Console.WriteLine(i + "-" + current.Data);
                if(current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                    // <-[3]->\ x<-[2]->x /<-[1]->
                    // \_______===========_______/
                }
                current = current.Next;
            }
        }
        private void SetHead(T data)
        {
            var item = new DoublyLinkedListItem<T>(data);
            Head = item;
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }
        private void SetHead(DoublyLinkedListItem<T> item)
        {
            Head = item;
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }
        public void Clear()
        {
            Head = null;
            Count = 0;
        }      
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            for (int i = Count; i > 0; i--)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

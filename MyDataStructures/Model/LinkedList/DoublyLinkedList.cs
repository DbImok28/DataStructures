using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDataStructures.Model.LinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public DoublyLinkedListItem<T> Head { get; set; }
        public DoublyLinkedListItem<T> Tail { get; set; }
        public int Count { get; private set; }
        public int LastIndex => Count - 1;
        public bool IsEmpty => Count <= 0;
        public DoublyLinkedList()
        {
            Clear();
        }
        public DoublyLinkedList(T data)
        {
            var item = new DoublyLinkedListItem<T>(data);
            Head = item;
            Tail = Head;
            Count = 1;
        }
        public DoublyLinkedList(DoublyLinkedListItem<T> item)
        {
            Head = item;
            var current = item;
            while (current.Next != null)
            {
                current = current.Next;
                Count++;
            }
            Tail = current;
            Count++;
        }
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new DoublyLinkedListItem<T>(data);
                Tail.Next = item;
                item.Previous = Tail;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head.Previous = null;
                    Head = Head.Next;
                    Count--;
                    return;
                }
                if (Tail.Data.Equals(data))
                {
                    Tail.Next = null;
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                    Count--;
                    return;
                }
                var current = Head.Next;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        current.Next.Previous = current.Previous;
                        current.Previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }
        public T this[int index]
        {
            get
            {
                if (index <= Count)
                {
                    DoublyLinkedListItem<T> item;
                    if (index <= Count / 2)
                    {
                        item = Head;
                        for (int i = 0; i < index; i++)
                        {
                            item = item.Next;
                        }
                        return item.Data;
                    }
                    else
                    {
                        item = Tail;
                        for (int i = LastIndex; i > index; i--)
                        {
                            item = item.Previous;
                        }
                        return item.Data;
                    }

                }
                else throw new ArgumentOutOfRangeException("index > Count");
            }
            set
            {
                if (index <= Count)
                {
                    DoublyLinkedListItem<T> item;
                    if (index <= LastIndex / 2)
                    {
                        item = Head;
                        for (int i = 0; i < index; i++)
                        {
                            item = item.Next;
                        }
                        item.Data = value;
                    }
                    else
                    {
                        item = Tail;
                        for (int i = LastIndex; i > index; i--)
                        {
                            item = item.Previous;
                        }
                        item.Data = value;
                    }
                }
                else throw new ArgumentOutOfRangeException("index > Count");
            }
        }
        private void SetHeadAndTail(T data)
        {
            var item = new DoublyLinkedListItem<T>(data);
            Head = item;
            Tail = Head;
            Count = 1;
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public DoublyLinkedList<T> Reverse()
        {
            var result = new DoublyLinkedList<T>();
            var current = Tail;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}

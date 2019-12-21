using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    public class LinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Первый элемент списка.
        /// </summary>
        public LinkedListItem<T> Head { get; private set; }
        /// <summary>
        /// Последний элемент списка.
        /// </summary>
        public LinkedListItem<T> Tail { get; private set; }
        /// <summary>
        /// Количество элементов в списке.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Создать пустой список.
        /// </summary>
        public LinkedList()
        {
            Clear();
        }
        /// <summary>
        /// Создать список с одним элементом.
        /// </summary>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }
        public LinkedList(LinkedListItem<T> item)
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
        /// <summary>
        /// Добавить элемент в конец списка.
        /// </summary>        
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new LinkedListItem<T>(data);
                Tail.Next = item;
                Tail = Tail.Next;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// Добавить элемент в начало списка.
        /// </summary>   
        public void AppendHead(T data)
        {
            if(Head != null)
            {
                var item = new LinkedListItem<T>(data)
                {
                    Next = Head
                };
                Head = item;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        public void InsertAfter(T target,T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new LinkedListItem<T>(data)
                        {
                            Next = current.Next
                        };
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }            
        }
        /// <summary>
        /// Удалить один элемент.
        /// </summary>
        public void DeleteFirst(T data)
        {
            if(Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }           
        }
        /// <summary>
        /// Очистить.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /// <summary>
        /// Получить значение.
        /// </summary>        
        public T this[int index]
        {           
            get
            {
                if (index <= Count)
                {
                    var item = Head;
                    for (int i = 0; i < index; i++)
                    {
                        item = item.Next;
                    }
                    return item.Data;
                }
                else throw new ArgumentOutOfRangeException("index > Count");
            }
            set
            {
                if (index <= Count)
                {
                    var item = Head;
                    for (int i = 0; i < index; i++)
                    {
                        item = item.Next;
                    }
                    item.Data = value;
                }
                else throw new ArgumentOutOfRangeException("index > Count");
            }
        }
        private void SetHeadAndTail(T data)
        {
            var item = new LinkedListItem<T>(data);
            Head = item;
            Tail = Head;
            Count = 1;
        }
        private void SetHeadAndTail(LinkedListItem<T> item)
        {
            Head = item;
            Tail = Head;
            Count = 1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public override string ToString()
        {
            string str = "";
            foreach(var item in this)
            {
                str = str + "," + item;
            }
            return str;
        }
    }
}

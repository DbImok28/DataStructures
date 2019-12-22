using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Stack
{
    public class Stack<T> : BaseStack<T>
    {
        private List<T> collection = new List<T>();
        public override int Count => collection.Count;
        public override int LastIndex => Count - 1;
        public override bool IsEmpty => Count <= 0;
        public override void Push(T data)
        {
            collection.Add(data);
        }
        public override T Pop()
        {
            if (!IsEmpty)
            {
                var item = collection.Last();
                collection.RemoveAt(LastIndex);
                return item;
            }
            else
            {
                throw new ArgumentNullException("Stack is empty");
            }
        }
        public override T PopOrDefault()
        {
            var item = collection.LastOrDefault();
            collection.RemoveAt(LastIndex);
            return item;

        }      
        public override T Peek()
        {
            if (!IsEmpty)
            {              
                return collection.Last();
            }
            else
            {
                throw new ArgumentNullException("Stack is empty");
            }
        }
        public override T PeekOrDefault()
        {
            return collection.LastOrDefault();
        }
        public override void Clear()
        {
            collection.Clear();
        }
        public Stack()
        {

        }
        public Stack(List<T> items)
        {
            collection = items;
        }
        public override string ToString()
        {
            return $"Stack - count:{Count}";
        }
    }
}

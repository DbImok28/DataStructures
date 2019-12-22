using System;

namespace MyDataStructures.Model.Stack
{
    public class LinkedStack<T> : BaseStack<T>
    {
        public StackItem<T> Head { get; set; }
        public override int Count { get; set; }
        public override int LastIndex => Count - 1;
        public override bool IsEmpty => Count <= 0;
        public override void Push(T data)
        {
            var item = new StackItem<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }
        public override T Pop()
        {
            if (!IsEmpty)
            {
                var item = Head.Data;
                Head = Head.Next;
                Count--;
                return item;
            }
            else
            {
                throw new ArgumentNullException("Stack is empty");
            }
        }
        public override T PopOrDefault()
        {
            if (!IsEmpty)
            {
                var item = Head.Data;
                Head = Head.Next;
                Count--;
                return item;
            }
            else
            {
                return default(T);
            }
        }
        public override T Peek()
        {
            if (!IsEmpty)
            {               
                return Head.Data;
            }
            else
            {
                throw new ArgumentNullException("Stack is empty");
            }
        }
        public override T PeekOrDefault()
        {
            if (!IsEmpty)
            {
                return Head.Data;
            }
            else
            {
                return default(T);
            }
        }
        public override void Clear()
        {
            Head = null;
            Count = 0;
        }
        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }
        public LinkedStack(T data)
        {
            Head = new StackItem<T>(data);
            Count = 1;
        }
        public override string ToString()
        {
            return $"LinkedStack - count:{Count}";
        }
    }
}

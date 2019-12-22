using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Stack
{
    public class ArrayStack<T> : BaseStack<T>
    {
        private T[] collection;
        private readonly int size;
        public int currentIndex = -1;
        public override int Count => currentIndex + 1;
        public override int LastIndex => currentIndex;
        public override bool IsEmpty => Count <= 0;
        public override void Push(T data)
        {
            if (Count < size)
            {
                collection[currentIndex + 1] = data;
                currentIndex++;
            }
            else
            {
                throw new StackOverflowException("Stack overflow");
            }
        }
        public override T Pop()
        {
            if (!IsEmpty)
            {
                var item = collection[currentIndex];
                collection[currentIndex] = default(T);
                currentIndex--;
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
                var item = collection[currentIndex];
                collection[currentIndex] = default(T);
                currentIndex--;
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
                return collection[currentIndex];
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
                return collection[currentIndex];
            }
            else
            {
                return default(T);
            }
        }
        public override void Clear()
        {
            collection = new T[size];
            currentIndex = -1;
        }        
        public ArrayStack(int size = 25)
        {
            this.size = size;
            currentIndex = -1;
            collection = new T[size];
        }
        public ArrayStack(T data, int size = 25):this(size)
        {
            collection[0] = data;
            currentIndex = 0;
        }
        public override string ToString()
        {
            return $"Stack - count:{Count}";
        }
    }
}

using System;


namespace MyDataStructures.Model.Stack
{
    public class BaseStack<T>
    {
        public virtual int Count { get; set; }
        public virtual int LastIndex => Count - 1;
        public virtual bool IsEmpty => true;
        public virtual void Push(T data)
        {
            throw new NotImplementedException();
        }
        public virtual T Pop()
        {
            throw new NotImplementedException();
        }
        public virtual T PopOrDefault()
        {
            throw new NotImplementedException();
        }
        public virtual T Peek()
        {
            throw new NotImplementedException();
        }
        public virtual T PeekOrDefault()
        {
            throw new NotImplementedException();
        }
        public virtual void Clear()
        {
            throw new NotImplementedException();
        }
    }
}

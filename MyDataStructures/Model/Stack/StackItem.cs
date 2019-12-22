using System;

namespace MyDataStructures.Model.Stack
{
    public class StackItem<T>
    {
        private T data = default(T);
        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else throw new ArgumentNullException("Data cannot be null", nameof(value));
            }
        }
        public StackItem<T> Next { get; set; }
        public StackItem(T data)
        {
            this.data = data;
        }
        public StackItem(T data, StackItem<T> next) : this(data)
        {
            Next = next;
        }       
    }
}

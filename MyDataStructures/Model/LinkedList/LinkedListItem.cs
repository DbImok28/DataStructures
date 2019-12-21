using System;

namespace MyDataStructures.Model
{
    public class LinkedListItem<T>
    {
        /// <summary>
        /// Данные.
        /// </summary>
        private T data = default(T);
        /// <summary>
        /// Следующий элемент односвязного списка.
        /// </summary>
        public LinkedListItem<T> Next = null;
        /// <summary>
        /// Получить данные.
        /// </summary>
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
        public LinkedListItem(T data, LinkedListItem<T> next) : this(data)
        {
            Next = next;
        }
        public LinkedListItem(T data)
        {
            this.data = data;
        }
        public override string ToString()
        {
            return data.ToString();
        }
        public override bool Equals(object obj)
        {
            return data.Equals(obj);
        }
        public override int GetHashCode()
        {
            return int.Parse(data.ToString());
        }
    }
}

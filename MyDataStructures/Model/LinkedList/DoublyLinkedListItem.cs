using System;
using System.Collections;

namespace MyDataStructures.Model.LinkedList
{
    public class DoublyLinkedListItem<T>
    {
        public T Data { get; set; }
        public DoublyLinkedListItem<T> Previous { get; set; }
        public DoublyLinkedListItem<T> Next { get; set; }

        public DoublyLinkedListItem(T data)
        {
            Data = data;
        }
        public DoublyLinkedListItem(T data, DoublyLinkedListItem<T> next, DoublyLinkedListItem<T> previous) : this(data)
        {
            Next = next;
            Previous = previous;
        }
        public override string ToString()
        {
            return Data.ToString(); 
        }       
    }
}

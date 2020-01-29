using MyDataStructures.Model.LinkedList;

namespace MyDataStructures.Model.Queue
{
    public class LinkedDeque<T>
    {
        private DoublyLinkedListItem<T> Head;
        private DoublyLinkedListItem<T> Tail;
        public int Count;
        public LinkedDeque()
        {
            Head = Tail = null;
        }
        public LinkedDeque(T data)
        {
            SetHeadAndTail(data);
        }
        public void PushBack(T data)
        {
            if (Count == 0)
            {
                SetHeadAndTail(data);
                return;
            }
            var item = new DoublyLinkedListItem<T>(data);
            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }
        public void PushFront(T data)
        {
            if (Count == 0)
            {
                SetHeadAndTail(data);
                return;
            }
            var item = new DoublyLinkedListItem<T>(data);
            Head.Previous = item;
            item.Next = Head;
            Head = item;
            Count++;
        }
        public T PopBack()
        {
            if (Count == 0)
            {
                return default(T);
            }
            T data;
            if (Count == 1)
            {
                data = Tail.Data;
                Head = Tail = null;
                return data;
            }
            data = Tail.Data;
            Tail.Previous.Next = null;
            Tail = Tail.Previous;
            Count--;
            return data;
        }
        public T PopFront()
        {
            if (Count == 0)
            {
                return default(T);
            }
            T data;
            if (Count == 1)
            {
                data = Tail.Data;
                Head = Tail = null;
                return data;
            }
            data = Head.Data;
            Head.Next.Previous = null;
            Head = Head.Next;
            Count--;
            return data;
        }
        public T PeekBack()
        {
            return Tail.Data;
        }
        public T PeekFront()
        {
            return Head.Data;
        }
        private void SetHeadAndTail(T data)
        {
            Head = Tail = new DoublyLinkedListItem<T>(data);
            Count = 1;
        }
    }
}

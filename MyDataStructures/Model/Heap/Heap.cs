using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDataStructures.Model.Heap
{
    public class Heap<T> : IEnumerable
        where T : IComparable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public Heap()
        {

        }
        public Heap(T data)
        {
            Add(data);
        }
        public Heap(List<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }

        }
        public Heap(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public T GetMax()
        { 
            if (Count > 0)
                return items[0];
            return default(T);
        }
        public void Add(T data)
        {
            if (data == null)
            {
                throw new NullReferenceException("data is null");
            }
            items.Add(data);
            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);
            while (currentIndex > 0 && items[parentIndex].CompareTo(items[currentIndex]) == -1)
            {
                Swap(currentIndex, parentIndex);
                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }
        private void Swap(int currentIndex, int parentIndex)
        {
            var temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }
        public T PopMax ()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort();
            return result;
        }
        private void Sort()
        {
            Sort(0);
        }
        private void Sort(int currentIndex)
        {
            int leftIndex, rightIndex, maxIndex;
            maxIndex = currentIndex;
            while (currentIndex < Count)
            {
                leftIndex = currentIndex * 2 + 1;
                rightIndex = currentIndex * 2 + 2;
                if (leftIndex < Count && items[leftIndex].CompareTo(items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }
                if (rightIndex < Count && items[rightIndex].CompareTo(items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }
                if (maxIndex == currentIndex)
                {
                    break;
                }
                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }

        }
        public int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public IEnumerator GetEnumerator()
        {
            var tempHeap = this;
            while (tempHeap.Count > 0)
            {
                yield return tempHeap.PopMax();
            }
        }
    }
}

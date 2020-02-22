using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Set
{
    public class Set<T> : IEnumerable
    {
        public List<T> Items = new List<T>();
        public int Count => Items.Count;
        public Set() { }
        public Set(T data)
        {
            Items.Add(data);
        }
        public Set(IEnumerable<T> items)
        {
            this.Items = items.ToList();
        }
        public void Add(T data)
        {
            if(!Items.Contains(data))               
                Items.Add(data);
        }
        public void Remove(T data)
        {
            Items.Remove(data);
        }
        public Set<T> Union(Set<T> setB)
        {
            return new Set<T>(Items.Union(setB.Items));          
        }
        public Set<T> Intersection(Set<T> setB)
        {
            return new Set<T>(Items.Intersect(setB.Items));
        }
        public Set<T> Difference(Set<T> setB)
        {
            return new Set<T>(Items.Except(setB.Items));
            //var result = new Set<T>(Items);
            //foreach (var item in setB.Items)
            //{
            //    result.Remove(item);
            //}
            //return result;
        }
        public Set<T> SymetricDifference(Set<T> setB)
        {
            //return new Set<T>(Items.Except(setB.Items).Union(setB.Items.Except(Items)));
            var result = new Set<T>();
            bool flagEquals = false;
            foreach (var itemA in Items)
            {
                flagEquals = false;
                foreach (var itemB in setB.Items)
                {
                    if (itemA.Equals(itemB))
                    {
                        flagEquals = true;
                        break;
                    }
                }
                if (!flagEquals)                
                    result.Add(itemA);                
            }
            foreach (var itemB in setB.Items)
            {
                flagEquals = false;
                foreach (var itemA in Items)
                {
                    if (itemB.Equals(itemA))
                    {
                        flagEquals = true;
                        break;
                    }
                }
                if (!flagEquals)
                    result.Add(itemB);
            }
            return result;
        }
        public bool Subset(Set<T> setB)
        {
            return setB.Items.All(i => Items.Contains(i));
        }
        
        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}

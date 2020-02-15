using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Tree
{
    public class TrieNode<T>
    {
        public char Symbol { get; set; }
        public T Data { get; set; }
        public bool IsWord { get; set; }
        public string Prefix { get; set; }
        public Dictionary<char, TrieNode<T>> SubNodes { get; set; }
        public TrieNode(char symbol, T data,string prefix)
        {
            Symbol = symbol;
            Data = data;
            Prefix = prefix;
            SubNodes = new Dictionary<char, TrieNode<T>>();
        }
        //public TrieNode()
        //{
        //    Symbol = ' ';
        //}
        public TrieNode<T> Find(char symbol)
        {
            if (SubNodes.TryGetValue(symbol, out TrieNode<T> node))
            {
                return node;
            }
            return null;

        }       
        public override string ToString()
        {
            return Data.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is TrieNode<T> item)
                return item.Data.Equals(Data);
            else
                return false;

        }
        public override int GetHashCode()
        {
            return Data.GetHashCode();
        }
    }
}

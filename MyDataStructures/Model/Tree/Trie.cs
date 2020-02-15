using System;

namespace MyDataStructures.Model.Tree
{
    public class Trie<T>
    {
        private TrieNode<T> Root { get; set; }
        public Trie()
        {
            Root = new TrieNode<T>('\0', default(T),"");
        }
        public void Add(string key, T data)
        {
            AddNode(key, data, Root);
        }
        public void AddNode(string key, T data, TrieNode<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (!node.IsWord)
                {
                    node.Data = data;
                    node.IsWord = true;
                }
                return;
            }            
            var symbol = key[0];
            TrieNode<T> value = node.Find(symbol);
            if (value != null)
            {
                AddNode(key?.Substring(1, key.Length - 1), data, value);
            }
            else
            {
                value = new TrieNode<T>(symbol, data, node.Prefix + symbol);
                node.SubNodes.Add(symbol, value);
                AddNode(key?.Substring(1, key.Length - 1), data, value);
            }

        }
        public void Remove(string key)
        {
            TrieNode<T> value = SearchNode(key);            
            value.IsWord = false;
            value.Data = default(T);
        }
        public T Search(string key)
        {
            return SearchNode(key).Data;
        }
        public TrieNode<T> SearchNode(string key, TrieNode<T> node)
        {
            TrieNode<T> value = node;
            foreach (var symbol in key)
            {
                value = value.Find(symbol);
                if (value == null)
                {
                    return null;
                }
            }
            return value;
        }
        public TrieNode<T> SearchNode(string key)
        {
            TrieNode<T> value = Root;
            foreach (var symbol in key)
            {
                value = value.Find(symbol);
                if (value == null)
                {
                    return null;
                }
            }
            return value;
        }
    }
}
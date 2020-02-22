using System;
using MyDataStructures.Model;
using MyDataStructures.Model.Graph;
using MyDataStructures.Model.HashTable;
using MyDataStructures.Model.Heap;
using MyDataStructures.Model.LinkedList;
using MyDataStructures.Model.Map;
using MyDataStructures.Model.Queue;
using MyDataStructures.Model.Set;
using MyDataStructures.Model.Stack;
using MyDataStructures.Model.Tree;

namespace MyDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            #region LinkedList
            Console.WriteLine("LinkedList");
            var list = new LinkedList<int>
            {
                1,
                2,
                3
            };
            // :)            
            var list2 = new LinkedList<int>(new LinkedListItem<int>(1,
                                            new LinkedListItem<int>(2,
                                            new LinkedListItem<int>(3)
                                            )));
            #region :)
            //var list3 = new Model.LinkedList<int>(new Model.LinkedListItem<int>(1,
            //                                      new Model.LinkedListItem<int>(2,
            //                                      new Model.LinkedListItem<int>(3,
            //                                      new Model.LinkedListItem<int>(4,
            //                                      new Model.LinkedListItem<int>(5,
            //                                      new Model.LinkedListItem<int>(6,
            //                                      new Model.LinkedListItem<int>(7)
            //                                      )))))));
            #endregion
            list[0] = 9;
            Console.WriteLine(list[0]);
            list.Delete(1);
            list.AppendHead(1);
            list.InsertAfter(3, 4);
            foreach (var item in list)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            #endregion
            #region DoublyLinkedList
            Console.WriteLine("DoublyLinkedList");
            var DoublyList1 = new DoublyLinkedList<int>(1)
            {
                2,
                3,
                4,
                5
            };
            DoublyList1[4] = 0;
            DoublyList1.Delete(1);
            foreach (var item in DoublyList1)
            {
                Console.WriteLine(item);
            }
            DoublyList1 = DoublyList1.Reverse();
            foreach (var item in DoublyList1)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region CircularLinkedList
            Console.WriteLine("CircularLinkedList");
            var CircularList1 = new CircularLinkedList<int>(0)
            {
                1,
                2,
                3,
                4
            };
            //CircularList1.Delete(1);          
            foreach (var item in CircularList1)
            {
                Console.WriteLine(item);
            }

            #endregion
            #endregion
            #region Stack
            #region ListStack
            Console.WriteLine("Stack");
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            #endregion
            #region linkedStack
            var linkedStack = new Stack<int>();
            Console.WriteLine("linkedStack");
            linkedStack.Push(1);
            linkedStack.Push(2);
            linkedStack.Push(3);
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            #endregion
            #region ArrayStack
            var arrayStack = new ArrayStack<int>(3);
            Console.WriteLine("ArrayStack");
            arrayStack.Push(1);
            arrayStack.Push(2);
            arrayStack.Push(3);
            //arrayStack.Push(4);
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            #endregion
            #region BaseStack
            BaseStack<int> stack2 = new LinkedStack<int>();
            Console.WriteLine("BaseStack");
            stack2.Push(1);
            stack2.Push(2);
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            #endregion
            #endregion
            #region Queue
            #region Queue
            Console.WriteLine("Queue");
            var queue1 = new Queue<int>();
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            Console.WriteLine(queue1.Dequeue());
            Console.WriteLine(queue1.Peek());
            Console.WriteLine(queue1.Dequeue());
            Console.WriteLine(queue1.Dequeue());
            #endregion
            #region ArrayQueue
            Console.WriteLine("ArrayQueue");
            var ArrayQueue1 = new ArrayQueue<int>(2, 2);
            ArrayQueue1.Enqueue(1);
            ArrayQueue1.Enqueue(2);
            ArrayQueue1.Enqueue(3);
            ArrayQueue1.Enqueue(4);
            Console.WriteLine("Capacity -> " + ArrayQueue1.Capacity);
            Console.WriteLine(ArrayQueue1.Dequeue());
            Console.WriteLine(ArrayQueue1.Peek());
            Console.WriteLine(ArrayQueue1.Dequeue());
            Console.WriteLine(ArrayQueue1.Dequeue());
            Console.WriteLine(ArrayQueue1.Dequeue());
            Console.WriteLine("Capacity -> " + ArrayQueue1.Capacity);
            #endregion
            #region LinkedQueue
            Console.WriteLine("LinkedQueue");
            var linkedQueue1 = new LinkedQueue<int>();
            linkedQueue1.Enqueue(1);
            linkedQueue1.Enqueue(2);
            linkedQueue1.Enqueue(3);
            Console.WriteLine(linkedQueue1.Dequeue());
            Console.WriteLine(linkedQueue1.Peek());
            Console.WriteLine(linkedQueue1.Dequeue());
            Console.WriteLine(linkedQueue1.Dequeue());
            #endregion
            #region Deque
            Console.WriteLine("Deque");
            var Deque = new Deque<int>();
            Deque.PushBack(1);
            Deque.PushBack(2);
            Deque.PushBack(3);
            Deque.PushFront(4);
            Deque.PushFront(5);
            Deque.PushFront(6);
            Console.WriteLine(Deque.PopFront());
            Console.WriteLine(Deque.PopFront());
            Console.WriteLine(Deque.PopFront());
            Console.WriteLine(Deque.PopBack());
            Console.WriteLine(Deque.PopBack());
            Console.WriteLine(Deque.PopBack());
            #endregion
            #region LinkedDeque
            Console.WriteLine("LinkedDeque");
            var LinkedDeque = new LinkedDeque<int>();
            LinkedDeque.PushBack(1);
            LinkedDeque.PushBack(2);
            LinkedDeque.PushBack(3);
            LinkedDeque.PushFront(4);
            LinkedDeque.PushFront(5);
            LinkedDeque.PushFront(6);
            Console.WriteLine(LinkedDeque.PopFront());
            Console.WriteLine(LinkedDeque.PopFront());
            Console.WriteLine(LinkedDeque.PopFront());
            Console.WriteLine(LinkedDeque.PopBack());
            Console.WriteLine(LinkedDeque.PopBack());
            Console.WriteLine(LinkedDeque.PopBack());
            #endregion
            #endregion
            #region Set
            Console.WriteLine("Set");
            var set1 = new Set<int>
            {
                1,
                2,
                3
            };
            var set2 = new Set<int>
            {
                2,
                3,
                4
            };
            Console.WriteLine(" Union");
            foreach (var item in set1.Union(set2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" Intersection");
            foreach (var item in set1.Intersection(set2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" Difference");
            foreach (var item in set1.Difference(set2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" SymetricDifference");
            foreach (var item in set1.SymetricDifference(set2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" Subset");
            Console.WriteLine(set1.Subset(set2));

            #endregion
            #region HashTable
            Console.WriteLine("HashTable");
            var HashTable1 = new HashTable<string>(20);
            HashTable1.Add("Hash 1");
            HashTable1.Add("Hash 2");
            HashTable1.Add("Hash 2.2");
            HashTable1.Add("Hash 5");
            Console.WriteLine(HashTable1.Search("Hash 2.2"));
            Console.WriteLine(HashTable1.Search("Hash 3"));
            #endregion
            #region Map
            Console.WriteLine("Map");
            var map1 = new Map<int, int>(5)
            {
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 8, 8 }
            };
            map1.Remove(2);
            map1.Add(9, 9);
            foreach (var item in map1)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(map1.Search(8));
            #endregion
            #region Tree
            #region BinarySearchTree
            Console.WriteLine("BinarySearchTree");
            var binarySearchTree1 = new BinarySearchTree<int>
            {
                3,
                5,
                1,
                2,
                4,
                0
            };
            //        3
            //     /     \
            //    1       5
            //   / \     /
            //  0   2   4
            foreach (var item in binarySearchTree1.Preorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("-Preorder");
            foreach (var item in binarySearchTree1.Postorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("-Postorder");
            foreach (var item in binarySearchTree1.Inorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("-Inorder");
            var binarySearchTree2 = binarySearchTree1.Copy();
            binarySearchTree1.Add(99);
            foreach (var item in binarySearchTree2.Inorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("-CopyInorder");
            #endregion
            #region Trie
            Console.WriteLine("Trie");
            var trie1 = new Trie<int>();
            trie1.Add("привет", 2);
            trie1.Add("лимон", 1);
            trie1.Add("призрак", 1);
            trie1.Add("патриот", 1);
            trie1.Add("суп", 3);
            trie1.Add("пшеница", 3);
            trie1.Add("кактус", 2);
            trie1.Add("претензия", 1);
            trie1.Add("окно", 1);
            trie1.Remove("привет");
            Console.WriteLine("привет - " + trie1.Search("привет"));
            Console.WriteLine("кактус - " + trie1.Search("кактус"));
            #endregion
            #endregion
            #region Heap
            Console.WriteLine("Heap");
            var rnd = new Random();
            var list3 = new System.Collections.Generic.List<int>();
            for (int i = 0; i < 10; i++)
            {
                list3.Add(rnd.Next(-100, 100));
            }
            var heap1 = new Heap<int>(list3);

            foreach (var item in heap1)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Graph
            Console.WriteLine("Graph");
            var graph1 = new Graph<int>();

            #region initGraph1
            var v0 = new GraphVertex<int>(0, 0);
            var v1 = new GraphVertex<int>(1, 1);
            var v2 = new GraphVertex<int>(2, 2);
            var v3 = new GraphVertex<int>(3, 3);
            var v4 = new GraphVertex<int>(4, 4);
            var v5 = new GraphVertex<int>(5, 5);
            var v6 = new GraphVertex<int>(6, 6);
            var v7 = new GraphVertex<int>(7, 7);
            graph1.Add(v0);
            graph1.Add(v1);
            graph1.Add(v2);
            graph1.Add(v3);
            graph1.Add(v4);
            graph1.Add(v5);
            graph1.Add(v6);
            graph1.Add(v7);
            graph1.Add(new GraphEdge<int>(v1, v2, 8));
            graph1.Add(new GraphEdge<int>(v1, v3, 5));
            graph1.Add(new GraphEdge<int>(v3, v4, 9));
            graph1.Add(new GraphEdge<int>(v2, v5, 7));
            graph1.Add(new GraphEdge<int>(v2, v6, 4));
            graph1.Add(new GraphEdge<int>(v5, v6, 1));
            graph1.Add(new GraphEdge<int>(v6, v5, 1));
            #endregion

            PrintGraphMatrix(graph1);
            if (graph1.Wave(v1, v2))
            {
                Console.Write("v2 - ");
                foreach (var vertex in graph1.GetVertexList(v2))
                {
                    Console.Write(vertex + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("v2 - NoContain");
            }
            #endregion
        }
        static void PrintGraphMatrix<T>(Graph<T> graph)
        {
            var matrix = graph.GetMatrix();
            Console.WriteLine();
            Console.Write("   ");
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("  -");
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write(i + "| ");
                for (int f = 0; f < graph.VertexCount; f++)
                {
                    Console.Write(matrix[i, f]);
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            Console.Write("  -");
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine();
        }
    }
}

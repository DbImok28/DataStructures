using System;
using MyDataStructures.Model;
using MyDataStructures.Model.LinkedList;
using MyDataStructures.Model.Queue;
using MyDataStructures.Model.Set;
using MyDataStructures.Model.Stack;

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
            var ArrayQueue1 = new ArrayQueue<int>(2,2);
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
            var set1 = new Set<int>();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            var set2 = new Set<int>();
            set2.Add(2);
            set2.Add(3);
            set2.Add(4);
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
        }
    }
}

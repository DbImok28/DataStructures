using System;
using MyDataStructures.Model;
using MyDataStructures.Model.LinkedList;
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
        }
    }
}

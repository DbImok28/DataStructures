using System;

namespace MyDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>
            {
                1,
                2,
                3
            };

            // :)
            var list2 = new Model.LinkedList<int>(new Model.LinkedListItem<int>(1,
                                                  new Model.LinkedListItem<int>(2,
                                                  new Model.LinkedListItem<int>(3)
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
            list.DeleteFirst(1);
            list.AppendHead(1);
            list.InsertAfter(3, 4);
            foreach (var item in list)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            foreach (var item in list2)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
    }
}

using System;
using AVLTree;
namespace BSTDriverProgram
{
    class AvlDriver
    {
        static void Main(string[] args)
        {
            AvlTree AVL = new AvlTree();
            AVL.Insert(5);
            AVL.Insert(4);
            AVL.Insert(3);
            AVL.Insert(2);
            AVL.Insert(1);
            AVL.PreOrder();

            AVL.Delete(3);
            AVL.Delete(1);
            AVL.PreOrder();

            AVL.Clear();

            AVL.Insert(1);
            AVL.Insert(2);
            AVL.Insert(3);
            AVL.Insert(4);
            AVL.Insert(5);
            AVL.PreOrder();

            AVL.Delete(5);
            AVL.Delete(1);
            AVL.Delete(3);
            AVL.PreOrder();

            AVL.Clear();

            AVL.Insert(1);
            AVL.Insert(4);
            AVL.Insert(2);
            AVL.Insert(3);
            AVL.Insert(9999);
            AVL.Insert(5);
            AVL.Insert(12);
            AVL.Insert(654);
            AVL.Insert(21);
            AVL.Insert(63);
            AVL.PreOrder();

            AVL.Delete(5);
            AVL.Delete(1);
            AVL.Delete(654);
            AVL.Insert(111);
            AVL.Delete(63);
            AVL.Delete(4);
            AVL.PreOrder();
            AVL.Delete(21);
            AVL.Insert(435);
            AVL.PreOrder();
            AVL.Delete(12);
            AVL.Delete(41);
            AVL.PreOrder();

            Console.ReadKey();
            AVL.Clear();
        }
    }
}

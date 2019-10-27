using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binary.Search.Tree;
namespace BSTDriverProgram
{
    class BSTDriver
    {
        static void Main(string[] args)
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.Insert(5);
            BST.Insert(4);
            BST.Insert(3);
            BST.Insert(2);
            BST.Insert(1);
            BST.PreOrder();

            BST.Delete(3);
            BST.Delete(1);
            //BST.Delete(5);
            BST.PreOrder();

            BST.Clear();

            BST.Insert(1);
            BST.Insert(2);
            BST.Insert(3);
            BST.Insert(4);
            BST.Insert(5);
            BST.PreOrder();

            BST.Delete(5);
            BST.Delete(1);
            BST.Delete(3);
            BST.PreOrder();

            BST.Clear();

            BST.Insert(1);
            BST.Insert(4);
            BST.Insert(2);
            BST.Insert(3);
            BST.Insert(9999);
            BST.Insert(5);
            BST.Insert(12);
            BST.Insert(654);
            BST.Insert(21);
            BST.Insert(63);
            BST.PreOrder();

            BST.Delete(5);
            BST.Delete(1);
            BST.Delete(654);
            BST.Insert(111);
            BST.Delete(63);
            BST.Delete(4);
            BST.PreOrder();
            BST.Delete(21);
            BST.Insert(435);
            BST.PreOrder();
            BST.Delete(12);
            BST.Delete(41);
            BST.PreOrder();

            Console.ReadKey();
            BST.Clear();
        }
    }
}

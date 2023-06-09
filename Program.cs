using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Binary_Search_Tree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTreeDemo bTree = new BinarySearchTreeDemo();

            bTree.Insert(56);
            bTree.Insert(30);
            bTree.Insert(70);

            Console.WriteLine("\nPreOrder: ");
            bTree.PreOrder(bTree.ReturnRoot());

            Console.WriteLine("\nInOrder: ");
            bTree.InOrder(bTree.ReturnRoot());

            Console.WriteLine("\nPostOrder: ");
            bTree.PostOrder(bTree.ReturnRoot());
        }
    }
}

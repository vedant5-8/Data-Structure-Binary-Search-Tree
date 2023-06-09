using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Data_Structure___Binary_Search_Tree
{
    internal class BinarySearchTreeDemo
    {
        Node root;
        public BinarySearchTreeDemo()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.Write(root.data + " ");
                InOrder(root.right);
            }
        }

        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.Write(root.data + " ");
            }
        }

        public bool Search(int data)
        {
            Node current = root;

            while (current != null)
            {
                if (data == current.data)
                {
                    return true;
                } 
                else if (data < current.data)
                {
                    current = current.left;
                } 
                else
                {
                    current = current.right;
                }
            }

            return false;
        }

    }
}
